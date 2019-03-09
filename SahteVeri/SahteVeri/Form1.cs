using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SahteVeri
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<Ogrenci> ogrencilistesi = new List<Ogrenci>(); //Ogrenci sınıfındaki propertyleri kullanarak bir list oluşturduk.İnstance aldık
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //Fake veri getir butonu click eventi
            DataGridDoldur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            Kolonlar kolon = new Kolonlar();//Kolonlar clasından kolon adında bir instance aldık

            for (int i = 1; i <= 100; i++)
            {
                Ogrenci ogr = new Ogrenci();

                ogr.ID = i;                           //Ogrenci clasındaki propertylere ulaşmak için agr adında bir instance aldık.
                ogr.AD = kolon.RastgeleIsim();           //(data gridview sütunlarını) doldurmak için kolon instance'ını kullanarak Kolonlar clasının
                ogr.SOYAD = kolon.RastgeleSoyIsim();    //metotlarına eriştik
                ogr.NOT = kolon.RastgeleNot();
                ogr.YAS = kolon.RastgeleYas();
                ogrencilistesi.Add(ogr);// Bunları ogrencilistesi list'inin içine attık
               
            }
        }

        private void DataGridDoldur()
        {
            //dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrencilistesi;//dataGridView'ın kaynağı ogrencilistesi list'i

            
        }

    }
}
