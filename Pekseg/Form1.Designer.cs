﻿namespace Pekseg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPekaruPekseghezFelvetele = new System.Windows.Forms.Button();
            this.listBoxPeksegPekaruk = new System.Windows.Forms.ListBox();
            this.listBoxPeksegek = new System.Windows.Forms.ListBox();
            this.buttonPeksegHozzaadas = new System.Windows.Forms.Button();
            this.textBoxPeksegNevInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPekaruTorles = new System.Windows.Forms.Button();
            this.numericUpDownPekaruArInput = new System.Windows.Forms.NumericUpDown();
            this.listBoxPekaruk = new System.Windows.Forms.ListBox();
            this.buttonPekaruHozzaadas = new System.Windows.Forms.Button();
            this.checkBoxLaktormentesInput = new System.Windows.Forms.CheckBox();
            this.textBoxPekaruNevInput = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelStatisztika = new System.Windows.Forms.Label();
            this.listBoxPeksegekStatisztika = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPekaruArInput)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adatok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonPekaruPekseghezFelvetele);
            this.groupBox2.Controls.Add(this.listBoxPeksegPekaruk);
            this.groupBox2.Controls.Add(this.listBoxPeksegek);
            this.groupBox2.Controls.Add(this.buttonPeksegHozzaadas);
            this.groupBox2.Controls.Add(this.textBoxPeksegNevInput);
            this.groupBox2.Location = new System.Drawing.Point(7, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 236);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pékségek";
            // 
            // buttonPekaruPekseghezFelvetele
            // 
            this.buttonPekaruPekseghezFelvetele.Location = new System.Drawing.Point(605, 187);
            this.buttonPekaruPekseghezFelvetele.Name = "buttonPekaruPekseghezFelvetele";
            this.buttonPekaruPekseghezFelvetele.Size = new System.Drawing.Size(75, 23);
            this.buttonPekaruPekseghezFelvetele.TabIndex = 4;
            this.buttonPekaruPekseghezFelvetele.Text = "+";
            this.buttonPekaruPekseghezFelvetele.UseVisualStyleBackColor = true;
            this.buttonPekaruPekseghezFelvetele.Click += new System.EventHandler(this.buttonPekaruPekseghezFelvetele_Click);
            // 
            // listBoxPeksegPekaruk
            // 
            this.listBoxPeksegPekaruk.FormattingEnabled = true;
            this.listBoxPeksegPekaruk.Location = new System.Drawing.Point(537, 20);
            this.listBoxPeksegPekaruk.Name = "listBoxPeksegPekaruk";
            this.listBoxPeksegPekaruk.Size = new System.Drawing.Size(212, 147);
            this.listBoxPeksegPekaruk.TabIndex = 3;
            // 
            // listBoxPeksegek
            // 
            this.listBoxPeksegek.FormattingEnabled = true;
            this.listBoxPeksegek.Location = new System.Drawing.Point(193, 20);
            this.listBoxPeksegek.Name = "listBoxPeksegek";
            this.listBoxPeksegek.Size = new System.Drawing.Size(337, 199);
            this.listBoxPeksegek.TabIndex = 2;
            this.listBoxPeksegek.SelectedIndexChanged += new System.EventHandler(this.listBoxPeksegek_SelectedIndexChanged);
            // 
            // buttonPeksegHozzaadas
            // 
            this.buttonPeksegHozzaadas.Location = new System.Drawing.Point(7, 47);
            this.buttonPeksegHozzaadas.Name = "buttonPeksegHozzaadas";
            this.buttonPeksegHozzaadas.Size = new System.Drawing.Size(75, 23);
            this.buttonPeksegHozzaadas.TabIndex = 1;
            this.buttonPeksegHozzaadas.Text = "Hozzáadás";
            this.buttonPeksegHozzaadas.UseVisualStyleBackColor = true;
            this.buttonPeksegHozzaadas.Click += new System.EventHandler(this.buttonPeksegHozzaadas_Click);
            // 
            // textBoxPeksegNevInput
            // 
            this.textBoxPeksegNevInput.Location = new System.Drawing.Point(7, 20);
            this.textBoxPeksegNevInput.Name = "textBoxPeksegNevInput";
            this.textBoxPeksegNevInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxPeksegNevInput.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPekaruTorles);
            this.groupBox1.Controls.Add(this.numericUpDownPekaruArInput);
            this.groupBox1.Controls.Add(this.listBoxPekaruk);
            this.groupBox1.Controls.Add(this.buttonPekaruHozzaadas);
            this.groupBox1.Controls.Add(this.checkBoxLaktormentesInput);
            this.groupBox1.Controls.Add(this.textBoxPekaruNevInput);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pékáruk";
            // 
            // buttonPekaruTorles
            // 
            this.buttonPekaruTorles.Location = new System.Drawing.Point(88, 98);
            this.buttonPekaruTorles.Name = "buttonPekaruTorles";
            this.buttonPekaruTorles.Size = new System.Drawing.Size(75, 23);
            this.buttonPekaruTorles.TabIndex = 6;
            this.buttonPekaruTorles.Text = "Törlés";
            this.buttonPekaruTorles.UseVisualStyleBackColor = true;
            this.buttonPekaruTorles.Click += new System.EventHandler(this.buttonPekaruTorles_Click);
            // 
            // numericUpDownPekaruArInput
            // 
            this.numericUpDownPekaruArInput.Location = new System.Drawing.Point(7, 47);
            this.numericUpDownPekaruArInput.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPekaruArInput.Name = "numericUpDownPekaruArInput";
            this.numericUpDownPekaruArInput.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownPekaruArInput.TabIndex = 5;
            // 
            // listBoxPekaruk
            // 
            this.listBoxPekaruk.FormattingEnabled = true;
            this.listBoxPekaruk.Location = new System.Drawing.Point(193, 20);
            this.listBoxPekaruk.Name = "listBoxPekaruk";
            this.listBoxPekaruk.Size = new System.Drawing.Size(556, 108);
            this.listBoxPekaruk.TabIndex = 4;
            this.listBoxPekaruk.SelectedIndexChanged += new System.EventHandler(this.listBoxPekaruk_SelectedIndexChanged);
            // 
            // buttonPekaruHozzaadas
            // 
            this.buttonPekaruHozzaadas.Location = new System.Drawing.Point(7, 98);
            this.buttonPekaruHozzaadas.Name = "buttonPekaruHozzaadas";
            this.buttonPekaruHozzaadas.Size = new System.Drawing.Size(75, 23);
            this.buttonPekaruHozzaadas.TabIndex = 3;
            this.buttonPekaruHozzaadas.Text = "Hozzáadás";
            this.buttonPekaruHozzaadas.UseVisualStyleBackColor = true;
            this.buttonPekaruHozzaadas.Click += new System.EventHandler(this.buttonPekaruHozzaadas_Click);
            // 
            // checkBoxLaktormentesInput
            // 
            this.checkBoxLaktormentesInput.AutoSize = true;
            this.checkBoxLaktormentesInput.Location = new System.Drawing.Point(7, 74);
            this.checkBoxLaktormentesInput.Name = "checkBoxLaktormentesInput";
            this.checkBoxLaktormentesInput.Size = new System.Drawing.Size(88, 17);
            this.checkBoxLaktormentesInput.TabIndex = 2;
            this.checkBoxLaktormentesInput.Text = "laktózmentes";
            this.checkBoxLaktormentesInput.UseVisualStyleBackColor = true;
            // 
            // textBoxPekaruNevInput
            // 
            this.textBoxPekaruNevInput.Location = new System.Drawing.Point(7, 20);
            this.textBoxPekaruNevInput.Name = "textBoxPekaruNevInput";
            this.textBoxPekaruNevInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxPekaruNevInput.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelStatisztika);
            this.tabPage2.Controls.Add(this.listBoxPeksegekStatisztika);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Statisztikák";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelStatisztika
            // 
            this.labelStatisztika.AutoSize = true;
            this.labelStatisztika.Location = new System.Drawing.Point(304, 7);
            this.labelStatisztika.Name = "labelStatisztika";
            this.labelStatisztika.Size = new System.Drawing.Size(0, 13);
            this.labelStatisztika.TabIndex = 1;
            // 
            // listBoxPeksegekStatisztika
            // 
            this.listBoxPeksegekStatisztika.FormattingEnabled = true;
            this.listBoxPeksegekStatisztika.Location = new System.Drawing.Point(7, 7);
            this.listBoxPeksegekStatisztika.Name = "listBoxPeksegekStatisztika";
            this.listBoxPeksegekStatisztika.Size = new System.Drawing.Size(290, 277);
            this.listBoxPeksegekStatisztika.TabIndex = 0;
            this.listBoxPeksegekStatisztika.SelectedIndexChanged += new System.EventHandler(this.listBoxPeksegekStatisztika_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pékség";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPekaruArInput)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonPekaruPekseghezFelvetele;
        private System.Windows.Forms.ListBox listBoxPeksegPekaruk;
        private System.Windows.Forms.ListBox listBoxPeksegek;
        private System.Windows.Forms.Button buttonPeksegHozzaadas;
        private System.Windows.Forms.TextBox textBoxPeksegNevInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPekaruk;
        private System.Windows.Forms.Button buttonPekaruHozzaadas;
        private System.Windows.Forms.CheckBox checkBoxLaktormentesInput;
        private System.Windows.Forms.TextBox textBoxPekaruNevInput;
        private System.Windows.Forms.Label labelStatisztika;
        private System.Windows.Forms.ListBox listBoxPeksegekStatisztika;
        private System.Windows.Forms.NumericUpDown numericUpDownPekaruArInput;
        private System.Windows.Forms.Button buttonPekaruTorles;
    }
}

