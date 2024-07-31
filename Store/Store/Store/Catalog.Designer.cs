
namespace Store
{
    partial class Catalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.diaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vegetablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fruitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sweetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.snacksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diaryToolStripMenuItem,
            this.vegetablesToolStripMenuItem,
            this.fruitsToolStripMenuItem,
            this.sweetsToolStripMenuItem,
            this.snacksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // diaryToolStripMenuItem
            // 
            this.diaryToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 14.25F);
            this.diaryToolStripMenuItem.Name = "diaryToolStripMenuItem";
            this.diaryToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.diaryToolStripMenuItem.Text = "Diary";
            this.diaryToolStripMenuItem.Click += new System.EventHandler(this.diaryToolStripMenuItem_Click);
            // 
            // vegetablesToolStripMenuItem
            // 
            this.vegetablesToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 14.25F);
            this.vegetablesToolStripMenuItem.Name = "vegetablesToolStripMenuItem";
            this.vegetablesToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.vegetablesToolStripMenuItem.Text = "Vegetables";
            this.vegetablesToolStripMenuItem.Click += new System.EventHandler(this.vegetablesToolStripMenuItem_Click);
            // 
            // fruitsToolStripMenuItem
            // 
            this.fruitsToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 14.25F);
            this.fruitsToolStripMenuItem.Name = "fruitsToolStripMenuItem";
            this.fruitsToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.fruitsToolStripMenuItem.Text = "Fruits";
            this.fruitsToolStripMenuItem.Click += new System.EventHandler(this.fruitsToolStripMenuItem_Click);
            // 
            // sweetsToolStripMenuItem
            // 
            this.sweetsToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 14.25F);
            this.sweetsToolStripMenuItem.Name = "sweetsToolStripMenuItem";
            this.sweetsToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.sweetsToolStripMenuItem.Text = "Sweets";
            this.sweetsToolStripMenuItem.Click += new System.EventHandler(this.sweetsToolStripMenuItem_Click);
            // 
            // snacksToolStripMenuItem
            // 
            this.snacksToolStripMenuItem.Font = new System.Drawing.Font("SimSun", 14.25F);
            this.snacksToolStripMenuItem.Name = "snacksToolStripMenuItem";
            this.snacksToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.snacksToolStripMenuItem.Text = "Snacks";
            this.snacksToolStripMenuItem.Click += new System.EventHandler(this.snacksToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("NSimSun", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(541, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Proceed to checkout!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(235, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "CurrentExpense:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(375, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(2, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update Expenses:";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Store.Properties.Resources.T67uPR;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem diaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vegetablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fruitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sweetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem snacksToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}