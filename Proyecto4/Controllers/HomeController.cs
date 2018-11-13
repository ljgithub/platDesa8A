using Proyecto4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto4.Controllers
{
	public class HomeController : Controller
	{
		#region Methods

		// GET: Home
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult FormularioVisita()
		{
			return View();
		}

		public ActionResult CargaDatos()
		{
			string nombre = Request.Form["nombre"].ToString();
			string comentarios = Request.Form["comentarios"].ToString();
			LibroVisitas libro = new LibroVisitas();
			libro.Grabar(nombre, comentarios);
			return View();
		}

		public ActionResult ListadoVisitas()
		{
			LibroVisitas libro = new LibroVisitas();
			string todo = libro.Leer();
			ViewData["libro"] = todo;
			return View();
		}
		#endregion
	}
}