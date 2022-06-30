using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnLİstele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = TxtSehir.Text;
            ent.Gorev = TxtGorev.Text;
            ent.Maas = short.Parse(TxtMaas.Text);
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(TxtId.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(TxtId.Text);
            ent.Ad = TxtAd.Text;
            ent.Soyad = TxtSoyad.Text;
            ent.Sehir = TxtSehir.Text;
            ent.Gorev = TxtGorev.Text;
            ent.Maas = short.Parse(TxtMaas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtSehir.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtGorev.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TxtMaas.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }
    }
}
