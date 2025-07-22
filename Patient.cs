using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatients
{
    internal class Patient : Person
    {
        /// <summary>
        /// Propiedad Historia Clinica, represeta el código de historia clinica para cada paciente
        /// </summary>
        public string CodMedicalRecord {  get; set; }
        public Patient(string codMedicalRecord,string name, int documentTypeId, string numberDocument, string gender, string email, string phoneNumbe, DateTime dateOfBirth, string address) : base(name, documentTypeId, numberDocument, gender, email, phoneNumbe, dateOfBirth, address)
        {
            CodMedicalRecord = codMedicalRecord;
        }
    }
}
