using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace ASP_CMS.Models
{
    public class ConnectionClass
    {
        public static System.Data.DataSet PortarDades(string query)
        {
            var dts = new System.Data.DataSet();
            var dataConnectionString = ConfigurationManager.ConnectionStrings["SDS_SQLConnectionString"].ConnectionString;
            var dataConnection = new System.Data.OleDb.OleDbConnection(dataConnectionString);

            dataConnection.Open();

            var dataAdapter = new System.Data.OleDb.OleDbDataAdapter(query, dataConnection);

            dataAdapter.Fill(dts, "dades");
            dataConnection.Close();




            return dts;
        }

        public static System.Data.DataTable updateDT(string queryString, System.Data.DataSet dts)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SDS_SQLConnectionString"].ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.SelectCommand = new OleDbCommand(queryString, connection);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);

                connection.Open();

                System.Data.DataTable ventas = dts.Tables[0];
                adapter.Fill(ventas);

                // code to modify data in DataTable here

                adapter.Update(ventas);

                return ventas;
            }
        }


    }
}