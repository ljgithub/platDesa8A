using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
			return View();
		}
    }
}