using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_labb2_OOP
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private string gender;
        // public DateTime dateOfBirth { get; set; }
        private string email;
        private string adress;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public Person()
        {
            FirstName = "Anton";
            LastName = "Adamsson";
            Email = "Adamsson@hotline.com";
            Adress = "Testvägen 1";
        }

        public Person(string firstName, string lastName, string email, string adress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Adress = adress;
        }

        public override string ToString()
        {
            string output = String.Empty;

            output += String.Format("{0}, {1}, {2}, {3}, ", LastName, FirstName, Email, Adress);
            return output;
        }

    }
}
