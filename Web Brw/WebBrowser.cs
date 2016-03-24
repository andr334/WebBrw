using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Brw
{
    public partial class WebBrowser : UserControl
    {

        public delegate void MyEventHandler(object sender, PersonEventArgs e);

        public event MyEventHandler personEvent;

        public WebBrowser()
        {
            InitializeComponent();
        }


        private void WebBrowser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (personEvent != null)
            {
                PersonEventArgs pea = new PersonEventArgs();
                Person p = new Person();
                pea.Person = p;
                p.FirstName = textBox1.Text;
                p.LastName = textBox2.Text;
                personEvent(this, pea);

            } 
        }

        internal void SetPerson(Person person)
        {
            textBox1.Text = person.FirstName;
            textBox2.Text = person.LastName;
        }
    }
}
