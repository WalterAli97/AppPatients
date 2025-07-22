using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatients
{
    internal class Doctor : Person
    {
        /// <summary>
        /// Propiedad CMP, representa el codigo del colegio medico
        /// </summary>
        public string Cmp {  get; set; }

        /// <summary>
        /// Propiedad Specialties, representa la lista de especialidades del Medico
        /// </summary>
        public List<MedicalSpecialty> Specialties { get; set; }
        public Doctor(string cmp, List<MedicalSpecialty> medicalSpecialties,string name, int documentTypeId, string numberDocument, string gender, string email, string phoneNumbe, DateTime dateOfBirth, string address) : base(name, documentTypeId, numberDocument, gender, email, phoneNumbe, dateOfBirth, address)
        {
            this.Cmp = cmp;
            Specialties = medicalSpecialties;
        }
    }
}
