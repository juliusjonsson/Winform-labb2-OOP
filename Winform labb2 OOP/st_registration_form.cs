using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_labb2_OOP
{
    public partial class st_registration_form : Form
    {
        private Person[] register = new Person[1];

        public st_registration_form()
        {
            InitializeComponent();
        }

        private void Write(Person obj)
        {
            StreamWriter sw = new StreamWriter("Persons.txt");
            sw.WriteLine(register.Length + 1);
            sw.WriteLine(obj.FirstName);
            sw.WriteLine(obj.LastName);
            sw.WriteLine(obj.Email);
            sw.WriteLine(obj.Adress);

            for (int x = 0; x < register.Length; x++)
            {
                sw.WriteLine(register[x].FirstName);
                sw.WriteLine(register[x].LastName);
                sw.WriteLine(register[x].Email);
                sw.WriteLine(register[x].Adress);
            }
            sw.Close();
        }

        private void Read()
        {
            StreamReader sr = new StreamReader("Persons.txt");
            register = new Person[Convert.ToInt32(sr.ReadLine())];

            for (int x = 0; x < register.Length; x++)
            {
                register[x] = new Person();
                register[x].FirstName = sr.ReadLine();
                register[x].LastName = sr.ReadLine();
                register[x].Email = sr.ReadLine();
                register[x].Adress = sr.ReadLine();
            }
            sr.Close();
        }

        private void Display()
        {
            lstPerson.Items.Clear();

            for(int x = 0; x < register.Length; x++)
            {
                lstPerson.Items.Add(register[x].ToString());
            }
        }

        private void ClearForm()
        {
            st_fNamn.Text = String.Empty;
            st_eNamn.Text = String.Empty;
            st_email.Text = String.Empty;
            st_adress.Text = String.Empty;
        }

        private void st_registration_form_Load(object sender, EventArgs e)
        {
            Read();
            Display();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void startpage_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void st_fNamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void st_eNamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Person obj = new Person();
            obj.FirstName = st_fNamn.Text;
            obj.LastName = st_eNamn.Text;
            obj.Email = st_email.Text;
            obj.Adress = st_adress.Text;

            Write(obj);
            Read();
            Display();
            ClearForm();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
