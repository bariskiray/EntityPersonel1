using EntityPersonel1.DataAccessLayer;
using EntityPersonel1.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityPersonel1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        viewPersonelBirimDAL vpbdal = new viewPersonelBirimDAL();
        BirimDAL bdal = new BirimDAL();
        Personeller p = new Personeller();
        PersonelDAL pdal = new PersonelDAL();

        public void Yenile()
        {
            dataGridView1.DataSource = vpbdal.GetList();
            comboBox1.DataSource=bdal.GetList();
        }
        void ClearDataBinding()
        {
            foreach(Control item in this.Controls) 
            { 
                item.DataBindings.Clear();
            }


        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entityPersonelDataSet.viewPersonelBirim' table. You can move, or remove it, as needed.
            this.viewPersonelBirimTableAdapter.Fill(this.entityPersonelDataSet.viewPersonelBirim);
            Yenile();
            Data_Binding(new Personeller());
        }

        void Data_Binding(Personeller person)
        {
            ClearDataBinding();
            this.p=person;
            txtPersonelID.DataBindings.Add("Text", p, "PersonelID", true);
            txtPersonelAdSoyad.DataBindings.Add("Text", p, "AdiSoyadi", true);
            txtTelefon.DataBindings.Add("Text", p, "Telefon", true);
            txtAdres.DataBindings.Add("Text", p, "Adres", true);
            txtEmail.DataBindings.Add("Text", p, "Email", true);
            comboBox1.DataBindings.Add("SelectedValue", p, "BirimID",true);
            dateTimePicker1.DataBindings.Add("Text", p, "Tarih", true);
            checkBox1.DataBindings.Add("CheckState", p, "IsActive",true);
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vpbdal.GetList(x=>x.AdiSoyadi.Contains(txtAra.Text));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int personelid = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            pdal.Delete(p=>p.PersonelID==personelid);
            pdal.Save();
            Yenile();
            Data_Binding(new Personeller());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e) {
            pdal.AddorUpdate(p);
            pdal.Save();
            Yenile();
            Data_Binding(new Personeller());

                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int personelid = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            Data_Binding(pdal.GetByFilter(x => x.PersonelID == personelid));
        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {

        }
    }
}
