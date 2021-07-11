using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.ServiceWCFAlumno;
using Entidades;

namespace Datos
{
    class Convertidor
    {
        public static Alumnos convertidorAlumno( DCAlumno alumnoWCF)
        {
            Alumnos alumnoModel = new Alumnos()
            {
                id = alumnoWCF.id,
                nombre = alumnoWCF.nombre,
                primerApellido = alumnoWCF.primerApellido,
                segundoApellido = alumnoWCF.segundoApellido,
                correo = alumnoWCF.correo,
                telefono = alumnoWCF.telefono,
                fechaNacimiento = alumnoWCF.fechaNacimiento,
                curp = alumnoWCF.curp,
                idEstadoOrigen = alumnoWCF.idEstadoOrigen,
                idEstatus = (short)alumnoWCF.idEstatus
                

            };
            return alumnoModel;
        }

        public static DCAlumno convertidorAlumnoWCF(Alumnos alumno)
        {
            DCAlumno alumnowcf = new DCAlumno()
            {
                id = alumno.id,
                nombre = alumno.nombre,
                primerApellido = alumno.primerApellido,
                segundoApellido = alumno.segundoApellido,
                correo = alumno.correo,
                telefono = alumno.telefono,
                fechaNacimiento = alumno.fechaNacimiento,
                curp = alumno.curp,
                idEstadoOrigen = alumno.idEstadoOrigen,
                idEstatus = (short)alumno.idEstatus


            };
            return alumnowcf;
        }
    }
}
