using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metot
{
    internal class Sekil
    {
        public int uzunkenar { get; set; }
        public int kisakenar { get; set; }
        public string mesaj { get; set;}


      //  public Sekil(int uzunkenar, int kısakenar)
       // {
        //    uzunkenar = uzunkenar;
        //    kısakenar = kısakenar;
      //    }
        public void kareyaz()
        {
            int sonuc=this.kisakenar*this.uzunkenar;
            MessageBox.Show($"şeklin karesi:{sonuc}");
        }
        public void sekilCiz(Button btn,Color renk)
        {
            btn.Width = this.uzunkenar;
            btn.Height = this.kisakenar;
            btn.BackColor=renk;

        }
        public void mesajDegistir(Button btn,String m)
        {
            btn.Text = m;
        }    

    }
}
