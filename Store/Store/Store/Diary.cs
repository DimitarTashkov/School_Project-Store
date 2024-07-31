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
    public partial class Diary : Form 
    {
        
        private const decimal VereqPrice = 2.50m;
        private const decimal MlekoPrice = 3m;
        private const decimal SaqnaPrice = 14m;
        private const decimal MadjarovPrice = 30m;
        private const decimal yogurth1 = 3.13m;
        private const decimal yogurth2 = 6.82m;

        Dictionary<string, decimal> diary = new Dictionary<string, decimal>();

        public static Diary instance;
        public Label lb1;

        private string firstDiaryName;
        private string secondDiaryName;
        private decimal firstDiaryPrice;
        private decimal secondDiaryPrice;

        private decimal amount;
        private decimal totalPrice;

        public Diary()
        {
            InitializeComponent();
            instance = this;
            lb1 = label5;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price = 0;
            

            if (radioButton1.Checked)
            {
                amount = 0.25m;
                price += firstDiaryPrice * amount;
            }
            else if (radioButton2.Checked)
            {
                amount = 0.5m;
                price += firstDiaryPrice * amount;
            }
            else if (radioButton3.Checked)
            {
                amount = 1m;
                price += firstDiaryPrice;
            }
            else if (radioButton4.Checked)
            {
                 amount = decimal.Parse(textBox1.Text);
                price += firstDiaryPrice * amount;
                textBox1.Text = "";
            }

            if (!diary.ContainsKey(firstDiaryName))
            {
                diary.Add(firstDiaryName, amount);
            }
            diary[firstDiaryName] += amount;

            totalPrice += price;
            label5.Text = $"{totalPrice:f2} лв";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal price = 0;

            if (radioButton1.Checked)
            {
                amount = 0.25m;
                price += secondDiaryPrice * amount;
            }
            else if (radioButton2.Checked)
            {
                amount = 0.5m;
                price += secondDiaryPrice * amount;
            }
            else if (radioButton3.Checked)
            {
                amount = 1m;
                price += secondDiaryPrice;
            }
            else if (radioButton4.Checked)
            {
                decimal amount = decimal.Parse(textBox1.Text);
                price += secondDiaryPrice * amount;
                textBox1.Text = "";
            }

            if(!diary.ContainsKey(secondDiaryName))
            {
                diary.Add(secondDiaryName, amount);
            }
            else
            {
                diary[secondDiaryName] += amount;
            }

            totalPrice += price;
            label5.Text = $"{totalPrice:f2} лв";


        }


        private void Diary_Load(object sender, EventArgs e)
        {

        }

        private void cheeseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "14лв kg/l";
            label3.Text = "30лв kg/l";

            firstDiaryName = "SaqnaCheese";
            secondDiaryName = "MadjarovCheese";
            firstDiaryPrice = SaqnaPrice;
            secondDiaryPrice = MadjarovPrice;

            pictureBox1.Load(@"..\..\..\Store\Resources\sirene1.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\sirene2.jpg");
        }

        private void milkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.Text = "2.50лв kg/l";
            label3.Text = "3лв kg/l";

            firstDiaryName = "VereqMilk";
            secondDiaryName = "MlekoMilk";
            firstDiaryPrice = VereqPrice;
            secondDiaryPrice = MlekoPrice;

            pictureBox1.Load(@"..\..\..\Store\Resources\milk1.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\milk3.jpg");
        }

        private void yogurthsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "3.13лв kg/l";
            label3.Text = "6.82лв kg/l";

            firstDiaryName = "yogurth1";
            secondDiaryName = "yogurth2";
            firstDiaryPrice = yogurth1;
            secondDiaryPrice = yogurth2;

            pictureBox1.Load(@"..\..\..\Store\Resources\yogurth1.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\yogurth2.jpg");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StreamWriter updateCosts = new StreamWriter(@"..\..\..\Store\Costs.txt");
            StreamWriter updateItems = new StreamWriter(@"..\..\..\Store\DairyyItems.txt");
            using (updateCosts)
            {
                updateCosts.WriteLine(totalPrice);
            }
            using (updateItems)
            {
                updateItems.WriteLine($"Dairy expenses: {totalPrice:f2}");
                foreach (var kvp in diary)
                {
                    updateItems.Write($"{kvp.Key} - {kvp.Value}kg/l, ");
                }
            }
            this.Close();
        }
    }
}
