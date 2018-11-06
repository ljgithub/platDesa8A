using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace JaviProy.Models
{
	public class LibroVisitas
	{
		public void grabar(string nombre, string comentarios)
		{
			StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~")+ "/App_Data/datos.txt", true);
			archivo.WriteLine("Nombre : " + nombre + " <br>Comentarios : " + comentarios + "<hr>");
			archivo.Close();
		}

	}
}