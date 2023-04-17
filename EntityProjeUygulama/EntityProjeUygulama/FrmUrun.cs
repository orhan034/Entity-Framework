using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtAd.Text = cmbkategori.SelectedValue.ToString();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void btnLitsele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.FIYAT,
                                            x.Tbl_Kategori.AD,
                                            x.DURUM,
                                        }).ToList();
        }

        private void bntekle_Click(object sender, EventArgs e)
        {
            Tbl_Urun t = new Tbl_Urun();
            t.URUNAD = txtAd.Text;
            t.MARKA = txtMarka.Text;
            t.STOK = short.Parse(txtStok.Text);
            t.KATEGORI = int.Parse(cmbkategori.SelectedValue.ToString());
            t.FIYAT = decimal.Parse(txtFiyat.Text);
            t.DURUM = true;
            db.Tbl_Urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün sisteme kayıt edili");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            db.Tbl_Urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var urun = db.Tbl_Urun.Find(x);
            urun.URUNAD = txtAd.Text;
            urun.STOK = short.Parse(txtStok.Text);
            urun.MARKA = txtMarka.Text;
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategori
                               select new
                               { x.ID, x.AD }
                               ).ToList();
            cmbkategori.ValueMember = "ID";
            cmbkategori.DisplayMember = "AD";
            cmbkategori.DataSource = kategoriler;
        }
    }
}
