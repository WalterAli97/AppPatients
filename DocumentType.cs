using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatients
{
    internal class DocumentType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DocumentType(int id, string name, string description) { 
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
