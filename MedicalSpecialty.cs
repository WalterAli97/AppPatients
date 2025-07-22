using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatients
{
    /// <summary>
    /// Clase de especialidad medica
    /// </summary>
    internal class MedicalSpecialty
    {
        public int Id { get; set; }

        /// <summary>
        /// Propiedad Type, representa el tipo de especialidad 
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Propiedad Codigo, representa codigo del tipo de especialidad
        /// </summary>
        public string Codigo { get; set; }
        public string Name { get; set; }

        public MedicalSpecialty(int id, string type, string codigo, string name) { 
            Id = id;
            Type = type;
            Codigo = codigo;
            Name = name;
        }
    }
}
