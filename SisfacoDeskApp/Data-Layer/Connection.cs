using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SisfacoDeskApp.Data_Layer
{
    class Connection
    {
        public static String Cadena = "Data Source=localhost;Initial Catalog=SisfacoDatabase;Integrated Security=True";
        SqlConnection con = new SqlConnection(Cadena);
        public SqlCommand comando;
        private SqlCommandBuilder cmb;
        public DataSet ds = new DataSet();
        public SqlDataAdapter da = new SqlDataAdapter();

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Con = new SqlConnection("Data Source=localhost;Initial Catalog=SisfacoDatabase;Integrated Security=True");
            Con.Open();
            return Con;
        }
        public static SqlConnection CerrarConexion()
        {
            SqlConnection Con = new SqlConnection("Data Source=localhost;Initial Catalog=SisfacoDatabase;Integrated Security=True");
            Con.Close();
            return Con;
        }

        public void Conectar()
        {
            try
            {
                con.Open();
                Presentation_Layer.Alerts.AlertMessage.Show("Conexion Activa", Presentation_Layer.Alerts.AlertMessage.AlertType.success);
            }
            catch (SqlException e)
            {
                Presentation_Layer.Alerts.AlertMessage.Show("Error al Conectar", Presentation_Layer.Alerts.AlertMessage.AlertType.error);
            }
            finally
            {
                con.Close();
            }
        }

        public void Consulta(String sql, String Tabla)
        {
            ds.Tables.Clear();
            da = new SqlDataAdapter(sql, con);
            cmb = new SqlCommandBuilder(da);
            da.Fill(ds, Tabla);


        }
        public bool Insertar(String sql)
        {
            con.Open();
            comando = new SqlCommand(sql, con);
            int i = comando.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
