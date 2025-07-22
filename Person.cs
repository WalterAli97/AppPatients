using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatients
{
    internal class Person
    {
        /// <summary>
        /// Propiedad nombre, representa el nombre de la persona
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Propiedad Id de Documento, representa el tipo de documento (dni, cex, pasaporte, etc)
        /// </summary>
        public int DocumentTypeId { get; set; }
        /// <summary>
        /// Propiedad numero de documento, representa el numero de documento que tiene la persona
        /// </summary>
        public string NumberDocument {  get; set; }
        public string Gender { get; set; }
        public string Email {  get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }

        public Person(string name, int documentTypeId, string numberDocument, string gender, string email, string phoneNumbe, DateTime dateOfBirth, string address)
        {
            Name = name;
            DocumentTypeId = documentTypeId;
            NumberDocument = numberDocument;
            Gender = gender;
            Email = email;
            PhoneNumber = phoneNumbe;
            DateOfBirth = dateOfBirth;
            Address = address;
        }


        
    }
}
