using Proyecto4.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto4.Controllers
{
	public class HomeController : Controller
	{
        LibroVisitas libro = null;
        SqlParameter[] parParameter = null;



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
            /*string nombre = Request.Form["nombre"].ToString();
			string comentarios = Request.Form["comentarios"].ToString();
			LibroVisitas libro = new LibroVisitas();
			libro.Grabar(nombre, comentarios);
			return View();*/

            string nombre = Request["nombre"].ToString();
            string comentario = Request["comentarios"].ToString();

            int opc = 2;

            try
            {
                libro = new LibroVisitas();
                parParameter = new SqlParameter[3];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opc";
                parParameter[0].SqlDbType = System.Data.SqlDbType.Int;
                parParameter[0].SqlValue = opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombre";
                parParameter[1].SqlDbType = System.Data.SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = nombre;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@comentario";
                parParameter[2].SqlDbType = System.Data.SqlDbType.VarChar;
                parParameter[2].Size = 500;
                parParameter[2].SqlValue = comentario;


            }
            catch (Exception)
            {

                throw;
            }

            libro.EjecutarSP(parParameter, "sp_comentario");
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