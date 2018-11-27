using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Proyecto4.Models
{
	public class LibroVisitas
	{
        SqlConnection cnnConexion = null;
        SqlCommand cmdComando = null;

        string strCadenaConexion = "";

        public LibroVisitas()
        {
            strCadenaConexion = @"Data Source=SMLAB304PC02_18;Initial Catalog=mvc_web_comentariodb;Integrated Security=False;User ID=sa;Password=Uisrael2018;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }


        public void EjecutarSP(SqlParameter[] parParameter, string nombreSP)
        {
            try
            {
                cnnConexion = new SqlConnection(strCadenaConexion);

                cmdComando = new SqlCommand();

                cmdComando.Connection = cnnConexion;
                cnnConexion.Open();

                cmdComando.CommandType = System.Data.CommandType.StoredProcedure;

                cmdComando.CommandText = nombreSP;

                cmdComando.Parameters.AddRange(parParameter);

                cmdComando.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
            }
        }

		#region Methods

		public void Grabar(string nombre, string comentarios)
		{
			StreamWriter archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
			archivo.WriteLine("Nombre:" + nombre + "<br>Comentarios:" + comentarios + "<hr>");
			archivo.Close();
		}

		public string Leer()
		{
			StreamReader archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt");
			string todo = archivo.ReadToEnd();
			archivo.Close();
			return todo;
		}
		#endregion



	}
}
