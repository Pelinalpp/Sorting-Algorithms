using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Odev_2_Soru_2
{
    public class HeapSort:SortBase
    {
        public override void Sort(int[] items)
        {
            int boyut = items.Length;
            for (int i = (boyut - 1) / 2; i >= 0; i--)
                Degistir(items, boyut, i);
 
            for (int i = items.Length - 1; i > 0; i--)
            {
                //Swap işlemi gerçekleştirildi.
                int temp = items[i];
                items[i] = items[0];
                items[0] = temp;

                boyut--;
                Degistir(items, boyut, 0);
            }
        }

        public void Degistir(int[] dizi, int boyut, int indis)
        {
            int sol = (indis + 1) * 2 - 1;
            int sag = (indis + 1) * 2;
            int max = 0;

            if (sol < boyut && dizi[sol] > dizi[indis])
                max = sol;
            else
                max = indis;

            if (sag < boyut && dizi[sag] > dizi[max])
                max = sag;

            if (max != indis)
            {
                int temp = dizi[indis];
                dizi[indis] = dizi[max];
                dizi[max] = temp;

                Degistir(dizi, boyut, max);
            }   
        }
    }
}
