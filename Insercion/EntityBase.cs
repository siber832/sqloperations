using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insercion
{
    /// <summary>
    /// Clase abstracta de EntityBase que tiene un Id de tipo "GUID"
    /// </summary>
    public abstract class EntityBase
    {
        //Identificador único global
        public Guid Id { get; set; }

        /// <summary>
        /// Método que devuelve un Guid() para la entidad 
        /// </summary>
        /// <returns></returns>
        public static Guid CreateIdentifier()
        {
            return Guid.NewGuid();            
        }
    }
}
