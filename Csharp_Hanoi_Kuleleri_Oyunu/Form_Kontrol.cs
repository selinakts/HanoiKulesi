using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Hanoi_Kuleleri_Oyunu
{
    class Form_Kontrol
    {
       
        public static void mesajVer(string mesaj)
        {
            System.Windows.Forms.MessageBox.Show(mesaj);
        }
        public static void frm_yardim_kontrol()
        {
            if (Hanoi.formAcikMi == false)
            {
              
                Hanoi.formAcikMi = true;
            }
            else
            {
             
                Hanoi.formAcikMi = false;
            }
        }
    }
    class formlar
    {
        public static Hanoi frm_uygulama = new Hanoi();
      
    }
}
