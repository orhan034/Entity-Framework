using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategori.Count().ToString();
            label3.Text = db.Tbl_Urun.Count().ToString();   
            label5.Text = db.Tbl_Musteri.Count(x=>x.DURUM==true).ToString();
            label7.Text = db.Tbl_Musteri.Count(x => x.DURUM == false).ToString();
            label13.Text = db.Tbl_Urun.Sum(x => x.STOK).ToString();
            label21.Text = db.Tbl_Satis.Sum(x=>x.FIYAT).ToString() +" TL";
            label11.Text = (from x in db.Tbl_Urun orderby x.FIYAT 
                            descending select x.URUNAD).FirstOrDefault();
            label9.Text = (from x in db.Tbl_Urun orderby x.FIYAT ascending select
                           x.URUNAD).FirstOrDefault();
            label15.Text = db.Tbl_Urun.Count(x => x.KATEGORI == 1).ToString();
            label17.Text = db.Tbl_Urun.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            label23.Text = (from x in db.Tbl_Musteri select x.SEHIR).Distinct().Count().ToString();
            label19.Text = db.MARKAGETİR().FirstOrDefault();
        }
    }
}
