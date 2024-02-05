using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metot
{
    public partial class Form1 : Form
    {
        Color color=Color.Red;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   int sayi1 = Convert.ToInt32(txtSayi1.Text);
            //  int sayi2 = Convert.ToInt32(txtSayi2.Text);
            //  int sonuc = sayi1 * sayi2;
            //  MessageBox.Show($"karesi  ={sonuc}"); 


            Sekil sekil1 = new Sekil();
            sekil1.kisakenar = Convert.ToInt32(txtSayi1.Text);
            sekil1.uzunkenar = Convert.ToInt32(txtSayi2.Text);
            sekil1.sekilCiz(button2,color);
            sekil1.mesajDegistir(button2, txtMesaj.Text);



           
        }

      

        

        private void btnRengisec_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
        }
    }
}
