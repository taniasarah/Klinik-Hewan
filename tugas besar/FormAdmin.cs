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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            var data = db.daftars.Select(row => new
            {
                row.Id,
                row.nama,
                row.username,
                row.password
            }).ToList();
            useradmindataGridView1.DataSource = data;


            var data_trans = db.transaksis.Select(row => new
            {
                row.id_user,
                row.daftar.nama,
                row.jenis_hewan,
                row.umur,
                row.id_pelayanan,
                row.pelayanan.nama_pelayanan,
                row.tanggal
            }).ToList();
            datauser_admindataGridView.DataSource = data_trans;

            var data_dokter = db.dokters.Select(row => new
            {
                row.Id,
                row.nama_dokter,
                row.id_pdhi,
                row.spesialis,

            }).ToList();
            dokter_admindataGridView.DataSource = data_dokter;

            var data_pelayanan = db.pelayanans.Select(row => new
            {
                row.Id,
                row.jenis_pelayanan,
                row.nama_pelayanan,
                row.id_dokter,
                row.dokter.nama_dokter,

            }).ToList();
            pelayananadmin_dataGridView.DataSource = data_pelayanan;




            panelmenuhome.Show();
            panelmenuadminuser.Hide();
            panelmenuadmin_dokter.Hide();
            panelmenuadmin_pelayanan.Hide();
           
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
           
            panelmenuhome.Visible = true;
            panelmenuadminuser.Visible = false;
            panelmenuadmin_dokter.Visible = false;
            panelmenuadmin_pelayanan.Visible = false;
           
          
        }

        private void userbtn_Click(object sender, EventArgs e)
        {
            panelmenuhome.Visible = false;
            panelmenuadminuser.Visible = true;
            panelmenuadmin_dokter.Visible = false;
            panelmenuadmin_pelayanan.Visible = false;
        }

       

        private void Dokterbtn_Click(object sender, EventArgs e)
        {
            panelmenuhome.Visible = false;
            panelmenuadminuser.Visible = false;
            panelmenuadmin_dokter.Visible = true;
            panelmenuadmin_pelayanan.Visible = false;
        }

        private void Pelayananbtn_Click(object sender, EventArgs e)
        {
            panelmenuhome.Visible = false;
            panelmenuadminuser.Visible = false;
            panelmenuadmin_dokter.Visible = false;
            panelmenuadmin_pelayanan.Visible = true;
        }



        private void useradmin_Click(object sender, EventArgs e)
        {
            panelmenuadminuser.Show();
        }

      

        private void dokteradmin_Click(object sender, EventArgs e)
        {
            panelmenuadmin_dokter.Show();
        }

        private void pelayananadmin_Click(object sender, EventArgs e)
        {
            panelmenuadmin_pelayanan.Show();
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

        private void label12_Click(object sender, EventArgs e)
        {

        }
      
        private void useradmindataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void useradmindataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            daftar masuk = new daftar();
            if (useradmindataGridView1.CurrentRow.Index != 1)
            {
                masuk.nama = Convert.ToString(useradmindataGridView1.CurrentRow.Cells["nama"].Value);
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    masuk = db.daftars.Where(s => s.nama == masuk.nama).FirstOrDefault();
                    textBox1.Text = masuk.Id.ToString();
                    textBox2.Text = masuk.nama;
                    textBox3.Text = masuk.username;
                    textBox4.Text = masuk.password;
                }
            }
        }

        private void clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = textBox11.Text = textBox12.Text =
            textBox13.Text = textBox15.Text = textBox16.Text = textBox17.Text = "";
            
        }

        private void Insertbtnadminuser_Click(object sender, EventArgs e)
        {
            daftar user = new daftar();
            //user.Id = Convert.ToInt32 (textBox1.Text);
            user.nama = textBox2.Text;
            user.username = textBox3.Text;
            user.password = textBox4.Text;

            using(DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
            {
                db.daftars.Add(user);
                db.SaveChanges();

                var data_user = db.daftars.Select(row => new
                {
                    row.Id,
                    row.nama,
                    row.username,
                    row.password
                }).ToList();
                useradmindataGridView1.DataSource = data_user;
            }
            MessageBox.Show("Data Berhasil Dimasukkan!", "Success");
            clear();
        }

        private void Updatebtnadminuser_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            daftar user = db.daftars.SingleOrDefault(u => u.Id.ToString() == textBox1.Text);

            //user.Id = Convert.ToInt32(textBox1.Text);
            user.nama = textBox2.Text;
            user.username = textBox3.Text;
            user.password = textBox4.Text;

            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            var data_user = db.daftars.Select(row => new
            {
                row.Id,
                row.nama,
                row.username,
                row.password
            }).ToList();
            useradmindataGridView1.DataSource = data_user;

            MessageBox.Show("Data Berhasil DiUpdate!", "Success");
            clear();
        }

        private void Deletebtnadminuser_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            daftar user = db.daftars.SingleOrDefault(u => u.Id.ToString() == textBox1.Text);

            db.daftars.Remove(user);
            db.SaveChanges();

            var data_user = db.daftars.Select(row => new
            {
                row.Id,
                row.nama,
                row.username,
                row.password
            }).ToList();
            useradmindataGridView1.DataSource = data_user;

            MessageBox.Show("Data Berhasil Dihapus!", "Success");
            clear();
        }

        private void cariuseradminbtn_Click(object sender, EventArgs e)
        {
            /*DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            string cari = cariuseradmintextBox.Text;
            string pilih = cariuseradmincomboBox.SelectedItem.ToString();

            if (pilih == "Semua")
            {
                cariuseradmintextBox.Clear();
                var semua = db.daftars.Select(row => new
                {
                    row.Id,
                    row.nama,
                    row.username,
                    row.password
                }).ToList();

                useradmindataGridView1.DataSource = semua;
            }
            else if (pilih == "Nama")
            {
                cariuseradmintextBox.Clear();
                var nama = db.daftars.Where(n => n.nama == pilih).Select(row => new
                {
                    row.Id,
                    row.nama,
                    row.username,
                    row.password
                }).ToList();

                useradmindataGridView1.DataSource = nama;
            }
            else if (pilih == "Username")
            {
                cariuseradmintextBox.Clear();
                var user = db.daftars.Where(us => us.username == pilih).Select(row => new
                {
                    row.Id,
                    row.nama,
                    row.username,
                    row.password
                }).ToList();

                useradmindataGridView1.DataSource = user;
            }
            else if (pilih == "Password")
            {
                cariuseradmintextBox.Clear();
                var pass = db.daftars.Where(p => p.password == pilih).Select(row => new
                {
                    row.Id,
                    row.nama,
                    row.username,
                    row.password
                }).ToList();

                useradmindataGridView1.DataSource = pass;
            }*/
        }

        string report;

        private void cetakuser_admin_Click(object sender, EventArgs e)
        {
            report = "daftar";
            Form1 cetak = new Form1(report);
            cetak.Show();
        }

        private void datauser_admindataGridView_DoubleClick(object sender, EventArgs e)
        {
            transaksi user = new transaksi();
            if (datauser_admindataGridView.CurrentRow.Index != 1)
            {
                user.jenis_hewan = Convert.ToString(datauser_admindataGridView.CurrentRow.Cells["jenis_hewan"].Value);
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    user = db.transaksis.Where(t => t.jenis_hewan == user.jenis_hewan).FirstOrDefault();
                    textBox5.Text = user.id_user.ToString();
                    textBox7.Text = user.jenis_hewan;
                    textBox9.Text = user.umur;
                    textBox8.Text = user.id_pelayanan.ToString();
                }
            }
        }

        private void Insertbtn_dua_Click(object sender, EventArgs e)
        {
            transaksi user = new transaksi();
            user.id_user = Convert.ToInt32(textBox5.Text);
            user.jenis_hewan = textBox7.Text;
            user.umur = textBox9.Text;
            user.id_pelayanan = Convert.ToInt32(textBox8.Text);
            user.tanggal = dateTimePicker1.Value;

            using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
            {
                db.transaksis.Add(user);
                db.SaveChanges();

                var data_trans = db.transaksis.Select(row => new
                {
                    row.id_user,
                    row.daftar.nama,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan,
                    row.tanggal
                }).ToList();
                datauser_admindataGridView.DataSource = data_trans;
            }
            MessageBox.Show("Data Berhasil Dimasukkan!", "Success");
            clear();
        }

        private void Updatebtn_dua_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            transaksi user = db.transaksis.SingleOrDefault(ts => ts.id_user.ToString() == textBox5.Text);

            user.id_user = Convert.ToInt32(textBox5.Text);
            user.jenis_hewan = textBox7.Text;
            user.umur = textBox9.Text;
            user.id_pelayanan = Convert.ToInt32(textBox8.Text);
            user.tanggal = dateTimePicker1.Value;

            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            var data_trans = db.transaksis.Select(row => new
            {
                row.id_user,
                row.daftar.nama,
                row.jenis_hewan,
                row.umur,
                row.id_pelayanan,
                row.pelayanan.nama_pelayanan,
                row.tanggal
            }).ToList();
            datauser_admindataGridView.DataSource = data_trans;

            MessageBox.Show("Data Berhasil DiUpdate!", "Success");
            clear();
        }

        private void Deletebtn_dua_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            transaksi user = db.transaksis.SingleOrDefault(ts => ts.id_user.ToString() == textBox5.Text);

            db.transaksis.Remove(user);
            db.SaveChanges();

            var data_trans = db.transaksis.Select(row => new
            {
                row.id_user,
                row.daftar.nama,
                row.jenis_hewan,
                row.umur,
                row.id_pelayanan,
                row.pelayanan.nama_pelayanan,
                row.tanggal
            }).ToList();
            datauser_admindataGridView.DataSource = data_trans;

            MessageBox.Show("Data Berhasil Dihapus!", "Success");
            clear();
        }

        private void Caribtn_dua_Click(object sender, EventArgs e)
        {
           /* DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            string cari = datauser_admintextBox.Text;
            string pilih = datauser_admincomboBox.SelectedItem.ToString();

            if (pilih == "Semua")
            {
                datauser_admintextBox.Clear();
                var semua = db.transaksis.Select(row => new
                {
                    row.daftar.nama,
                    row.id_user,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan

                }).ToList();

                datauser_admindataGridView.DataSource = semua;
            }
            else if(pilih == "Id User")
            {
                datauser_admintextBox.Clear();
                var id = db.transaksis.Where(i => i.id_user.ToString() == pilih).Select(row => new
                {
                    row.daftar.nama,
                    row.id_user,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan

                }).ToList();

                datauser_admindataGridView.DataSource = id;
            }
            else if (pilih == "Nama")
            {
                datauser_admintextBox.Clear();
                var nama = db.transaksis.Where(n => n.daftar.nama == pilih).Select(row => new
                {
                    row.daftar.nama,
                    row.id_user,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan

                }).ToList();

                datauser_admindataGridView.DataSource = nama;
            }
            else if (pilih == "Jenis Hewan")
            {
                datauser_admintextBox.Clear();
                var jenis = db.transaksis.Where(j => j.jenis_hewan == pilih).Select(row => new
                {
                    row.daftar.nama,
                    row.id_user,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan

                }).ToList();

                datauser_admindataGridView.DataSource = jenis;
            }
            else if (pilih == "Umur")
            {
                datauser_admintextBox.Clear();
                var umur = db.transaksis.Where(u => u.umur == pilih).Select(row => new
                {
                    row.daftar.nama,
                    row.id_user,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan

                }).ToList();

                datauser_admindataGridView.DataSource = umur;
            }
            else if (pilih == "Id Pelayanan")
            {
                datauser_admintextBox.Clear();
                var pel = db.transaksis.Where(p => p.id_pelayanan.ToString() == pilih).Select(row => new
                {
                    row.daftar.nama,
                    row.id_user,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan

                }).ToList();

                datauser_admindataGridView.DataSource = pel;
            }
            else if (pilih == "Pelayanan")
            {
                datauser_admintextBox.Clear();
                var layan= db.transaksis.Where(l => l.pelayanan.nama_pelayanan == pilih).Select(row => new
                {
                    row.daftar.nama,
                    row.id_user,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan

                }).ToList();

                datauser_admindataGridView.DataSource = layan;
            }*/
        }

        private void Cetakbtn_dua_Click(object sender, EventArgs e)
        {
            report = "transaksi";
            Form1 cetak = new Form1(report);
            cetak.Show();
        }

        private void dokter_admindataGridView_DoubleClick(object sender, EventArgs e)
        {
            dokter dok = new dokter();
            if (dokter_admindataGridView.CurrentRow.Index != 1)
            {
                dok.nama_dokter = Convert.ToString(dokter_admindataGridView.CurrentRow.Cells["nama_dokter"].Value);
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    dok = db.dokters.Where(d => d.nama_dokter  == dok.nama_dokter).FirstOrDefault();
                    //textBox6.Text = dok.Id.ToString();
                    textBox11.Text = dok.nama_dokter;
                    textBox13.Text = dok.id_pdhi;
                    textBox12.Text = dok.spesialis;
                }
            }
        }

        private void Inserbtndokter_admin_Click(object sender, EventArgs e)
        {
            dokter dok = new dokter();
            //dok.Id = Convert.ToInt32(textBox6.Text);
            dok.nama_dokter = textBox11.Text;
            dok.id_pdhi = textBox13.Text;
            dok.spesialis = textBox12.Text;

            using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
            {
                db.dokters.Add(dok);
                db.SaveChanges();

                var data_dokter = db.dokters.Select(row => new
                {
                    row.Id,
                    row.nama_dokter,
                    row.id_pdhi,
                    row.spesialis,

                }).ToList();
                dokter_admindataGridView.DataSource = data_dokter;
            }
            MessageBox.Show("Data Berhasil Dimasukkan!", "Success");
            clear();
        }

        private void Updatebtndokter_admin_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            dokter dok = db.dokters.SingleOrDefault(d => d.id_pdhi.ToString() == textBox13.Text);

            //dok.Id = Convert.ToInt32(textBox6.Text);
            dok.nama_dokter = textBox11.Text;
            dok.id_pdhi = textBox13.Text;
            dok.spesialis = textBox12.Text;

            db.Entry(dok).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            var data_dokter = db.dokters.Select(row => new
            {
                row.Id,
                row.nama_dokter,
                row.id_pdhi,
                row.spesialis,

            }).ToList();
            dokter_admindataGridView.DataSource = data_dokter;

            MessageBox.Show("Data Berhasil DiUpdate!", "Success");
            clear();
        }

        private void Deletebtndokter_admin_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            dokter dok = db.dokters.SingleOrDefault(d => d.id_pdhi.ToString() == textBox13.Text);

            db.dokters.Remove(dok);
            db.SaveChanges();

            var data_dokter = db.dokters.Select(row => new
            {
                row.Id,
                row.nama_dokter,
                row.id_pdhi,
                row.spesialis,

            }).ToList();
            dokter_admindataGridView.DataSource = data_dokter;

            MessageBox.Show("Data Berhasil Dihapus!", "Success");
            clear();
        }

        private void Cetakbtndokter_admin_Click(object sender, EventArgs e)
        {
            report = "dokter";
            Form1 cetak = new Form1(report);
            cetak.Show();
        }

        private void pelayananadmin_dataGridView_DoubleClick(object sender, EventArgs e)
        {
            pelayanan layan = new pelayanan();
            if (pelayananadmin_dataGridView.CurrentRow.Index != 1)
            {
                layan.Id = Convert.ToInt32(pelayananadmin_dataGridView.CurrentRow.Cells["Id"].Value);
                using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    layan = db.pelayanans.Where(l => l.Id == layan.Id).FirstOrDefault();
                    textBox10.Text = layan.Id.ToString();
                    textBox15.Text = layan.jenis_pelayanan;
                    textBox17.Text = layan.nama_pelayanan;
                    textBox16.Text = layan.id_dokter.ToString();   
                }
            }
        }

        private void Insertbtnpelayanan_admin_Click(object sender, EventArgs e)
        {
            pelayanan layan = new pelayanan();
            layan.Id = Convert.ToInt32(textBox10.Text);
            layan.jenis_pelayanan = textBox15.Text;
            layan.nama_pelayanan = textBox17.Text;
            layan.id_dokter = Convert.ToInt32(textBox16.Text);

            using (DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
            {
                db.pelayanans.Add(layan);
                db.SaveChanges();

                var data_pelayanan = db.pelayanans.Select(row => new
                {
                    row.Id,
                    row.jenis_pelayanan,
                    row.nama_pelayanan,
                    row.id_dokter,
                    row.dokter.nama_dokter,

                }).ToList();
                pelayananadmin_dataGridView.DataSource = data_pelayanan;
            }
            MessageBox.Show("Data Berhasil Dimasukkan!", "Success");
            clear();
        }

        private void Updatebtnpelayanan_admin_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            pelayanan layan = db.pelayanans.SingleOrDefault(p => p.Id.ToString() == textBox10.Text);

            //layan.Id = Convert.ToInt32(textBox10.Text);
            layan.jenis_pelayanan = textBox15.Text;
            layan.nama_pelayanan = textBox17.Text;
            layan.id_dokter = Convert.ToInt32(textBox16.Text);

            db.Entry(layan).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            var data_pelayanan = db.pelayanans.Select(row => new
            {
                row.Id,
                row.jenis_pelayanan,
                row.nama_pelayanan,
                row.id_dokter,
                row.dokter.nama_dokter,

            }).ToList();
            pelayananadmin_dataGridView.DataSource = data_pelayanan;

            MessageBox.Show("Data Berhasil DiUpdate!", "Success");
            clear();
        }

        private void Deletebtnpelayanan_admin_Click(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            pelayanan layan = db.pelayanans.SingleOrDefault(p => p.Id.ToString() == textBox10.Text);

            db.pelayanans.Remove(layan);
            db.SaveChanges();

            var data_pelayanan = db.pelayanans.Select(row => new
            {
                row.Id,
                row.jenis_pelayanan,
                row.nama_pelayanan,
                row.id_dokter,
                row.dokter.nama_dokter,

            }).ToList();
            pelayananadmin_dataGridView.DataSource = data_pelayanan;

            MessageBox.Show("Data Berhasil Dihapus!", "Success");
            clear();
        }

        private void Cetakbtnpelayanan_admin_Click(object sender, EventArgs e)
        {
            report = "pelayanan";
            Form1 cetak = new Form1(report);
            cetak.Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void pelayanancari_admintextBox_TextChanged(object sender, EventArgs e)
        {
            if(pelayanancari_admintextBox.Text != "")
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var layan = db.pelayanans.Where(l => l.Id.ToString().Contains(pelayanancari_admintextBox.Text) || l.jenis_pelayanan.Contains(pelayanancari_admintextBox.Text)
                || l.nama_pelayanan.Contains(pelayanancari_admintextBox.Text) || l.id_dokter.ToString().Contains(pelayanancari_admintextBox.Text) || 
                l.dokter.nama_dokter.Contains(pelayanancari_admintextBox.Text)).Select(row => new
                {
                    row.Id,
                    row.jenis_pelayanan,
                    row.nama_pelayanan,
                    row.id_dokter,
                    row.dokter.nama_dokter,

                }).ToList();
                
                if(layan != null)
                {
                    pelayananadmin_dataGridView.DataSource = layan;
                }
            }
            else
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var data_pelayanan = db.pelayanans.Select(row => new
                {
                    row.Id,
                    row.jenis_pelayanan,
                    row.nama_pelayanan,
                    row.id_dokter,
                    row.dokter.nama_dokter,

                }).ToList();
                pelayananadmin_dataGridView.DataSource = data_pelayanan;
            }
        }

        private void caridokter_admintextBox_TextChanged(object sender, EventArgs e)
        {
            if(caridokter_admintextBox.Text != "")
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var dokter = db.dokters.Where(d => d.Id.ToString().Contains(caridokter_admintextBox.Text) || d.nama_dokter.Contains(caridokter_admintextBox.Text)
               || d.id_pdhi.Contains(caridokter_admintextBox.Text) || d.spesialis.Contains(caridokter_admintextBox.Text)).Select(row => new
               {
                   row.Id,
                   row.nama_dokter,
                   row.id_pdhi,
                   row.spesialis,
               }).ToList();

                if (dokter != null)
                {
                    dokter_admindataGridView.DataSource = dokter;
                }
            }
            else
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var data_dokter = db.dokters.Select(row => new
                {
                    row.Id,
                    row.nama_dokter,
                    row.id_pdhi,
                    row.spesialis,

                }).ToList();
                dokter_admindataGridView.DataSource = data_dokter;
            }
        }

        private void cariuseradmintextBox_TextChanged(object sender, EventArgs e)
        {
            if (cariuseradmintextBox.Text != "")
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var user = db.daftars.Where(u => u.Id.ToString().Contains(cariuseradmintextBox.Text) || u.nama.Contains(cariuseradmintextBox.Text)
               || u.username.Contains(cariuseradmintextBox.Text) || u.password.Contains(cariuseradmintextBox.Text)).Select(row => new
               {
                   row.Id,
                   row.nama,
                   row.username,
                   row.password
               }).ToList();

                if (user != null)
                {
                    useradmindataGridView1.DataSource = user;
                }
            }
            else
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var user = db.daftars.Select(row => new
                {
                    row.Id,
                    row.nama,
                    row.username,
                    row.password

                }).ToList();
                useradmindataGridView1.DataSource = user;
            }
        }

        private void datauser_admintextBox_TextChanged(object sender, EventArgs e)
        {
            if (datauser_admintextBox.Text != "")
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var data_user = db.transaksis.Where(s => s.id_user.ToString().Contains(datauser_admintextBox.Text) || s.daftar.nama.Contains(datauser_admintextBox.Text)
               || s.jenis_hewan.Contains(datauser_admintextBox.Text) || s.umur.Contains(datauser_admintextBox.Text) || s.id_pelayanan.ToString().Contains(datauser_admintextBox.Text)
               || s.pelayanan.nama_pelayanan.Contains(datauser_admintextBox.Text) || s.tanggal.ToString().Contains(datauser_admintextBox.Text)).Select(row => new
               {
                   row.id_user,
                   row.daftar.nama,
                   row.jenis_hewan,
                   row.umur,
                   row.id_pelayanan,
                   row.pelayanan.nama_pelayanan,
                   row.tanggal
               }).ToList();

                if (data_user != null)
                {
                    datauser_admindataGridView.DataSource = data_user;
                }
            }
            else
            {
                DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
                var data_user = db.transaksis.Select(row => new
                {
                    row.id_user,
                    row.daftar.nama,
                    row.jenis_hewan,
                    row.umur,
                    row.id_pelayanan,
                    row.pelayanan.nama_pelayanan,
                    row.tanggal

                }).ToList();
                datauser_admindataGridView.DataSource = data_user;
            }
        }
    }
}
