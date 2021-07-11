using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.ServiceWCFAlumno;
using Entidades;


namespace Datos
{
   public  class DAlumnosWCF
    {
        WcfAlumnoClient alumnoWCF = new WcfAlumnoClient();
        Alumnos alumnos = new Alumnos();
        public Alumnos ConsultarUno(int id)
        {
            
           // DCAlumno almWCF = new DCAlumno();

            alumnoWCF.Open();
            alumnos = Convertidor.convertidorAlumno(alumnoWCF.ConsultarUno(id));
            alumnoWCF.Close();

            return alumnos;
        }

        public void EditarAlumno(Alumnos alumno)
        {
            alumnoWCF.Open();
            alumnoWCF.Editar(Convertidor.convertidorAlumnoWCF(alumno));
            alumnoWCF.Close();
        }

        public void EliminarAlumno(int id)
        {
            alumnoWCF.Open();
            alumnoWCF.Eliminar(id);
            alumnoWCF.Close();
        }
       
        public Alumnos CrearAlumno(Alumnos alumno)
        {
            alumnoWCF.Open();
            alumnoWCF.Crear(Convertidor.convertidorAlumnoWCF(alumno));
            alumnoWCF.Close();
            return alumno;

        }

        //public List<Alumnos> ConsultarAlumnos()
        //{
        //    //var alumnos = db.Alumnos.Include(a => a.Estados).Include(a => a.EstatusAlumnos);
        //    var listAl = alumnoWCF.Consultar();

        //    return listAl;
        //}
    }
}
