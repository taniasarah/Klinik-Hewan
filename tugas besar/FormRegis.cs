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
    public partial class FormRegis : Form
    {
        public FormRegis()
        {
            InitializeComponent();
        }

        private void FormRegis_Load(object sender, EventArgs e)
        {

        }

        private void NamaRgs_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(204, 204, 0);
            NamaRgs.ForeColor = Color.FromArgb(204, 204, 0);

            panel2.BackColor = Color.Black;
            UsernameRgs.ForeColor = Color.Black;

            panel3.BackColor = Color.Black;
            PassRgs.ForeColor = Color.Black;
        }

        private void UsernameRgs_TextChanged(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(204, 204, 0);
            UsernameRgs.ForeColor = Color.FromArgb(204, 204, 0);

            panel1.BackColor = Color.Black;
            NamaRgs.ForeColor = Color.Black;

            panel3.BackColor = Color.Black;
            PassRgs.ForeColor = Color.Black;
        }

        private void PassRgs_TextChanged(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(204, 204, 0);
            PassRgs.ForeColor = Color.FromArgb(204, 204, 0);

            panel2.BackColor = Color.Black;
            UsernameRgs.ForeColor = Color.Black;

            panel1.BackColor = Color.Black;
            NamaRgs.ForeColor = Color.Black;
        }

        private void OkRgs_Click(object sender, EventArgs e)
        {
            if(NamaRgs.Text == "" || UsernameRgs.Text == "" || PassRgs.Text == "")
            {
                MessageBox.Show("Silahkan isi Nama atau Username atau Password!!!");
            }
            else
            {
                daftar daf = new daftar();
                daf.nama = NamaRgs.Text;
                daf.username = UsernameRgs.Text;
                daf.password = PassRgs.Text;
                using(DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1())
                {
                    db.daftars.Add(daf);
                    db.SaveChanges();
                }
                FormHome home = new FormHome();
                home.Show();
                this.Hide();

                string message = "Selamat Datang Di Klinik Hewan";
                String title = "Welcome";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon Icon = MessageBoxIcon.Information;
                MessageBox.Show(message, title, buttons, Icon);
            }
        }

        private void NamaRgs_Enter(object sender, EventArgs e)
        {
            if (NamaRgs.Text == "Nama")
            {
                NamaRgs.Text = "";
            }
        }

        private void NamaRgs_Leave(object sender, EventArgs e)
        {
            if (NamaRgs.Text == "")
            {
                NamaRgs.Text = "Nama";
            }
        }

        private void UsernameRgs_Enter(object sender, EventArgs e)
        {
            if (UsernameRgs.Text == "Username")
            {
                UsernameRgs.Text = "";
            }
        }

        private void UsernameRgs_Leave(object sender, EventArgs e)
        {
            if (UsernameRgs.Text == "")
            {
                UsernameRgs.Text = "Username";
            }
        }

        private void PassRgs_Enter(object sender, EventArgs e)
        {
            if (PassRgs.Text == "Password")
            {
                PassRgs.Text = "";
            }
        }

        private void PassRgs_Leave(object sender, EventArgs e)
        {
            if (PassRgs.Text == "")
            {
                PassRgs.Text = "Password";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin frm1 = new FormLogin();
            frm1.Show();
            this.Hide();
        }

        
    }
}
