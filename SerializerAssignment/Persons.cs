using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerializerAssignment.Models;

namespace SerializerAssignment
{
    public partial class Persons : Form
    {
        public Persons()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person(nameBox.Text, addressBox.Text, phoneBox.Text);
            newPerson.Serialize();
            ShowAppropriatePerson(Person.ShowLast);
        }

        private void Persons_Load(object sender, EventArgs e)
        {
            ShowAppropriatePerson(Person.ShowLast);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            ShowAppropriatePerson(Person.ShowPrev);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            ShowAppropriatePerson(Person.ShowNext);
        }

        private void goToFirstBtn_Click(object sender, EventArgs e)
        {
            ShowAppropriatePerson(Person.ShowFirst);
        }

        private void goToLastBtn_Click(object sender, EventArgs e)
        {
            ShowAppropriatePerson(Person.ShowLast);
        }

        private void ShowAppropriatePerson(Func<Person> actualMethod)
        {
            Person toShow;
            try
            {
                toShow = actualMethod();
            }
            catch (FileNotFoundException)
            {
                toShow = new Person();
            }
            nameBox.Text = toShow.Name;
            addressBox.Text = toShow.Address;
            phoneBox.Text = toShow.PhoneNum;
        }
    }
}
