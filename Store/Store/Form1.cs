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
using static System.Windows.Forms.AxHost;

namespace Store
{
    public partial class Form1 : Form
    {
        HashSet<UserData> usersData = new HashSet<UserData>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string message = "Do you want to register and begin shooping ?";
           if (MessageBox.Show(message, "Welcome to our store", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
           {

           }
           else
            {
                MessageBox.Show("Registration is required to be a customer in this shop!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (usersData.Any(x => x.Username == username))
            {
                MessageBox.Show("This username is already used");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            UserData createUser = new UserData(username, password);
            usersData.Add(createUser);
            StreamWriter writer = new StreamWriter(@"..\..\..\Store\userss.txt");
            using(writer)
            {
                writer.WriteLine(username);
                writer.WriteLine(password);
            }
            Catalog loadCatalog = new Catalog();
            loadCatalog.Show();
            this.Close();
        }
    }
}
