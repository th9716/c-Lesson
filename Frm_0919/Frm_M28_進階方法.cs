using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_0919
{
    public partial class Frm_M28_進階方法 : Form
    {
        public Frm_M28_進階方法()
        {
            InitializeComponent();
        }

        //-------------- p-28-4
        //---------------------------定義同名方法,具相同名稱,但依照參數個數或型態不同,來分辨需要呼叫的方法
        void Swap(ref int A, ref int B)// AB int值交換
        {
            int T = A;
            A = B;
            B = T;
        }

        void Swap(ref string A, ref string B)// AB string值交換
        {
            string T = A;
            A = B;
            B = T;
        }

        //----------------------------------------------泛用方法,可套用到class,struct,interface,delegate,方法中
        void GenericSwap<G>(ref G A,ref G B) //<>括弧中填入型態參數代稱 ,代稱直接取代所有型態參數
        {
            G T = A;
            A = B;
            B = T;
        }
        //------------------------------------------------


        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            MessageBox.Show($"a :{a} , b :{b}");
            Swap(ref a, ref b); //呼叫交換int的方法
            MessageBox.Show($"a :{a} , b :{b}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "AAA", b = "BBB";
            MessageBox.Show($"a :{a} , b :{b}");
            Swap(ref a, ref b);//呼叫交換string的方法
            MessageBox.Show($"a :{a} , b :{b}");
        }



        //----------------------------------------------泛用方法
        private void button3_Click(object sender, EventArgs e)
        {
            int a = 100, b = 200;
            GenericSwap<int>(ref a, ref b); //<>中帶入int值代表此方法是要交換int值
            MessageBox.Show($"a :{a} , b :{b}");

            string sa = "AAA", sb = "BBB";
            GenericSwap<string>(ref sa, ref sb); //<>中帶入string值代表此方法是要交換string值
            MessageBox.Show($"a :{sa} , b :{sb}");

            
        }
    }
}
