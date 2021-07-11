using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NAlumno
    {
        private DAlumnos dAlumno = new DAlumnos();

        private Listas dListas = new Listas();
        private DAlumnosWCF DAlumnowcf = new DAlumnosWCF();
        private DAlumnosRep dcAlumnosR = new DAlumnosRep();

        //consultar con datos alumno 
        //public List<Alumnos> Consultar() => dAlumno.Consultar();

        //consultar con el repositorio
        public List<Alumnos> Consultar() => dcAlumnosR.Consultar();

        //Consultar un alumno con datos
        // public Alumnos ConsultarDetalles(int id) => dAlumno.ConsultarUno(id);

        //Consultar detalles con web services WCF
        //public Alumnos ConsultarDetalles(int id) => DAlumnowcf.ConsultarUno(id);

        //Consultar detalles con Repositorios
        public Alumnos ConsultarDetalles(int id) => dcAlumnosR.ConsultarUno(id);

        public List<Estados> ConsultarEstados() => dListas.ConsultarEstados();
        public List<EstatusAlumnos> ConsultarEAlumno() => dListas.ConsultarEstatus();

        //Crear con DATOS
        //public Alumnos Crear(Alumnos alumno) => dAlumno.Crear(alumno);

        //Crear con web service WCF
        //public Alumnos Crear(Alumnos alumno) => DAlumnowcf.CrearAlumno(alumno);

        //Crear un alumno con un Repositorio
        public void Crear(Alumnos alumno) => dcAlumnosR.Crear(alumno);

        //Editar con datos
        //public void Editar(Alumnos alumnos) => dAlumno.Editar(alumnos);

        //Editar con web services WCF
       // public void Editar(Alumnos alumnos) => DAlumnowcf.EditarAlumno(alumnos);

        //Editar con repositorio
        public void Editar(Alumnos alumno) => dcAlumnosR.Editar(alumno);

        //Eliminar con datos entity
        // public void Eliminar(int id) => dAlumno.Eliminar(id);

        //Eliminar con web services WCF
        //public void Eliminar(int id) => DAlumnowcf.EliminarAlumno(id);

        //Eliminar con Repositorio
        public void Eliminar(int id) => dcAlumnosR.Eliminar(id);

         //public void Eliminar(Alumnos alumnos) => dcAlumnosR.Eliminar(alumnos);







    }

}
