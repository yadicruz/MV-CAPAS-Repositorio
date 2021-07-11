using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
namespace Datos
{
    public class Listas
    {
        InstitutoTichEntities db = new InstitutoTichEntities();

        public List<Estados> ConsultarEstados()
        {
            var estados = db.Estados;
            return estados.ToList();
        }
        public List<EstatusAlumnos> ConsultarEstatus()
        {
            var estatus = db.EstatusAlumnos;
            return estatus.ToList();
        }
    }
}
