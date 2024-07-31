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
    public partial class Snacks : Form
    {
        private const decimal BireniPrice = 0.89m;
        private const decimal PecheniPrice = 4.69m;
        private const decimal KashuPrice = 4.19m;
        private const decimal RufflesPrice = 4.49m;
        private const decimal PringlesPrice = 5.59m;
        private const decimal DorritosPrice = 3.39m;
        private const decimal TraqnaPrice = 2.99m;
        private const decimal RumiPrice = 2.89m;
        private const decimal BelvitaPrice = 5.89m;

        private Dictionary<string, int> snacks = new Dictionary<string, int>();

        private decimal snacksPrice;
        private string snacksName;
        private decimal totalPrice;

        private bool IsNutsChoosen;
        private bool IsChipsChoosen;
        private bool IsCookiesChoosen;

        public Snacks()
        {
            InitializeComponent();
        }

        private void chocolatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsNutsChoosen = true;
            IsChipsChoosen = false;
            IsCookiesChoosen = false;


            radioButton5.Text = $"Option 1: {BireniPrice}лв";
            radioButton2.Text = $"Option 2: {PecheniPrice}лв";
            radioButton3.Text = $"Option 3: {KashuPrice}лв";

            pictureBox1.Load(@"..\..\..\Store\Resources\bireni.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\pecheni.jpg");
            pictureBox3.Load(@"..\..\..\Store\Resources\kashu.jpg");
        }

        private void wafflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsChipsChoosen = true;
            IsNutsChoosen = false;
            IsCookiesChoosen = false;


            radioButton5.Text = $"Option 1: {RufflesPrice}лв";
            radioButton2.Text = $"Option 2: {PringlesPrice}лв";
            radioButton3.Text = $"Option 3: {DorritosPrice}лв";

            pictureBox1.Load(@"..\..\..\Store\Resources\ruffles.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\pringles.jpg");
            pictureBox3.Load(@"..\..\..\Store\Resources\doritos.jpg");
        }

        private void candiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsCookiesChoosen = true;
            IsChipsChoosen = false;
            IsNutsChoosen = false;


            radioButton5.Text = $"Option 1: {TraqnaPrice}лв";
            radioButton2.Text = $"Option 2: {RumiPrice}лв";
            radioButton3.Text = $"Option 3: {BelvitaPrice}лв";

            pictureBox1.Load(@"..\..\..\Store\Resources\traqna.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\rumi.jpg");
            pictureBox3.Load(@"..\..\..\Store\Resources\belvita.gif");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (IsNutsChoosen)
                {
                    snacksName = "Bireni nuts";
                    snacksPrice = BireniPrice;
                }
                else if (IsChipsChoosen)
                {
                    snacksName = "Ruffles chips";
                    snacksPrice = RufflesPrice;
                }
                else if (IsCookiesChoosen)
                {
                    snacksName = "Traqna biscuits";
                    snacksPrice = TraqnaPrice;
                }
            }
            else if (radioButton2.Checked)
            {
                if (IsNutsChoosen)
                {
                    snacksName = "Roasted nuts";
                    snacksPrice = PecheniPrice;
                }
                else if (IsChipsChoosen)
                {
                    snacksName = "Pringles chips";
                    snacksPrice = PringlesPrice;
                }
                else if (IsCookiesChoosen)
                {
                    snacksName = "Rumi biscuits";
                    snacksPrice = RumiPrice;
                }
            }
            else if (radioButton3.Checked)
            {
                if (IsNutsChoosen)
                {
                    snacksName = "Kashu nuts";
                    snacksPrice = KashuPrice;
                }
                else if (IsChipsChoosen)
                {
                    snacksName = "Dorritos chips";
                    snacksPrice = DorritosPrice;
                }
                else if (IsCookiesChoosen)
                {
                    snacksName = "Belvita biscuits";
                    snacksPrice = BelvitaPrice;
                }
            }
            if(!snacks.ContainsKey(snacksName))
            {
                snacks.Add(snacksName, 1);
            }
            else
            {
                snacks[snacksName]++;
            }

            totalPrice += snacksPrice;
            label5.Text = $"{totalPrice:f2} лв";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter updateCosts = new StreamWriter(@"..\..\..\Store\Costs.txt");
            StreamWriter updateItems = new StreamWriter(@"..\..\..\Store\SnacksItems.txt");
            using (updateCosts)
            {
                updateCosts.WriteLine(totalPrice);
            }
            using (updateItems)
            {
                updateItems.WriteLine($"Snacks expenses: {totalPrice:f2}");
                foreach (var kvp in snacks)
                {
                    updateItems.Write($"{kvp.Key} - {kvp.Value}pcs, ");
                }
            }
            this.Close();
        }
    }
}
