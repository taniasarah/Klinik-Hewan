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
    public partial class FormDokter : Form
    {
        public FormDokter()
        {
            InitializeComponent();
        }

        private void FormDokter_Load(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            var data_user = db.transaksis.Select(row => new
            {
                row.id_user,
                row.daftar.nama,
                row.jenis_hewan,
                row.umur,
                row.pelayanan.nama_pelayanan,
                row.tanggal
            }).ToList();

            userdokter_dataGridView.DataSource = data_user;

            var data_dokter = db.dokters.Select(row => new
            {
                row.Id,
                row.nama_dokter,
                row.id_pdhi,
                row.spesialis

            }).ToList();

            dokter_dokterdataGridView.DataSource = data_dokter;

            panelmenuhome.Show();
            panelmenuuser_dokter.Hide();
            panelmenudokter_dokter.Hide();
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            panelmenuhome.Visible = true;
            panelmenuuser_dokter.Visible = false;
            panelmenudokter_dokter.Visible = false;
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            panelmenuhome.Visible = false;
            panelmenuuser_dokter.Visible = true;
            panelmenudokter_dokter.Visible = false;
        }

        private void Dokterbtn_Click(object sender, EventArgs e)
        {
            panelmenuhome.Visible = false;
            panelmenuuser_dokter.Visible = false;
            panelmenudokter_dokter.Visible = true;
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void menuuserbtn_Click(object sender, EventArgs e)
        {
            panelmenuuser_dokter.Show();
        }

        private void panelback_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void userdokter_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            transaksi trans = new transaksi();
            if (userdokter_dataGridView.CurrentRow.Index != -1)
            {
                trans.jenis_hewan = Convert.ToString(userdokter_dataGridView.CurrentRow.Cells["jenis_hewan"].Value);
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    trans = db.transaksis.Where(t => t.jenis_hewan == trans.jenis_hewan).FirstOrDefault();
                    textBox10.Text = trans.daftar.nama;
                    textBox15.Text = trans.jenis_hewan;
                    textBox17.Text = trans.umur;
                    textBox16.Text = trans.pelayanan.nama_pelayanan;
                }
            }
        }

        private void clear()
        {
            textBox1.Text = textBox3.Text = textBox5.Text = "";
        }

        private void Updatebtn_dokter_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            dokter dok = db.dokters.SingleOrDefault(d => d.id_pdhi == textBox3.Text);

            dok.nama_dokter = textBox1.Text;
            dok.id_pdhi = textBox3.Text;
            dok.spesialis = textBox5.Text;

            db.Entry(dok).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            var data_dokter = db.dokters.Select(row => new
            {
                row.Id,
                row.nama_dokter,
                row.id_pdhi,
                row.spesialis,

            }).ToList();

            dokter_dokterdataGridView.DataSource = data_dokter;

            MessageBox.Show("Data Berhasil DiUpdate!", "Success");
            clear();
        }

        private void dokter_dokterdataGridView_DoubleClick(object sender, EventArgs e)
        {
            dokter dok = new dokter();
            if (dokter_dokterdataGridView.CurrentRow.Index != -1)
            {
               dok.nama_dokter = Convert.ToString(dokter_dokterdataGridView.CurrentRow.Cells["nama_dokter"].Value);
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    dok = db.dokters.Where(d => d.nama_dokter == dok.nama_dokter).FirstOrDefault();
                    textBox1.Text = dok.nama_dokter;
                    textBox3.Text = dok.id_pdhi;
                    textBox5.Text = dok.spesialis;
                    
                }
            }
        }

        private void userdoktertextBox_TextChanged(object sender, EventArgs e)
        {
           if (userdoktertextBox.Text != "")
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var user = db.transaksis.Where(d => d.id_user.ToString().Contains(userdoktertextBox.Text) || d.daftar.nama.Contains(userdoktertextBox.Text)
               || d.jenis_hewan.Contains(userdoktertextBox.Text) || d.umur.Contains(userdoktertextBox.Text) 
               || d.pelayanan.nama_pelayanan.Contains(userdoktertextBox.Text)
               ).Select(row => new 
               {
                   row.id_user,
                   row.daftar.nama,
                   row.jenis_hewan,
                   row.umur,
                   row.pelayanan.nama_pelayanan,
                   row.tanggal
               }).ToList();

                if (user != null)
                {
                    userdokter_dataGridView.DataSource = user;
                }
            }
            else
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var user = db.transaksis.Select(row => new
                {
                    row.id_user,
                    row.daftar.nama,
                    row.jenis_hewan,
                    row.umur,
                    row.pelayanan.nama_pelayanan,
                    row.tanggal

                }).ToList();
                userdokter_dataGridView.DataSource = user;
            }
        }
    }
}
