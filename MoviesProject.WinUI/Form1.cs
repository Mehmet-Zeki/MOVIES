using FilmProject.bll.Repository;
using MoviesProject.dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MoviesProject.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Aktor aktor = new Aktor();
        Yonetmen yonetmen = new Yonetmen();
        Film film = new Film();
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void Temizle()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox t = (TextBox)item;
                    t.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox c = (ComboBox)item;
                    c.Items.Clear();
                }


            }
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxfilmadı.Text))
            {
                MessageBox.Show("Film Adi Boş geçilemez");
                return;
            }
            film.Insert(new dal.tblFilm
            {
                FilmName = textBoxfilmadı.Text,
                FilmReleaseDate=dateTimePicker1.Value,
                FilmDirectorID=comboBox1.SelectedIndex,
                FilmID=Convert.ToInt32(textBoxfilmID.Text)
            }) ;
            Temizle();
            dataGridView1.DataSource = film.SelectAll();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow!=null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                film.Delete(id);
                dataGridView1.DataSource = film.SelectAll();

            }
            else
            {
                MessageBox.Show("Lütfen seçim yapınız");
            }
        }

        private void buttonlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = film.SelectAll();
        }
        tblFilm filmupdate;
        //tbl film cinsinden yeni bir parametre aldık
        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxfilmadı.Text))
            {
                MessageBox.Show("Film Adı Boş geçilemez");
                return;

            }
            if (string.IsNullOrEmpty(textBoxfilmID.Text))
            {
                MessageBox.Show("Film ID si Boş geçilemez");
                return;

            }
            filmupdate.FilmName=textBoxfilmadı.Text;
            filmupdate.FilmReleaseDate = dateTimePicker1.Value;
            filmupdate.FilmID = Convert.ToInt32(textBoxfilmID.Text);
            dataGridView1.DataSource = film.SelectAll();
            Temizle();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            filmupdate = film.SelectbyID(id);
            textBoxfilmadı.Text = filmupdate.FilmName;
            dateTimePicker1.Value = filmupdate.FilmReleaseDate.Value;
            comboBox1.SelectedItem = filmupdate.FilmDirectorID;
            textBoxfilmID.Text = filmupdate.FilmID.ToString();
        }
    }
}
