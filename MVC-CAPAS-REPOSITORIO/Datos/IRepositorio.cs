using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IRepositorio<T> where T: class
    {
        List<T> Consultar(bool propLoading);
        T Consultar(Expression<Func<T, bool>> predicado, bool propLoading);
        T Consultar(Expression<Func<T, bool>> predicado, List<Expression<Func<T, bool>>> Includes);
        void crear(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        void Eliminar(Expression<Func<T, bool>> predicado);
    }
}
