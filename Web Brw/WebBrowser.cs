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

        public event MyEventHandler PersonEvent;

        public EventHandler<PersonEventArgs> PersonEvent2;

        public event Action<object, PersonEventArgs> PersonEvent3;

        public Action<object, PersonEventArgs> PersonAction { get; set; }

        public WebBrowser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PersonEvent != null)
            {
                PersonEventArgs pea = new PersonEventArgs();
                Person p = new Person();
                pea.Person = p;
                p.FirstName = textBox1.Text;
                p.LastName = textBox2.Text;
                PersonEvent(this, pea);

            } 
        }

        internal void SetPerson(Person person)
        {
            textBox1.Text = person.FirstName;
            textBox2.Text = person.LastName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PersonEvent2 != null)
            {
                PersonEventArgs pea = new PersonEventArgs();
                Person p = new Person();
                pea.Person = p;
                p.FirstName = textBox1.Text;
                p.LastName = textBox2.Text;
                PersonEvent2(this, pea);

            } 
        }

    }
}
