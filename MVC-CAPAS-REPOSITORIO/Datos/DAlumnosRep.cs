using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos
{
    public class DAlumnosRep : Repositorio<Alumnos>
    {
        public List<Alumnos> ConsultarD() => Consultar();
        

        public Alumnos ConsultarUno(int id) => Consultar(x => x.id == id);


        public void Crear(Alumnos alumno) => crear(alumno);

        
        public void Editar(Alumnos alumno) => Actualizar(alumno);

        public void Eliminar(int id) => Eliminar(x => x.id == id);

       // public void Eliminar(Alumnos alumno) => Eliminar(alumno);

    }
}
