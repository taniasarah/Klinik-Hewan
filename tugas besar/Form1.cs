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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string report;

        public Form1(string n)
            : this()
        {
            report = n; 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseSIDokterHewanEntities1 db = new DatabaseSIDokterHewanEntities1();
            if (report == "daftar")
            {
                CrystalReportDaftar df = new CrystalReportDaftar();
                df.SetDataSource(db.daftars.Select(d => new
                {
                    Id = d.Id,
                    nama = d.nama,
                    username = d.username,
                    password = d.password
    
                }));
                crystalReportViewer1.ReportSource = df;
            }
            else if(report == "dokter")
            {
                CrystalReportDokter dr = new CrystalReportDokter();
                dr.SetDataSource(db.dokters.Select(c => new
                {
                    Id = c.Id,
                    nama_dokter = c.nama_dokter,
                    id_pdhi = c.id_pdhi,
                    spesialis = c.spesialis
                }));
                crystalReportViewer1.ReportSource = dr;
            }
            else if(report == "pelayanan")
            {
                CrystalReportPelayanan pl = new CrystalReportPelayanan();
                pl.SetDataSource(db.pelayanans.Select(p => new
                {
                    Id = p.Id,
                    jenis_pelayanan = p.jenis_pelayanan,
                    nama_pelayanan = p.nama_pelayanan,
                    id_dokter = p.id_dokter,
                }));
                crystalReportViewer1.ReportSource = pl;
            }
            else if(report == "transaksi")
            {
                CrystalReportTransaksis ts = new CrystalReportTransaksis();
                ts.SetDataSource(db.transaksis.Select(t => new
                {
                    id_user = t.id_user,
                    jenis_hewan = t.jenis_hewan,
                    umur = t.umur,
                    id_pelayanan = t.id_pelayanan,
                    tanggal = t.tanggal
                }));
                crystalReportViewer1.ReportSource = ts;
            }
        }
    }
}
