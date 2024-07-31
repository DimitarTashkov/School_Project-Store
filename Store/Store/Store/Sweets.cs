using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace Store
{
    public partial class Sweets : Form
    {
        private const decimal SvogePrice = 2.29m;
        private const decimal MilkaPrice = 3.49m;
        private const decimal LindorPrice = 3.99m;
        private const decimal BorovecPrice = 0.79m;
        private const decimal MuraPrice = 0.55m;
        private const decimal PrestigePrice = 0.34m;
        private const decimal SuchardPrice = 4.39m;
        private const decimal SezoniPrice = 4.59m;
        private const decimal MerciPrice = 9.59m;

        Dictionary<string,int> sweets = new Dictionary<string,int>();

        private decimal sweetPrice;
        private string sweetName;
        private decimal totalPrice;

        private bool isChocolatesChoosen;
        private bool isWafflesChoosen;
        private bool isCandiesChoosen;
        public Sweets()
        {
            InitializeComponent();
        }

        private void chocolatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isChocolatesChoosen = true;
            isWafflesChoosen = false;
            isCandiesChoosen = false;

            radioButton5.Text = $"Option 1: {SvogePrice}лв";
            radioButton2.Text = $"Option 2: {MilkaPrice}лв";
            radioButton3.Text = $"Option 3: {LindorPrice}лв";

            pictureBox1.Load(@"..\..\..\Store\Resources\svoge.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\milka.jpg");
            pictureBox3.Load(@"..\..\..\Store\Resources\lindor.jpg");
        }

        private void wafflesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isWafflesChoosen = true;
            isChocolatesChoosen = false;
            isCandiesChoosen = false;

            radioButton5.Text = $"Option 1: {BorovecPrice}лв";
            radioButton2.Text = $"Option 2: {MuraPrice}лв";
            radioButton3.Text = $"Option 3: {PrestigePrice}лв";

            pictureBox1.Load(@"..\..\..\Store\Resources\borovec.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\mura.jpg");
            pictureBox3.Load(@"..\..\..\Store\Resources\prestige.jpg");
        }

        private void candiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            isCandiesChoosen = true;
            isWafflesChoosen = false;
            isChocolatesChoosen = false;

            radioButton5.Text = $"Option 1: {SuchardPrice}лв";
            radioButton2.Text = $"Option 2: {SezoniPrice}лв";
            radioButton3.Text = $"Option 3: {MerciPrice}лв";

            pictureBox1.Load(@"..\..\..\Store\Resources\suchard.jpg");
            pictureBox2.Load(@"..\..\..\Store\Resources\sezoni.jpg");
            pictureBox3.Load(@"..\..\..\Store\Resources\merci.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                if (isChocolatesChoosen)
                {
                    sweetName = "Svoge";
                    sweetPrice = SvogePrice;                   
                }
                else if (isWafflesChoosen)
                {
                    sweetName = "Borovec";
                    sweetPrice = BorovecPrice;
                }
                else if (isCandiesChoosen)
                {
                    sweetName = "Suchard";
                    sweetPrice = SuchardPrice;
                }
            }
           else if (radioButton2.Checked)
            {
                if (isChocolatesChoosen)
                {
                    sweetName = "Milka";
                    sweetPrice = MilkaPrice;
                }
                else if (isWafflesChoosen)
                {
                    sweetName = "Mura";
                    sweetPrice = MuraPrice;
                }
                else if (isCandiesChoosen)
                {
                    sweetName = "Sezoni";
                    sweetPrice = SezoniPrice;
                }
            }          
            else if (radioButton3.Checked)
            {
                if (isChocolatesChoosen)
                {
                    sweetName = "Lindor";
                    sweetPrice = LindorPrice;
                }
                else if (isWafflesChoosen)
                {
                    sweetName = "Prestige";
                    sweetPrice = PrestigePrice;
                }
                else if (isCandiesChoosen)
                {
                    sweetName = "Merci";
                    sweetPrice = MerciPrice;
                }
            }

            if(!sweets.ContainsKey(sweetName))
            {
                sweets.Add(sweetName, 1);
            }
            else
            {
                sweets[sweetName]++;
            }

            totalPrice += sweetPrice;
            label5.Text = $"{totalPrice:f2} лв";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter updateCosts = new StreamWriter(@"..\..\..\Store\Costs.txt");
            StreamWriter updateItems = new StreamWriter(@"..\..\..\Store\SweetsItems.txt");
            using (updateCosts)
            {
                updateCosts.WriteLine(totalPrice);
            }
            using (updateItems)
            {
                updateItems.WriteLine($"Sweets expenses: {totalPrice:f2}");
                foreach (var kvp in sweets)
                {
                    updateItems.Write($"{kvp.Key} - {kvp.Value}pcs, ");
                }
            }
            this.Close();
        }
    }
}
