using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace WindowsFormsApplication28
{
    public partial class Form1 : Form
    {
        OleDbConnection yeni;
        OleDbDataAdapter verial;
        DataSet al;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yeni = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Lab1-Ter\\Documents\\hastane.mdb");
            verial = new OleDbDataAdapter("select * from hastabilgileri", yeni);
            al = new DataSet();
            verial.Fill(al, "hastabilgileri");
            bindingSource1.DataSource = al;
            bindingSource1.DataMember = al.Tables[0].TableName;
            dataGridView1.DataSource = bindingSource1;
            //
            String veri;
            foreach (DataRow eleman in al.Tables[0].Rows)
            {
                veri = eleman[0].ToString();
                if (!comboBox1.Items.Contains(veri))
                {
                    comboBox1.Items.Add(veri);
                }

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String metin;
            metin = comboBox1.Text;
            bindingSource1.Filter = "doktoradi='" + metin + "'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
        }
    }
}
