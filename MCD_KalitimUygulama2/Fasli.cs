using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimUygulama2
{
    public class Fasli:Insan
    {
        public override void Selamlasma()
        {
            base.Selamlasma(); //base kalıtımı yeri temsil eder.
            /*base.Selamlasma(); yazıldığında kalıtım alınan classtaki metotta hangi işlem varsa
             * burada o işlem kullanılır.
             * Yani bu Faslı arkadaş selamlar ile selam verecek.
             */

        }
    }
}
