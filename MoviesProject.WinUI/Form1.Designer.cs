
namespace MoviesProject.WinUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPages = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonekle = new System.Windows.Forms.Button();
            this.buttonsil = new System.Windows.Forms.Button();
            this.buttonguncelle = new System.Windows.Forms.Button();
            this.buttonlistele = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxfilmadı = new System.Windows.Forms.TextBox();
            this.textBoxfilmID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonyntgunc = new System.Windows.Forms.Button();
            this.buttonyntekle = new System.Windows.Forms.Button();
            this.buttonyontlistele = new System.Windows.Forms.Button();
            this.buttonyonetsil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxyonetmenad = new System.Windows.Forms.TextBox();
            this.textBoxyonetid = new System.Windows.Forms.TextBox();
            this.textBoxaktorid = new System.Windows.Forms.TextBox();
            this.textBoxaktoradı = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonaktorsil = new System.Windows.Forms.Button();
            this.buttonaktorlistle = new System.Windows.Forms.Button();
            this.buttonaktorekle = new System.Windows.Forms.Button();
            this.buttonaktorgncl = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPages);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(26, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 245);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.linkLabel1);
            this.tabPages.Controls.Add(this.dateTimePicker1);
            this.tabPages.Controls.Add(this.comboBox1);
            this.tabPages.Controls.Add(this.textBoxfilmID);
            this.tabPages.Controls.Add(this.textBoxfilmadı);
            this.tabPages.Controls.Add(this.label4);
            this.tabPages.Controls.Add(this.label3);
            this.tabPages.Controls.Add(this.label2);
            this.tabPages.Controls.Add(this.label1);
            this.tabPages.Controls.Add(this.buttonlistele);
            this.tabPages.Controls.Add(this.buttonguncelle);
            this.tabPages.Controls.Add(this.buttonsil);
            this.tabPages.Controls.Add(this.buttonekle);
            this.tabPages.Location = new System.Drawing.Point(4, 22);
            this.tabPages.Name = "tabPages";
            this.tabPages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPages.Size = new System.Drawing.Size(661, 219);
            this.tabPages.TabIndex = 0;
            this.tabPages.Text = "Film";
            this.tabPages.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxyonetid);
            this.tabPage2.Controls.Add(this.textBoxyonetmenad);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonyonetsil);
            this.tabPage2.Controls.Add(this.buttonyontlistele);
            this.tabPage2.Controls.Add(this.buttonyntekle);
            this.tabPage2.Controls.Add(this.buttonyntgunc);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yonetmen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxaktorid);
            this.tabPage3.Controls.Add(this.textBoxaktoradı);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.buttonaktorsil);
            this.tabPage3.Controls.Add(this.buttonaktorlistle);
            this.tabPage3.Controls.Add(this.buttonaktorekle);
            this.tabPage3.Controls.Add(this.buttonaktorgncl);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(661, 219);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Aktor";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonekle
            // 
            this.buttonekle.Location = new System.Drawing.Point(145, 175);
            this.buttonekle.Name = "buttonekle";
            this.buttonekle.Size = new System.Drawing.Size(75, 23);
            this.buttonekle.TabIndex = 0;
            this.buttonekle.Text = "Ekle";
            this.buttonekle.UseVisualStyleBackColor = true;
            this.buttonekle.Click += new System.EventHandler(this.buttonekle_Click);
            // 
            // buttonsil
            // 
            this.buttonsil.Location = new System.Drawing.Point(532, 175);
            this.buttonsil.Name = "buttonsil";
            this.buttonsil.Size = new System.Drawing.Size(75, 23);
            this.buttonsil.TabIndex = 1;
            this.buttonsil.Text = "Sil";
            this.buttonsil.UseVisualStyleBackColor = true;
            this.buttonsil.Click += new System.EventHandler(this.buttonsil_Click);
            // 
            // buttonguncelle
            // 
            this.buttonguncelle.Location = new System.Drawing.Point(44, 175);
            this.buttonguncelle.Name = "buttonguncelle";
            this.buttonguncelle.Size = new System.Drawing.Size(75, 23);
            this.buttonguncelle.TabIndex = 2;
            this.buttonguncelle.Text = "Guncelle";
            this.buttonguncelle.UseVisualStyleBackColor = true;
            this.buttonguncelle.Click += new System.EventHandler(this.buttonguncelle_Click);
            // 
            // buttonlistele
            // 
            this.buttonlistele.Location = new System.Drawing.Point(257, 175);
            this.buttonlistele.Name = "buttonlistele";
            this.buttonlistele.Size = new System.Drawing.Size(75, 23);
            this.buttonlistele.TabIndex = 3;
            this.buttonlistele.Text = "Listele";
            this.buttonlistele.UseVisualStyleBackColor = true;
            this.buttonlistele.Click += new System.EventHandler(this.buttonlistele_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Çıkış Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Yonetmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "FilmID";
            // 
            // textBoxfilmadı
            // 
            this.textBoxfilmadı.Location = new System.Drawing.Point(120, 30);
            this.textBoxfilmadı.Name = "textBoxfilmadı";
            this.textBoxfilmadı.Size = new System.Drawing.Size(100, 20);
            this.textBoxfilmadı.TabIndex = 8;
            // 
            // textBoxfilmID
            // 
            this.textBoxfilmID.Location = new System.Drawing.Point(478, 30);
            this.textBoxfilmID.Name = "textBoxfilmID";
            this.textBoxfilmID.Size = new System.Drawing.Size(100, 20);
            this.textBoxfilmID.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 73);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(660, 180);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(256, 122);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(76, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "YonetmenEkle";
            // 
            // buttonyntgunc
            // 
            this.buttonyntgunc.Location = new System.Drawing.Point(40, 170);
            this.buttonyntgunc.Name = "buttonyntgunc";
            this.buttonyntgunc.Size = new System.Drawing.Size(75, 23);
            this.buttonyntgunc.TabIndex = 0;
            this.buttonyntgunc.Text = "Guncelle";
            this.buttonyntgunc.UseVisualStyleBackColor = true;
            // 
            // buttonyntekle
            // 
            this.buttonyntekle.Location = new System.Drawing.Point(158, 169);
            this.buttonyntekle.Name = "buttonyntekle";
            this.buttonyntekle.Size = new System.Drawing.Size(75, 23);
            this.buttonyntekle.TabIndex = 1;
            this.buttonyntekle.Text = "Ekle";
            this.buttonyntekle.UseVisualStyleBackColor = true;
            // 
            // buttonyontlistele
            // 
            this.buttonyontlistele.Location = new System.Drawing.Point(269, 168);
            this.buttonyontlistele.Name = "buttonyontlistele";
            this.buttonyontlistele.Size = new System.Drawing.Size(75, 23);
            this.buttonyontlistele.TabIndex = 2;
            this.buttonyontlistele.Text = "Listele";
            this.buttonyontlistele.UseVisualStyleBackColor = true;
            // 
            // buttonyonetsil
            // 
            this.buttonyonetsil.Location = new System.Drawing.Point(566, 167);
            this.buttonyonetsil.Name = "buttonyonetsil";
            this.buttonyonetsil.Size = new System.Drawing.Size(75, 23);
            this.buttonyonetsil.TabIndex = 3;
            this.buttonyonetsil.Text = "buttonSil";
            this.buttonyonetsil.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yonetmen Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yonetmen ID";
            // 
            // textBoxyonetmenad
            // 
            this.textBoxyonetmenad.Location = new System.Drawing.Point(145, 31);
            this.textBoxyonetmenad.Name = "textBoxyonetmenad";
            this.textBoxyonetmenad.Size = new System.Drawing.Size(100, 20);
            this.textBoxyonetmenad.TabIndex = 6;
            // 
            // textBoxyonetid
            // 
            this.textBoxyonetid.Location = new System.Drawing.Point(145, 66);
            this.textBoxyonetid.Name = "textBoxyonetid";
            this.textBoxyonetid.Size = new System.Drawing.Size(100, 20);
            this.textBoxyonetid.TabIndex = 7;
            // 
            // textBoxaktorid
            // 
            this.textBoxaktorid.Location = new System.Drawing.Point(135, 63);
            this.textBoxaktorid.Name = "textBoxaktorid";
            this.textBoxaktorid.Size = new System.Drawing.Size(100, 20);
            this.textBoxaktorid.TabIndex = 15;
            // 
            // textBoxaktoradı
            // 
            this.textBoxaktoradı.Location = new System.Drawing.Point(135, 28);
            this.textBoxaktoradı.Name = "textBoxaktoradı";
            this.textBoxaktoradı.Size = new System.Drawing.Size(100, 20);
            this.textBoxaktoradı.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Aktor ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Aktor Adı";
            // 
            // buttonaktorsil
            // 
            this.buttonaktorsil.Location = new System.Drawing.Point(556, 164);
            this.buttonaktorsil.Name = "buttonaktorsil";
            this.buttonaktorsil.Size = new System.Drawing.Size(75, 23);
            this.buttonaktorsil.TabIndex = 11;
            this.buttonaktorsil.Text = "buttonSil";
            this.buttonaktorsil.UseVisualStyleBackColor = true;
            // 
            // buttonaktorlistle
            // 
            this.buttonaktorlistle.Location = new System.Drawing.Point(259, 165);
            this.buttonaktorlistle.Name = "buttonaktorlistle";
            this.buttonaktorlistle.Size = new System.Drawing.Size(75, 23);
            this.buttonaktorlistle.TabIndex = 10;
            this.buttonaktorlistle.Text = "Listele";
            this.buttonaktorlistle.UseVisualStyleBackColor = true;
            // 
            // buttonaktorekle
            // 
            this.buttonaktorekle.Location = new System.Drawing.Point(148, 166);
            this.buttonaktorekle.Name = "buttonaktorekle";
            this.buttonaktorekle.Size = new System.Drawing.Size(75, 23);
            this.buttonaktorekle.TabIndex = 9;
            this.buttonaktorekle.Text = "Ekle";
            this.buttonaktorekle.UseVisualStyleBackColor = true;
            // 
            // buttonaktorgncl
            // 
            this.buttonaktorgncl.Location = new System.Drawing.Point(30, 167);
            this.buttonaktorgncl.Name = "buttonaktorgncl";
            this.buttonaktorgncl.Size = new System.Drawing.Size(75, 23);
            this.buttonaktorgncl.TabIndex = 8;
            this.buttonaktorgncl.Text = "Guncelle";
            this.buttonaktorgncl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPages.ResumeLayout(false);
            this.tabPages.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPages;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonlistele;
        private System.Windows.Forms.Button buttonguncelle;
        private System.Windows.Forms.Button buttonsil;
        private System.Windows.Forms.Button buttonekle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxfilmID;
        private System.Windows.Forms.TextBox textBoxfilmadı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxyonetid;
        private System.Windows.Forms.TextBox textBoxyonetmenad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonyonetsil;
        private System.Windows.Forms.Button buttonyontlistele;
        private System.Windows.Forms.Button buttonyntekle;
        private System.Windows.Forms.Button buttonyntgunc;
        private System.Windows.Forms.TextBox textBoxaktorid;
        private System.Windows.Forms.TextBox textBoxaktoradı;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonaktorsil;
        private System.Windows.Forms.Button buttonaktorlistle;
        private System.Windows.Forms.Button buttonaktorekle;
        private System.Windows.Forms.Button buttonaktorgncl;
    }
}

