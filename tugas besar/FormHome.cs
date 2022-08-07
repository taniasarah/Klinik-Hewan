using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_besar
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            var data1 = db.pelayanans.Select(row => new
            {
                row.Id,
                row.jenis_pelayanan,
                row.nama_pelayanan,
                row.dokter.nama_dokter
            }).ToList();

            pelayanandataGridView1.DataSource = data1;

            var data2 = db.dokters.Select(row => new
            {
                row.nama_dokter,
                row.id_pdhi,
                row.spesialis,

            }).ToList();
            dokterdataGridView1.DataSource = data2;

            var data3 = db.transaksis.Select(row => new
            {
                row.id_user,
                row.daftar.nama,
                row.jenis_hewan,
                row.umur,
                row.id_pelayanan,
                row.pelayanan.nama_pelayanan,
                row.tanggal


            }).ToList();
            transaksidataGridView1.DataSource = data3;

            panelmenuhome.Show();
            panelmenupelayanan.Hide();
            panelmenudoktor.Hide();
            panelmenudaftar.Hide();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            panelhome.Height = Homebtn.Height;
            panelhome.Top = Homebtn.Top;
            panelmenuhome.Visible = true;
            panelmenupelayanan.Visible = false;
            panelmenudoktor.Visible = false;
            panelmenudaftar.Visible = false;


        }

        private void Pelayananbtn_Click(object sender, EventArgs e)
        {
            panelpelayanan.Height = Pelayananbtn.Height;
            panelpelayanan.Top = Pelayananbtn.Top;
            panelmenupelayanan.Visible = true;
            panelmenuhome.Visible = false;
            panelmenudoktor.Visible = false;
            panelmenudaftar.Visible = false;
        }

        private void Dokterbtn_Click(object sender, EventArgs e)
        {
            paneldokter.Height = Dokterbtn.Height;
            paneldokter.Top = Dokterbtn.Top;
            panelmenupelayanan.Visible = false;
            panelmenuhome.Visible = false;
            panelmenudoktor.Visible = true;
            panelmenudaftar.Visible = false;
        }

        private void Daftarbtn_Click(object sender, EventArgs e)
        {
            paneldaftar.Height = paneldaftar.Height;
            paneldaftar.Top = paneldaftar.Top;
            panelmenupelayanan.Visible = false;
            panelmenuhome.Visible = false;
            panelmenudoktor.Visible = false;
            panelmenudaftar.Visible = false;
            panelmenudaftar.Visible = true;

        }

        private void panelmenupelayanan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelmenupelayanan.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panelmenudoktor.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelmenudaftar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pelayanandataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void pelayanandataGridView1_DoubleClick(object sender, EventArgs e)
        {
            pelayanan layan = new pelayanan();
            if (pelayanandataGridView1.CurrentRow.Index != -1)
            {
                layan.jenis_pelayanan = Convert.ToString(pelayanandataGridView1.CurrentRow.Cells["jenis_pelayanan"].Value);
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    layan = db.pelayanans.Where(a => a.jenis_pelayanan == layan.jenis_pelayanan).FirstOrDefault();
                    textBox1.Text = layan.jenis_pelayanan;
                    textBox2.Text = layan.nama_pelayanan;
                    textBox3.Text = layan.dokter.nama_dokter;
                }
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void dokterdataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dokter ter = new dokter();
            if (dokterdataGridView1.CurrentRow.Index != 1)
            {
                ter.nama_dokter = Convert.ToString(dokterdataGridView1.CurrentRow.Cells["nama_dokter"].Value);
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    ter = db.dokters.Where(a => a.nama_dokter == ter.nama_dokter).FirstOrDefault();
                    textBox6.Text = ter.nama_dokter;
                    textBox5.Text = ter.id_pdhi;
                    textBox4.Text = ter.spesialis;


                }
            }
           
        }

        private void clear()
        {
            textBox9.Text = textBox7.Text = textBox8.Text;
        }
        private void InsertTransaksi_Click(object sender, EventArgs e)
        {
            

            if (textBox9.Text == "" && textBox7.Text == "" && textBox8.Text == "" && textBox10.Text == "")
            {
                MessageBox.Show("Input Data Gagal", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                transaksi saksi = new transaksi();
                saksi.id_user = Convert.ToInt32(textBox9.Text);
                saksi.jenis_hewan = textBox7.Text;
                saksi.umur = textBox8.Text;
                saksi.id_pelayanan = Convert.ToInt32(textBox10.Text);
                saksi.tanggal = dateTimePicker1.Value;
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    db.transaksis.Add(saksi);
                    db.SaveChanges();

                    var data_user = db.transaksis.Select(row => new
                    {
                        row.id_user,
                        row.jenis_hewan,
                        row.umur,
                        row.id_pelayanan,
                        row.tanggal
                    }).ToList();

                    transaksidataGridView1.DataSource = data_user;
                }

                
                MessageBox.Show("Input Data Berhasil", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clear();

            }
        }
    }
}


