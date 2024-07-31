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
    public partial class Checkout : Form
    {
        public static Checkout instance;
        public Label lb1;
        public Checkout()
        {
            InitializeComponent();
            instance = this;
            lb1 = label1;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            string username = "";

            StreamReader reader = new StreamReader(@"..\..\..\Store\userss.txt");
            using(reader)
            {
                username = reader.ReadLine();
            }
            bool isDairyItemsNotEmpty = new FileInfo(@"..\..\..\Store\DairyyItems.txt").Length != 0;
            bool isVegetablesItemsNotEmpty = new FileInfo(@"..\..\..\Store\VegetablesItems.txt").Length != 0;
            bool isFruitsItemsNotEmpty = new FileInfo(@"..\..\..\Store\FruitsItems.txt").Length != 0;
            bool isSweetsItemsNotEmpty = new FileInfo(@"..\..\..\Store\SweetsItems.txt").Length != 0;
            bool isSnacksItemsNotEmpty = new FileInfo(@"..\..\..\Store\SnacksItems.txt").Length != 0;

           
            label1.Text = Catalog.instance.lb1.Text;

            decimal totalExpenses = decimal.Parse(label1.Text);

            listBox1.Items.Add($"User: {username}, Total expenses: {totalExpenses:f2} лв");
            listBox1.Items.Add("Expenses breakdown:");
            if (isDairyItemsNotEmpty)
            {
                StreamReader readInfo = new StreamReader(@"..\..\..\Store\DairyyItems.txt");
                using (readInfo)
                {
                    listBox1.Items.Add(readInfo.ReadLine());
                    listBox1.Items.Add(readInfo.ReadLine());
                }
            }
            if (isVegetablesItemsNotEmpty)
            {
                StreamReader readInfo = new StreamReader(@"..\..\..\Store\VegetablesItems.txt");
                using (readInfo)
                {
                    listBox1.Items.Add(readInfo.ReadLine());
                    listBox1.Items.Add(readInfo.ReadLine());
                }
            }
            if (isFruitsItemsNotEmpty)
            {
                StreamReader readInfo = new StreamReader(@"..\..\..\Store\FruitsItems.txt");
                using (readInfo)
                {
                    listBox1.Items.Add(readInfo.ReadLine());
                    listBox1.Items.Add(readInfo.ReadLine());
                }
            }
            if (isSweetsItemsNotEmpty)
            {
                StreamReader readInfo = new StreamReader(@"..\..\..\Store\SweetsItems.txt");
                using (readInfo)
                {
                    listBox1.Items.Add(readInfo.ReadLine());
                    listBox1.Items.Add(readInfo.ReadLine());
                }
            }
            if (isSnacksItemsNotEmpty)
            {
                StreamReader readInfo = new StreamReader(@"..\..\..\Store\SnacksItems.txt");
                using (readInfo)
                {
                    listBox1.Items.Add(readInfo.ReadLine());
                    listBox1.Items.Add(readInfo.ReadLine());
                }
            }

            label3.Text = $"{totalExpenses:f2} лв";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for using our store! See you soon!");
            File.WriteAllText(@"..\..\..\Store\userss.txt", string.Empty);
            File.WriteAllText(@"..\..\..\Store\Costs.txt", string.Empty);
            File.WriteAllText(@"..\..\..\Store\DairyyItems.txt", string.Empty);
            File.WriteAllText(@"..\..\..\Store\VegetablesItems.txt", string.Empty);
            File.WriteAllText(@"..\..\..\Store\FruitsItems.txt", string.Empty);
            File.WriteAllText(@"..\..\..\Store\SweetsItems.txt", string.Empty);
            File.WriteAllText(@"..\..\..\Store\SnacksItems.txt", string.Empty);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not coming soon !");
        }
    }
}
