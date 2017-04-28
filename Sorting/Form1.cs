using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_Odev_2_Soru_2
{
    public partial class frmSoru2 : Form
    {
        public frmSoru2()
        {
            InitializeComponent();
        }

        int[] dizi100 = new int[100];
        int[] dizi750 = new int[750];
        int[] dizi1500 = new int[1500];
        int[] dizi7500 = new int[7500];
        int[] dizi15000 = new int[15000];
        int[] dizi75000 = new int[75000];
        int[] dizi150000 = new int[150000];


        public void RandomDataGenerator()
        {
            //Random değerler atandı.
            Random r = new Random();
            for(int i = 0; i < 150000; i++)
            {
                if (i < 100)
                    dizi100[i] = r.Next();
                if (i < 750)
                    dizi750[i] = r.Next();
                if (i < 1500)
                    dizi1500[i] = r.Next();
                if (i < 7500)
                    dizi7500[i] = r.Next();
                if (i < 15000)
                    dizi15000[i] = r.Next();
                if (i < 75000)
                    dizi75000[i] = r.Next();
                if (i < 150000)
                    dizi150000[i] = r.Next();
            }
        }

        BubbleSort bs = new BubbleSort();
        SelectionSort ss = new SelectionSort();
        QuickSort qs = new QuickSort();
        InsertionSort ins = new InsertionSort();
        HeapSort hs = new HeapSort();
        string temp = "";

        private void frmSoru2_Load(object sender, EventArgs e)
        {
            RandomDataGenerator();
            txtListe.Text += "Algoritma\t\t100\t750\t1500\t7500\t15000\t75000\t150000" + Environment.NewLine +  "_______________________________________________________________________" + Environment.NewLine + Environment.NewLine;
            txtListe.Font = new Font(txtListe.Font, FontStyle.Bold);
        }

        private void btnBubble_Click(object sender, EventArgs e)
        {
            //Çalışma süreleri hesaplandı.
            temp = "Bubble\t\t";

            DateTime dtBaslangic = DateTime.Now;
            bs.Sort(dizi100);
            TimeSpan tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            bs.Sort(dizi750);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            bs.Sort(dizi1500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            bs.Sort(dizi7500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            bs.Sort(dizi15000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            bs.Sort(dizi75000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            bs.Sort(dizi150000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + Environment.NewLine + Environment.NewLine;

            txtListe.Text += temp;
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            temp = "Selection\t\t";

            DateTime dtBaslangic = DateTime.Now;
            ss.Sort(dizi100);
            TimeSpan tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ss.Sort(dizi750);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ss.Sort(dizi1500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ss.Sort(dizi7500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ss.Sort(dizi15000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ss.Sort(dizi75000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ss.Sort(dizi150000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + Environment.NewLine + Environment.NewLine;

            txtListe.Text += temp;
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            temp = "Quick\t\t";

            DateTime dtBaslangic = DateTime.Now;
            qs.Sort(dizi100);
            TimeSpan tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            qs.Sort(dizi750);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            bs.Sort(dizi1500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            qs.Sort(dizi7500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            qs.Sort(dizi15000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            qs.Sort(dizi75000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            qs.Sort(dizi150000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + Environment.NewLine + Environment.NewLine;

            txtListe.Text += temp;
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            temp = "Insertion\t\t";

            DateTime dtBaslangic = DateTime.Now;
            ins.Sort(dizi100);
            TimeSpan tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ins.Sort(dizi750);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ins.Sort(dizi1500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ins.Sort(dizi7500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ins.Sort(dizi15000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ins.Sort(dizi75000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            ins.Sort(dizi150000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + Environment.NewLine + Environment.NewLine;

            txtListe.Text += temp;
        }

        private void btnHeap_Click(object sender, EventArgs e)
        {
            temp = "Heap\t\t";

            DateTime dtBaslangic = DateTime.Now;
            hs.Sort(dizi100);
            TimeSpan tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            hs.Sort(dizi750);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            hs.Sort(dizi1500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            hs.Sort(dizi7500);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            hs.Sort(dizi15000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            hs.Sort(dizi75000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + "\t";

            dtBaslangic = DateTime.Now;
            hs.Sort(dizi150000);
            tsToplamSure = DateTime.Now.Subtract(dtBaslangic);
            temp += tsToplamSure.Milliseconds.ToString() + Environment.NewLine + Environment.NewLine;

            txtListe.Text += temp;
        }
    }
}
