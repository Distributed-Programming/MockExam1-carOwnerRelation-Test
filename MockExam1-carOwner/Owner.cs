using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockExam1_carOwner
{
    /// <summary>
    /// Car owner class 
    /// </summary>
    public class Owner
    {
        private String _address;
        private String _name;
        private String _phone;
        
        /// <summary>
        /// Create a car owner with empty phonenumber
        /// </summary>
        /// <param name="address">Owners address, must be more than 6 characters</param>
        /// <param name="name">Owners name, must be longer than 4 characters</param>
        public Owner(string address, string name) 
        {
            Address = address;
            Name = name;
        }

        /// <summary>
        /// Create a car owner
        /// </summary>
        /// <param name="address">Owners address, must be more than 6 characters</param>
        /// <param name="name">Owners name, must be longer than 4 characters</param>
        /// <param name="phone">Owners phone number, must be exactly 8 characters</param>
        public Owner(string address, string name, string phone) : this(address, name)
        {
            Phone = phone;
        }
        public string Address
        {
            get { return _address; }
            set
            {
                if (value.Length >6) _address = value;
                else throw new ArgumentException("Address too short");
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >4 ) _name = value;
                else throw new ArgumentException("name too short");
            }
        }

        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value.Length == 8) _phone = value;
                else throw new ArgumentException("Phone number must be exact 8 digits");
            }
        }
    }
}
