using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Datos
{
    public abstract class Repositorio<T> : IRepositorio<T> where T : class
    {
        InstitutoTichEntities _institutoDb;

        public Repositorio()
        {
            _institutoDb = new InstitutoTichEntities();
        }
        public void Actualizar(T entidad)
        {
            _institutoDb.Entry(entidad).State = EntityState.Modified;
            _institutoDb.SaveChanges();
           
        }

        public List<T> Consultar(bool propLoading = true)
        {
            _institutoDb.Configuration.ProxyCreationEnabled = propLoading;
            _institutoDb.Configuration.LazyLoadingEnabled = propLoading;
            return (List<T>) _institutoDb.Set<T>().ToList();
           
        }

        public T Consultar(Expression<Func<T, bool>> predicado, bool propLoading=true)
        {
            _institutoDb.Configuration.ProxyCreationEnabled = propLoading;
            _institutoDb.Configuration.LazyLoadingEnabled = propLoading;
            return _institutoDb.Set<T>().FirstOrDefault<T>(predicado);
        }

        public T Consultar(Expression<Func<T, bool>> predicado, List<Expression<Func<T, bool>>> Includes)
        {
            throw new NotImplementedException();
        }

        public void crear(T entidad)
        {
            _institutoDb.Set<T>().Add(entidad);
            _institutoDb.SaveChanges();
           
        }

        public void Eliminar(T entidad)
        {
            _institutoDb.Entry(entidad).State = EntityState.Deleted;
            _institutoDb.SaveChanges();
        }

        public void Eliminar(Expression<Func<T, bool>> predicado)
        {
            _institutoDb.Entry(Consultar(predicado)).State = EntityState.Deleted;
            _institutoDb.SaveChanges();
        }
    }
}
