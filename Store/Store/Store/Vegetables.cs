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
    public partial class Vegetables : Form
    {

        private const decimal CucumbersPrice = 3.39m;
        private const decimal TomatoesPrice = 4.49m;
        private const decimal PotatoesPrice = 2.79m;
        private const decimal CarrotPrice = 3.70m;
        private const decimal LettucePrice = 3.55m;
        private const decimal BeansPrice = 8.39m;
        private const decimal PeppersPrice = 7.99m;

        Dictionary<string, decimal> vegetables = new Dictionary<string, decimal>();

        private decimal vegetableCost;
        private string vegetableName;
        private decimal amount;
        private decimal totalPrice;

        private int organicCount;
        private int chemistyCount;

        public Vegetables()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            organicCount = 0;
            chemistyCount = 0;
           switch(comboBox1.SelectedIndex)

            {
                case 0:
                    pictureBox1.Load(@"..\..\..\Store\Resources\cucumbers.jpg");
                    vegetableName = "Cucumbers";
                    vegetableCost = CucumbersPrice;                 
                    break;
                case 1:
                    pictureBox1.Load(@"..\..\..\Store\Resources\tomatoes1.jpg");
                    vegetableName = "Tomatoes";
                    vegetableCost = TomatoesPrice;
                    break;
                case 2:
                    pictureBox1.Load(@"..\..\..\Store\Resources\potatoes.jpg");
                    vegetableName = "Potatoes";
                    vegetableCost = PotatoesPrice;
                    break;
                case 3:
                    pictureBox1.Load(@"..\..\..\Store\Resources\carrots.jpg");
                    vegetableName = "Carrots";
                    vegetableCost = CarrotPrice;
                    break;
                case 4:
                    pictureBox1.Load(@"..\..\..\Store\Resources\lettuce.jpg");
                    vegetableName = "Lettuces";
                    vegetableCost = LettucePrice;
                    break;
                case 5:
                    pictureBox1.Load(@"..\..\..\Store\Resources\beans.jpg");
                    vegetableName = "Beans";
                    vegetableCost = BeansPrice;
                    break;
                case 6:
                    pictureBox1.Load(@"..\..\..\Store\Resources\peppers.jpg");
                    vegetableName = "Peppers";
                    vegetableCost = PeppersPrice;
                    break;

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter updateCosts = new StreamWriter(@"..\..\..\Store\Costs.txt");
            StreamWriter updateItems = new StreamWriter(@"..\..\..\Store\VegetablesItems.txt");
            using (updateCosts)
            {
                updateCosts.WriteLine(totalPrice);
            }
            using(updateItems)
            {
                updateItems.WriteLine($"Vegetables expenses: {totalPrice:f2}");
                foreach (var kvp in vegetables)
                {
                    updateItems.Write($"{kvp.Key} - {kvp.Value}kg, ");
                }
            }
            this.Close();
        }

        private void milkToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal price = 0;


            if (radioButton1.Checked)
            {
                amount = 0.25m;
                price += vegetableCost * amount;
            }
            else if (radioButton2.Checked)
            {
                amount = 0.5m;
                price += vegetableCost * amount;
            }
            else if (radioButton3.Checked)
            {
                amount = 1m;
                price += vegetableCost;
            }
            else if (radioButton4.Checked)
            {
                amount = decimal.Parse(textBox1.Text);
                price += vegetableCost * amount;
                textBox1.Text = "";
            }

            if (!vegetables.ContainsKey(vegetableName))
            {
                vegetables.Add(vegetableName, amount);
            }
            else
            {
                vegetables[vegetableName] += amount;
            }
            label2.Text = $"{vegetableCost}лв kg";

            totalPrice += price;
            label5.Text = $"{totalPrice:f2} лв";


        }

        private void milkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chemistyCount = 0;
            organicCount++;
            vegetableCost += 2;
            if(organicCount > 1)
            {
                vegetableCost -= 2;
                organicCount = 0;
            }
            label2.Text = $"{vegetableCost}лв kg";
        }

        private void cheeseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            organicCount = 0;
            chemistyCount++;
            vegetableCost -= 2;
            if(chemistyCount > 1)
            {
                vegetableCost += 2;
                chemistyCount = 0;
            }
            label2.Text = $"{vegetableCost}лв kg";
        }

        private void Vegetables_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
