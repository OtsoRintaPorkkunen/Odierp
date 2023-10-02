namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            tietojaToolStripMenuItem = new ToolStripMenuItem();
            testaaTietokoneyhteyttäToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ujuToolStripMenuItem = new ToolStripMenuItem();
            hToolStripMenuItem = new ToolStripMenuItem();
            tietojaToolStripMenuItem1 = new ToolStripMenuItem();
            testaaTietokonettaToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label5 = new Label();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(447, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(349, 586);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toiminnallisuus";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Location = new Point(15, 203);
            button3.Name = "button3";
            button3.Size = new Size(328, 71);
            button3.TabIndex = 2;
            button3.Text = "Poista";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(15, 113);
            button2.Name = "button2";
            button2.Size = new Size(328, 73);
            button2.TabIndex = 1;
            button2.Text = "Tallenna";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(15, 30);
            button1.Name = "button1";
            button1.Size = new Size(328, 64);
            button1.TabIndex = 0;
            button1.Text = "Uusi tietue";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, tietojaToolStripMenuItem, testaaTietokoneyhteyttäToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(277, 100);
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(276, 32);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.Size = new Size(164, 34);
            poistuToolStripMenuItem.Text = "poistu";
            // 
            // tietojaToolStripMenuItem
            // 
            tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            tietojaToolStripMenuItem.Size = new Size(276, 32);
            tietojaToolStripMenuItem.Text = "tietoja";
            // 
            // testaaTietokoneyhteyttäToolStripMenuItem
            // 
            testaaTietokoneyhteyttäToolStripMenuItem.Name = "testaaTietokoneyhteyttäToolStripMenuItem";
            testaaTietokoneyhteyttäToolStripMenuItem.Size = new Size(276, 32);
            testaaTietokoneyhteyttäToolStripMenuItem.Text = "Testaa tietokoneyhteyttä";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ujuToolStripMenuItem, tietojaToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(808, 33);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ujuToolStripMenuItem
            // 
            ujuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hToolStripMenuItem });
            ujuToolStripMenuItem.Name = "ujuToolStripMenuItem";
            ujuToolStripMenuItem.Size = new Size(97, 29);
            ujuToolStripMenuItem.Text = "Tiedosto";
            ujuToolStripMenuItem.Click += ujuToolStripMenuItem_Click;
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.Name = "hToolStripMenuItem";
            hToolStripMenuItem.Size = new Size(164, 34);
            hToolStripMenuItem.Text = "poistu";
            hToolStripMenuItem.Click += hToolStripMenuItem_Click;
            // 
            // tietojaToolStripMenuItem1
            // 
            tietojaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { testaaTietokonettaToolStripMenuItem, infoToolStripMenuItem });
            tietojaToolStripMenuItem1.Name = "tietojaToolStripMenuItem1";
            tietojaToolStripMenuItem1.Size = new Size(80, 29);
            tietojaToolStripMenuItem1.Text = "Tietoja";
            // 
            // testaaTietokonettaToolStripMenuItem
            // 
            testaaTietokonettaToolStripMenuItem.Name = "testaaTietokonettaToolStripMenuItem";
            testaaTietokonettaToolStripMenuItem.Size = new Size(263, 34);
            testaaTietokonettaToolStripMenuItem.Text = "Testaa tietokonetta";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(263, 34);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(429, 328);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Elokuvan tiedot";
            // 
            // button4
            // 
            button4.Location = new Point(24, 240);
            button4.Name = "button4";
            button4.Size = new Size(164, 61);
            button4.TabIndex = 3;
            button4.Text = "Edellinen";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(214, 240);
            button5.Name = "button5";
            button5.Size = new Size(180, 61);
            button5.TabIndex = 4;
            button5.Text = "Seuraava";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(148, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 12;
            textBox4.Text = "0";
            textBox4.Click += textBox4_Click;
            textBox4.Leave += textBox4_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(148, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 11;
            textBox3.Click += textBox3_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 31);
            textBox2.TabIndex = 10;
            textBox2.Text = "[Syötä elokuvan nimi]";
            textBox2.Click += textBox2_Click;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 55);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 9;
            textBox1.Text = "0";
            textBox1.Click += textBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 58);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 5;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 99);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 6;
            label2.Text = "Nimi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 134);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 7;
            label3.Text = "Julkaisuvuosi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 176);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 8;
            label4.Text = "Kesto (min):";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Location = new Point(12, 396);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(429, 225);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Arvio";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(118, 181);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(53, 31);
            numericUpDown2.TabIndex = 16;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(197, 181);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(52, 31);
            numericUpDown1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 183);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 14;
            label5.Text = "Arvosana:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(24, 41);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(386, 126);
            textBox5.TabIndex = 13;
            textBox5.Text = "[Kirjoita arvio tähän]";
            textBox5.Click += textBox5_Click;
            textBox5.Leave += textBox5_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 633);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Elokuvasovellus";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem tietojaToolStripMenuItem;
        private ToolStripMenuItem testaaTietokoneyhteyttäToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ujuToolStripMenuItem;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripMenuItem tietojaToolStripMenuItem1;
        private ToolStripMenuItem testaaTietokonettaToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private TextBox textBox5;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label5;
    }
}