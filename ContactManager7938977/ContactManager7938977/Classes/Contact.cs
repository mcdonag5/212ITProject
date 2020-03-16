using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager7938977.Classes
{
    class Contact
    {
        protected int id { get; set; }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected string TelephoneNumber { get; set; }
        protected string Email { get; set; }
        protected string AddressLine1 { get; set; }
        protected string AddressLine2 { get; set; }
        protected string AddressCity { get; set; }
        protected string AddressPostCode { get; set; }
    }

    class PersonalContact : Contact
    {
        private string HomeTelephone { get; set; }
    }

    class BusinessContact : Contact
    {
        private string BussinessTelephone { get; set; }
    }
}
