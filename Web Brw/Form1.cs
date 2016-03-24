using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Brw
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
            webBrowser1.PersonEvent += webBrowser1_personEvent;
            webBrowser1.PersonEvent += webBrowser1_personEvent;
            webBrowser2.PersonEvent += webBrowser2_personEvent;

            webBrowser1.PersonEvent2 += webBrowser1_personEvent;
            webBrowser1.PersonEvent2 += webBrowser1_personEvent;
            webBrowser2.PersonEvent2 = webBrowser2_personEvent;
        }

        void webBrowser1_personEvent(object sender, PersonEventArgs e)
        {
            MessageBox.Show(e.Person.FirstName + " " + e.Person.LastName);
        }

        void webBrowser2_personEvent(object sender, PersonEventArgs e)
        {
            MessageBox.Show("Hello " + e.Person.FirstName + " " + e.Person.LastName);
        }

  
        private void Form1_Load(object sender, EventArgs e)
        {
            Person pers = new Person();
            pers.FirstName = "Andreea";
            pers.LastName = "Turcanu";
            webBrowser1.SetPerson(pers);
            webBrowser2.SetPerson(pers);

        }







    
    }
}
