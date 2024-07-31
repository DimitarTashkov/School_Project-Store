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
    public partial class Fruits : Form
    {
        private const decimal ApplePrice = 6.42m;
        private const decimal PearPrice = 4.99m;
        private const decimal OrangePrice = 5.99m;
        private const decimal PeachPrice = 4.99m;
        private const decimal CherryPrice = 11.98m;
        private const decimal AvocadoPrice = 10.50m;
        private const decimal WatermelonPrice = 2.22m;

        Dictionary<string, decimal> fruits = new Dictionary<string, decimal>();


        private bool isOrganic;

        private decimal fruitsCost;
        private string fruitName;
        private decimal amount;
        private decimal totalPrice;
        public Fruits()
        {
            InitializeComponent();
        }

        private void Fruits_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your preferable fruits type is organic or not ?", "Welcome to our vegetables area!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isOrganic = true;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)

            {
                case 0:
                    pictureBox1.Load(@"..\..\..\Store\Resources\apple.jpg");
                    fruitName = "Apples";
                    fruitsCost = ApplePrice;
                    break;
                case 1:
                    pictureBox1.Load(@"..\..\..\Store\Resources\pears.jpg");
                    fruitName = "Pears";
                    fruitsCost = PearPrice;
                    break;
                case 2:
                    pictureBox1.Load(@"..\..\..\Store\Resources\orange.jpg");
                    fruitName = "Oranges";
                    fruitsCost = OrangePrice;
                    break;
                case 3:
                    pictureBox1.Load(@"..\..\..\Store\Resources\peach.jpg");
                    fruitName = "Peaches";
                    fruitsCost = PeachPrice;
                    break;
                case 4:
                    pictureBox1.Load(@"..\..\..\Store\Resources\cherry.jpg");
                    fruitName = "Cherries";
                    fruitsCost = CherryPrice;
                    break;
                case 5:
                    pictureBox1.Load(@"..\..\..\Store\Resources\avocado.jpg");
                    fruitName = "Avocados";
                    fruitsCost = AvocadoPrice;
                    break;
                case 6:
                    pictureBox1.Load(@"..\..\..\Store\Resources\watermelon.jpg");
                    fruitName = "Watermelons";
                    fruitsCost = WatermelonPrice;
                    break;

            }
            if(isOrganic)
            {
                fruitsCost += 2;
            }       
                label2.Text = $"{fruitsCost}лв kg";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal price = 0;


            if (radioButton1.Checked)
            {
                amount = 0.25m;
                price += fruitsCost * amount;
            }
            else if (radioButton2.Checked)
            {
                amount = 0.5m;
                price += fruitsCost * amount;
            }
            else if (radioButton3.Checked)
            {
                amount = 1m;
                price += fruitsCost;
            }
            else if (radioButton4.Checked)
            {
                amount = decimal.Parse(textBox1.Text);
                price += fruitsCost * amount;
                textBox1.Text = "";
            }

            if (!fruits.ContainsKey(fruitName))
            {
                fruits.Add(fruitName, amount);
            }
            else
            {
                fruits[fruitName] += amount;
            }
            label2.Text = $"{fruitsCost}лв kg";

            totalPrice += price;
            label5.Text = $"{totalPrice:f2} лв";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter updateCosts = new StreamWriter(@"..\..\..\Store\Costs.txt");
            StreamWriter updateItems = new StreamWriter(@"..\..\..\Store\FruitsItems.txt");
            using (updateCosts)
            {
                updateCosts.WriteLine(totalPrice);
            }
            using (updateItems)
            {
                updateItems.WriteLine($"Fruits expenses: {totalPrice:f2}");
                foreach (var kvp in fruits)
                {
                    updateItems.Write($"{kvp.Key} - {kvp.Value}kg, ");
                }
            }
            this.Close();
            bool file1IsEmpty = new FileInfo(@"..\..\..\Store\Costs.txt").Length == 0;

        }
    }
}
