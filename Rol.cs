using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatients
{
    /// <summary>
    /// Clase Rol, rol que se le asignará a los usuarios (Doctor y User)
    /// </summary>
    internal class Rol
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Permission> Permissions { get; set; }

        public Rol(int id, string name, string description, List<Permission> permissions)
        {
            Id = id;
            Name = name;
            Description = description;
            Permissions = permissions;
        }
    }
}
