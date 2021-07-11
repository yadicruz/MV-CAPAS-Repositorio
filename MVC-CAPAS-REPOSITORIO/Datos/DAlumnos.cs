using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity;
using System.Web.Mvc;

namespace Datos
{
    public class DAlumnos
    {
        InstitutoTichEntities db = new InstitutoTichEntities();

        public List<Alumnos> Consultar()
        {
            var alumnos = db.Alumnos.Include(a => a.Estados).Include(a => a.EstatusAlumnos);
            return alumnos.ToList();
            
        }

        public Alumnos ConsultarUno(int id)
        {
            Alumnos alumnos = db.Alumnos.Find(id);
           
            return alumnos;
        }
        public Alumnos Detalles(int id)
        {
            Alumnos alumno = db.Alumnos.Find(id); 
            return alumno;
        }

        public Alumnos Crear(Alumnos alumno)
        {
            db.Alumnos.Add(alumno);
            db.SaveChanges();
            return alumno;
        }

        public Alumnos Editar(Alumnos alumno)
        {
            db.Entry(alumno).State = EntityState.Modified;
            db.SaveChanges();
            return alumno;

        }
        
        public void Eliminar(int id)
        {
            Alumnos alumnos = db.Alumnos.Find(id);
            db.Alumnos.Remove(alumnos);
            db.SaveChanges();

        }

        

        
    }
}
