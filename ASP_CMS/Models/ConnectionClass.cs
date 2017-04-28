﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ASP_CMS.Models
{
    public class ConnectionClass
    {
        public static string dataset(string query)
        {
            var dataset = new System.Data.DataSet();
            var dataConnectionString = ConfigurationManager.ConnectionStrings["SDS_SQLConnectionString"].ConnectionString;
            var dataConnection = new System.Data.OleDb.OleDbConnection(dataConnectionString);

            dataConnection.Open();

            var dataAdapter = new System.Data.OleDb.OleDbDataAdapter(query, dataConnection);

            dataAdapter.Fill(dataset, "table");

            var result = dataset.Tables;
            var textResult = dataset.GetXml().ToString();

            return textResult;
        }
    }
}