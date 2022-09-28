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
    public partial class Frm_M16_Parameter : Form
    {
        public Frm_M16_Parameter()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------------------參數為實質型別
        private void button1_Click(object sender, EventArgs e)
        {

            int a = 1;
            MessageBox.Show(a.ToString());
            PassByValue(a); //這邊的a為複製過去的獨立資料因此不會受影響
            MessageBox.Show(a.ToString());
        }

        void PassByValue(int x) 
        {
            x = 100;
        }

        // --------------------------------------------------------------參數為參考型別
        private void button2_Click(object sender, EventArgs e)
        {
            /* 定義的同時給予值 */

            //Member mem1 = new Member()
            //{
            //    Name = "Eric",
            //    BirthDay = new DateTime (1989,6,14)
            //};

            /* 先定義再給予值 */
            Member mem1 = new Member();
            mem1.Name = "Eric";
            mem1.BirthDay = new DateTime(1989,6,14);
            MessageBox.Show($"Name:{mem1.Name}, BirthDay:{mem1.BirthDay}");
            PassByReference(mem1); //帶入的是其值的記憶體位置因此參數值會變動
            MessageBox.Show($"Name:{mem1.Name}, BirthDay:{mem1.BirthDay}");

        }

        void PassByReference(Member member) 
        {
            member.BirthDay = DateTime.Now;
        }



        // --------------------------------------------------------------參數為參考型別迴圈版 p 16-8

        private void button3_Click(object sender, EventArgs e)
        {
            string[] str = {"Tiger","Fire","Cyber","Fiber","Diver","Viber","Jarjar" }; //定義陣列,序號由0開始
            MyValTypeChange(str);
            for(int i =0; i < str.Length; i++) //int i =0為初始值,Length為7
            {
                Console.WriteLine(str[i]);
                MessageBox.Show(str[i]);
            }
            //Console.ReadKey(); 
        }

        static void MyValTypeChange( string[] val) 
        {
            val [0] = "尋找紅心A"; //[0]為索引中間為要索引的目標序號
        }


        //------------------------------------------------------------------傳遞參數ref ,p 16-10 

        private void button4_Click(object sender, EventArgs e) //ref為傳址法 因此同參考型別一樣,使用後變動參數會影響到變數
        {
            int a = 1;
            MessageBox.Show(a.ToString());
            PassByRef(ref a); //定義及呼叫值都須加上ref
            MessageBox.Show(a.ToString());

        }

        void PassByRef(ref int X) //定義及呼叫值都須加上ref
        {
            X = 100;
        }

        //------------------------------------------------------------------傳遞參數out

        private void button5_Click(object sender, EventArgs e)
        {

            int a = 0;
            MessageBox.Show(a.ToString());
            PassByOut (out a); //定義及呼叫值都須加上out
            MessageBox.Show(a.ToString());
        }

        void PassByOut(out int X) //定義及呼叫值都須加上out
        {
            X = 1000;
        }

        //-------------------------------------------------------Params p 17-6

        private void button6_Click(object sender, EventArgs e)
        {
            
            string resultChinese =MyParams("國文",95,80,60,70,78); 
            MessageBox.Show(resultChinese);
            string resultMath = MyParams("數學",66,80,95,97);
            MessageBox.Show(resultMath);

        }

        string MyParams(string subject, params int[] scores) 
        {
            int sum = 0;

            for(int i = 0; i < scores.Length; i++)  //迴圈: 設定基礎值;設定索引長度;持續加一
            {
                sum += scores[i]; //總成績為成積累加, [i]為索引第幾項
            }

            
            return $"{subject} 的總成績: {sum} 分";//格式化
            // return subject + "的總成績:" + sum; //另一寫法

        }


    }
}
