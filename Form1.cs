using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LINQ
{
    public partial class Form1 : Form
    {
        List<Person> peoples = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            Fill();
        }
        public void Fill()
        {
            string[] persons = File.ReadAllLines("list.txt");
            foreach (string person in persons)
            {
                string[] info = person.Split(' ');
                Person pers = new Person(info[0], info[1], info[2], Convert.ToInt32(info[3]), Convert.ToInt32(info[4]));
                peoples.Add(pers);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ages = from t in peoples
                       where t.Age > 40
                       select t;
            foreach (Person t in ages)
            {
                listBox1.Items.Add(t.Info());
            }
        }
    }
}
