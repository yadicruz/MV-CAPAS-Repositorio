using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entidades;


namespace MvcPresentacion.Models
{
    public class Convertidor
    {
        public static AlumnoModelo aAlumnoModelo(Alumnos alumno)
        {
            AlumnoModelo alumnoModel = new AlumnoModelo()
            {
                id = alumno.id,
                nombre = alumno.nombre,
                primerApellido = alumno.primerApellido,
                segundoApellido= alumno.segundoApellido,
                correo = alumno.correo,
                telefono = alumno.telefono,
                fechaNacimiento = alumno.fechaNacimiento,
                curp = alumno.curp,
                idEstadoOrigen = alumno.idEstadoOrigen,
                idEstatus = alumno.idEstatus

            };
            return alumnoModel;
        }

        public static Alumnos aAlumno(AlumnoModelo alumnoModel)
        {
            Alumnos alumno = new Alumnos()
            {
                id = alumnoModel.id,
                nombre = alumnoModel.nombre,
                primerApellido = alumnoModel.primerApellido,
                segundoApellido = alumnoModel.segundoApellido,
                correo = alumnoModel.correo,
                telefono = alumnoModel.telefono,
                fechaNacimiento = alumnoModel.fechaNacimiento,
                curp = alumnoModel.curp,
                idEstadoOrigen = alumnoModel.idEstadoOrigen,
                idEstatus = alumnoModel.idEstatus
            };
            return alumno;
        }
    }
}