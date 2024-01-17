using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto3
{
    public class Conexion
    {
        public SqlConnection Conectar()
        {
            string cadena = "server=DESKTOP-0QPETCP ; database=nueva ; integrated security = true";

            SqlConnection cone = new SqlConnection(cadena);
            try
            {
                cone.Open();


                return cone;
            }
            catch (Exception ex)
            {
                return cone;
            }

        }

        public void Cerrar(SqlConnection cone)
        {
            cone.Close();
        }

        public bool EjecutarComando(string cade)
        {
            SqlConnection con = this.Conectar();

            SqlCommand comando = new SqlCommand(cade, con);

            if (comando.ExecuteNonQuery() > 0)
            {
                this.Cerrar(con);
                return true;
            }
            else
            {
                this.Cerrar(con);
                return false;
            }


        }

        public DataSet LlenarDatos(string cade)
        {
            SqlConnection cone = this.Conectar();
            //TRY
            SqlDataAdapter ada = new SqlDataAdapter(cade, cone);
            DataSet data = new DataSet();
            ada.Fill(data);
            this.Cerrar(cone);
            return data;
        }

    }
}
