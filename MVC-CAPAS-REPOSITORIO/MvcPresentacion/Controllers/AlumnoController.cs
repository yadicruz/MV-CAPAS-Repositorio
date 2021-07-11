using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;
using System.Data.Entity;
using MvcPresentacion.Models;

namespace MvcPresentacion.Controllers
{
    
    public class AlumnoController : Controller
    {
       

        NAlumno objNegocioAlumno = new NAlumno();
        // GET: Alumno
        public ActionResult Index()
        {
            List<Alumnos> listaAlumnos = new List<Alumnos>();
            
            listaAlumnos = objNegocioAlumno.Consultar();

            return View(listaAlumnos);
        }

        public ActionResult Details(int id)
        {
            Alumnos alumno = new Alumnos();
            alumno = objNegocioAlumno.ConsultarDetalles(id);
            return View(alumno);
        }

      
        public ActionResult Create()
        {
            ViewBag.idEstadoOrigen = new SelectList(objNegocioAlumno.ConsultarEstados(), "id", "nombre");
            ViewBag.idEstatus = new SelectList(objNegocioAlumno.ConsultarEAlumno(), "id", "nombre");

            return View();
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(AlumnoModelo alumnoModel)
        {      
          
            if (ModelState.IsValid)
            {
                objNegocioAlumno.Crear(Convertidor.aAlumno(alumnoModel));
                return RedirectToAction("Index");
            }

            ViewBag.idEstadoOrigen = new SelectList(objNegocioAlumno.ConsultarEstados(), "id", "nombre");
            ViewBag.idEstatus = new SelectList(objNegocioAlumno.ConsultarEAlumno(), "id", "nombre");
            return View(alumnoModel);
            
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Alumnos alumno = new Alumnos();
            alumno = objNegocioAlumno.ConsultarDetalles(id);
          
            if (alumno == null)
            {
                return HttpNotFound();
            }
            ViewBag.idEstadoOrigen = new SelectList(objNegocioAlumno.ConsultarEstados(), "id", "nombre",alumno.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(objNegocioAlumno.ConsultarEAlumno(), "id", "nombre",alumno.idEstatus);
            return View(Convertidor.aAlumnoModelo( alumno));
        }
        [HttpPost]
        public ActionResult Edit(AlumnoModelo alumnoModel)
        {
            
            if (ModelState.IsValid)
            {
                objNegocioAlumno.Editar(Convertidor.aAlumno(alumnoModel));
                return RedirectToAction("Index");
            }
            ViewBag.idEstadoOrigen = new SelectList(objNegocioAlumno.ConsultarEstados(), "id", "nombre");
            ViewBag.idEstatus = new SelectList(objNegocioAlumno.ConsultarEAlumno(), "id", "nombre");
            return View(alumnoModel);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Alumnos alumno = objNegocioAlumno.ConsultarDetalles(id);

            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            objNegocioAlumno.Eliminar(id);
            return RedirectToAction("Index");
        }


        public ActionResult _DetalleParcial(int id)
        {
            Alumnos alumno = new Alumnos();
            alumno = objNegocioAlumno.ConsultarDetalles(id);
            return PartialView(alumno);
        }

       
    }
}