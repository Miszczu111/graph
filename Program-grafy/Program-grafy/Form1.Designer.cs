namespace Program_grafy
{
    partial class Form1
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
            this.czytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rysujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafDopełniajacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafNaKoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.razemNaKoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czytajToolStripMenuItem,
            this.rysujToolStripMenuItem,
            this.raportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // czytajToolStripMenuItem
            // 
            this.czytajToolStripMenuItem.Name = "czytajToolStripMenuItem";
            this.czytajToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.czytajToolStripMenuItem.Text = "Czytaj";
            this.czytajToolStripMenuItem.Click += new System.EventHandler(this.czytajToolStripMenuItem_Click);
            // 
            // rysujToolStripMenuItem
            // 
            this.rysujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafToolStripMenuItem,
            this.grafDopełniajacyToolStripMenuItem,
            this.razemToolStripMenuItem,
            this.grafNaKoleToolStripMenuItem,
            this.grafToolStripMenuItem1,
            this.razemNaKoleToolStripMenuItem});
            this.rysujToolStripMenuItem.Name = "rysujToolStripMenuItem";
            this.rysujToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rysujToolStripMenuItem.Text = "Rysuj";
            // 
            // grafToolStripMenuItem
            // 
            this.grafToolStripMenuItem.Name = "grafToolStripMenuItem";
            this.grafToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.grafToolStripMenuItem.Text = "Graf";
            this.grafToolStripMenuItem.Click += new System.EventHandler(this.grafToolStripMenuItem_Click);
            // 
            // grafDopełniajacyToolStripMenuItem
            // 
            this.grafDopełniajacyToolStripMenuItem.Name = "grafDopełniajacyToolStripMenuItem";
            this.grafDopełniajacyToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.grafDopełniajacyToolStripMenuItem.Text = "Graf dopełniający";
            this.grafDopełniajacyToolStripMenuItem.Click += new System.EventHandler(this.grafDopełniajacyToolStripMenuItem_Click);
            // 
            // razemToolStripMenuItem
            // 
            this.razemToolStripMenuItem.Name = "razemToolStripMenuItem";
            this.razemToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.razemToolStripMenuItem.Text = "Razem";
            this.razemToolStripMenuItem.Click += new System.EventHandler(this.razemToolStripMenuItem_Click);
            // 
            // grafNaKoleToolStripMenuItem
            // 
            this.grafNaKoleToolStripMenuItem.Name = "grafNaKoleToolStripMenuItem";
            this.grafNaKoleToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.grafNaKoleToolStripMenuItem.Text = "Graf na kole";
            // 
            // grafToolStripMenuItem1
            // 
            this.grafToolStripMenuItem1.Name = "grafToolStripMenuItem1";
            this.grafToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.grafToolStripMenuItem1.Text = "Graf dopełniający na kole";
            // 
            // razemNaKoleToolStripMenuItem
            // 
            this.razemNaKoleToolStripMenuItem.Name = "razemNaKoleToolStripMenuItem";
            this.razemNaKoleToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.razemNaKoleToolStripMenuItem.Text = "Razem na kole";
            // 
            // raportToolStripMenuItem
            // 
            this.raportToolStripMenuItem.Name = "raportToolStripMenuItem";
            this.raportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.raportToolStripMenuItem.Text = "Raport";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtList);
            this.groupBox3.Location = new System.Drawing.Point(19, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(132, 130);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odczytana lista";
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(7, 20);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(120, 104);
            this.txtList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Graf";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Graf dopełniający";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem czytajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rysujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafDopełniajacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafNaKoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem razemNaKoleToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

