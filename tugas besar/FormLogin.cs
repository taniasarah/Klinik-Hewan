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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Nama_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(204, 204, 0);
            Nama.ForeColor = Color.FromArgb(204, 204, 0);

            panel2.BackColor = Color.Black;
            Password.ForeColor = Color.Black;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
           
            panel2.BackColor = Color.FromArgb(204, 204, 0);
            Nama.ForeColor = Color.FromArgb(204, 204, 0);

            panel1.BackColor = Color.Black;
            Nama.ForeColor = Color.Black;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();

            daftar user = new daftar();

            if(Nama.Text == "" && Password.Text == "")
            {
                String message = "Username dan Password Tidak Boleh Kosong";
                String title = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon Icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, buttons, Icon);
            }
            else if (Nama.Text == "")
            {
                String message = "Username Tidak Boleh Kosong";
                String title = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon Icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, buttons, Icon);
            }
            else if (Password.Text == "")
            {
                String message = "Password Tidak Boleh Kosong";
                String title = "Warning";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon Icon = MessageBoxIcon.Error;
                MessageBox.Show(message, title, buttons, Icon);
            }
            else if (Nama.Text == "admin" && Password.Text == "admin")
            {
                FormAdmin admin = new FormAdmin();
                admin.Show();
                this.Hide();
            }
            else if(Nama.Text == "dokter" && Password.Text == "dokter")
            {
                FormDokter dokter = new FormDokter();
                dokter.Show();
                this.Hide();
            }
            else
            {
                Cursor = Cursors.AppStarting;

                var login = (from s in db.daftars
                             where s.username == Nama.Text
                             select s).FirstOrDefault();

                FormHome home = new FormHome();
                home.Show();
                this.Hide();

                String message = "Selamat Datang Di Klinik Hewan";
                String title = "Welcome";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon Icon = MessageBoxIcon.Information;
                MessageBox.Show(message, title, buttons, Icon);

            }
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            FormRegis regis = new FormRegis();
            regis.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if(WindowState == FormWindowState.Normal)
           {
                WindowState = FormWindowState.Maximized;
           }
           else if(WindowState == FormWindowState.Maximized)
           {
               WindowState = FormWindowState.Normal;
           }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Nama_Enter(object sender, EventArgs e)
        {
            /*if (Nama.Text == "Username")
            {
                Nama.Text = "";
            }*/
        }

        private void Nama_Leave(object sender, EventArgs e)
        {
            /*if (Nama.Text == "")
            {
                Nama.Text = "Username";
            }*/
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            /*if (Password.Text == "Password")
            {
                Password.Text = "";
            }*/
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            /*if (Password.Text == "")
            {
                Password.Text = "Password";
            }*/
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Password.UseSystemPasswordChar = false;
            }
            else
            {
                Password.UseSystemPasswordChar = true;
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
