using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var repositoryPizzas = new RepositoryPizza();
                repositoryPizzas.Add(new Pizza() { Name = "Carbonara" });
                repositoryPizzas.Select();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
