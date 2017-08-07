using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion
{
    
    /// <summary>
    /// Repositorio de Pizza, el cual hereda de "RepositoryGeneral<T>"
    /// </summary>
    class RepositoryPizza:RepositoryGeneric<Pizza>
    {
        /// <summary>
        /// Método Override que recibe la entidad y la inserta en la base de datos
        /// </summary>
        /// <param name="entity"></param>
        /// 
        /// 
        public void update(Pizza entity){
            if(entity == null) {throw new Exception("No puedes insertar un null");}
            DBConnector dbconn = new DBConnector();
            using (dbconn)
            {
                var connection = dbconn.GetConnection();
           
                connection.Open();
                String sql = "INSERT UPDATE Pizza set Id=@param1,name=@param2";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@param1", entity.Id);
                command.Parameters.AddWithValue("@param2", entity.Name);
                command.ExecuteNonQuery();

                Console.WriteLine("Pizza registrada correct" +"amente");
                Console.ReadLine();
            }
        }
        public void delete(int id){
            if(id == null) {throw new Exception("No puedes insertar un null");}
            
            DBConnector dbconn = new DBConnector();
            using (dbconn)
            {
                var connection = dbconn.GetConnection();
           
                connection.Open();
                String sql = "delete from Pizzaswhere id= @param1";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@param1", id);
                command.ExecuteNonQuery();

                Console.WriteLine("Pizza eliminada correctamente");
                Console.ReadLine();
            }
        }
        public override void Add(Pizza entity)
        {
            if(entity == null) {throw new Exception("No puedes insertar un null");}
            base.Add(entity);
            DBConnector dbconn = new DBConnector();
            using (dbconn)
            {
                var connection = dbconn.GetConnection();
           
                connection.Open();
                String sql = "INSERT INTO Pizzas (Id,NombrePizza) VALUES (@param1 , @param2)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@param1", entity.Id);
                command.Parameters.AddWithValue("@param2", entity.Name);
                command.ExecuteNonQuery();

                 Console.WriteLine("Pizza registrada correctamente");
                 Console.ReadLine();
            }
        }

        /// <summary>
        /// Método que devuelve una lista de pizzas de la base de datos
        /// </summary>
        public override void Select()
        {
            base.Select();

            DBConnector dbconn = new DBConnector();          
            using (dbconn)
            {
                var connection = dbconn.GetConnection();
                //Introduccion de la entidad
                connection.Open();
                String sql = "SELECT * FROM Pizzas";
                SqlCommand command = new SqlCommand(sql, connection);
                var pizzas = command.ExecuteReader();
                while (pizzas.Read())
                {
                    Console.WriteLine("Pizza " + pizzas.GetGuid(0) + " - " + pizzas.GetString(1));
                }

                Console.ReadLine();
            }
        }
    }
}
