using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion
{
    /// <summary>
    /// Clase controladora de la base de datos, con el campo "SqlConnection"
    /// </summary>
    public class DBConnector: IDisposable
    {
        SqlConnection connection = new SqlConnection(@"   Data Source=(localdb)\MSSQLLocalDB;
                                                    Initial Catalog=Pizzas;
                                                    Integrated Security=True;
                                                    Connect Timeout=30;

                                                    Encrypt=False;
                                                    TrustServerCertificate=True;
                                                    ApplicationIntent=ReadWrite;
                                                    MultiSubnetFailover=False");

        /// <summary>
        /// Método Dispose()
        /// </summary>       
        public void Dispose()
        {
            connection.Close();
            connection.Dispose();
        }

        /// <summary>
        /// Método que devuelve la conexión
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
