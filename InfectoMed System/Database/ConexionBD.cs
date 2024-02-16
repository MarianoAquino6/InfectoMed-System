using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectoMed_System.Database
{
    internal class ConexionBD
    {
        protected static SqlConnection connection;
        protected static SqlCommand command;
        protected static SqlDataReader reader;

        /// <summary>
        /// Constructor estático de la clase que inicializa la conexión y el comando SQL.
        /// </summary>
        static ConexionBD()
        {
            connection = new SqlConnection(@"Server = .; Database = TestMEDICO; 
            Trusted_Connection = True; Encrypt = False; TrustServerCertificate = True");

            command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
        }
    }
}
