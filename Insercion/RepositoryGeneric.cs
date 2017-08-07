using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion
{
    class RepositoryGeneric<T> where T : EntityBase
    {
        public virtual void Add(T entity)
        {
            entity.Id = EntityBase.CreateIdentifier();

            Console.WriteLine("El id es " + entity.Id);
            Console.ReadLine();
        }

        public virtual void Select()
        {
            Console.WriteLine("Listado de pizzas mostradas");
        }
    }
}
