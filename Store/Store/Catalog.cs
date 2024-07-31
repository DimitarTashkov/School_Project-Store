using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Catalog : Form
    {
        public HashSet<UserData> usersData { get; set; }
        public static Catalog instance;
        public List<decimal> list;
        public Label lb1;
       
        public Catalog()
        {
            InitializeComponent();
            usersData = new HashSet<UserData>();
            instance = this;
            list = new List<decimal>();
            lb1 = label4;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Catalog_Load(object sender, EventArgs e)
        {
       
            StreamReader reader = new StreamReader(@"..\..\..\Store\userss.txt");
            string username = "";
            string password = "";
            using(reader)
            {
                 username = reader.ReadLine();
                 password = reader.ReadLine();

            }
            UserData user = new UserData(username, password);
            usersData.Add(user);

            label1.Text = $"Hello {username}";
           
        }

        private void diaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Diary loadDiary = new Diary();
            loadDiary.Show();
            label3.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"..\..\..\Store\userss.txt");
            string username = "";
            string password = "";
            decimal expenses = 0;
            using (reader)
            {
                username = reader.ReadLine();
                password = reader.ReadLine();

            }
            UserData user = usersData.FirstOrDefault(x => x.Username == username);
            StreamReader costsReader = new StreamReader(@"..\..\..\Store\Costs.txt");
            using (costsReader)
            {
                expenses = decimal.Parse(costsReader.ReadLine());

            }
            user.Expenses += expenses;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal totalExpenses = list.Sum();
            label4.Text = $"{totalExpenses}";

            Checkout loadCheckout = new Checkout();
            loadCheckout.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            decimal expense = 0;

            StreamReader readCurrentExpense = new StreamReader(@"..\..\..\Store\Costs.txt");
            using(readCurrentExpense)
            {
                expense += decimal.Parse(readCurrentExpense.ReadLine());
            }
            File.WriteAllText(@"..\..\..\Store\Costs.txt", string.Empty);
            label3.Text = $"{expense:f2} лв";
            list.Add(expense);

        }

        private void vegetablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vegetables loadVegetables = new Vegetables();
            loadVegetables.Show();
            label3.Text = "0";

        }

        private void fruitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fruits loadFruits = new Fruits();
            loadFruits.Show();
            label3.Text = "0";
        }

        private void sweetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sweets loadSweets = new Sweets();
            loadSweets.Show();
            label3.Text = "0";
        }

        private void snacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Snacks loadSnacks = new Snacks();
            loadSnacks.Show();
            label3.Text = "0";
        }
    }
}
