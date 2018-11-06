using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JaviProy.Models;

namespace JaviProy.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult FormularioVisita()
		{
			return View();
		}
	
		public ActionResult CargarDatos()
		{
			string nombre = Request.Form["nombre"].ToString();
			string comentarios= Request.Form["comentarios"].ToString();


			LibroVisitas l = new LibroVisitas();
			l.grabar(nombre, comentarios);
			return View();
		}				
    }
}