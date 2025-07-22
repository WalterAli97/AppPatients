using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPatients
{
    internal class User : Person
    {
        public string Password {  get; set; }
        public int RolId {  get; set; }
        public string Area { get; set; }
        public User(string password, int rolId, string area, string name, int documentTypeId, string numberDocument, string gender, string email, string phoneNumbe, DateTime dateOfBirth, string address) : base(name, documentTypeId, numberDocument, gender, email, phoneNumbe, dateOfBirth, address)
        {
            Password = password;
            RolId = rolId;
            Area = area;
        }
    }
}
