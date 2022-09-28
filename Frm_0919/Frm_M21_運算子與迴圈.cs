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
    public partial class Frm_M21_運算子與迴圈 : Form
    {
        public Frm_M21_運算子與迴圈()
        {
            InitializeComponent();
        }



        bool flag = true;
        private void Btn_Reverse_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                Btn_Reverse.BackColor = Color.IndianRed;
            }
            else
            {
                Btn_Reverse.BackColor = Color.PaleGoldenrod;
            }
            flag = !flag; // !為反轉

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Btn_Reverse.BackColor = (flag = !flag) ? Color.IndianRed : Color.PaleGoldenrod; //三元運算式 ? :
            
            //老師的版本:
            // Btn_Reverse.BackColor = flag ? Color.IndianRed : Color.PaleGoldenrod;
            // flag = !flag;
        }

        //------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {

            int score = int.Parse(txt_Grade.Text);
            if (score >=90 && score <= 100)  // && 是且的意思
            {
                lab_Grade.Text = "A級";
            }
            else if(score >= 80 && score <= 89)
            {
                lab_Grade.Text = "B級";
            }
            else if(score >= 70 && score <= 79)
            {
                lab_Grade.Text = "C級";
            }
            else if (score >= 60 && score <= 69)
            {
                lab_Grade.Text = "D級";
            }
            else if(score <= 59)
            {
                lab_Grade.Text = "E級";
            }
        }


        //------------------------------------------------------------ While迴圈 p24-4 while迴圈先判斷後執行,因此判斷為False執行出來將為空白
        private void button3_Click(object sender, EventArgs e)
        {
            int i = 11;
            string result = "";

            while(i <= 10)  //While直到條件判斷為False時才會停止執行 //()中為判斷條件
            {
                result += i ++ + "\n"; //後置遞增
         


                //result += i + "\n";
                //i++;   // i持續加一判斷條件才會有停止不然會一直空迴圈
            }

            MessageBox.Show(result);

        }

        private void button4_Click(object sender, EventArgs e) //p24-7  do迴圈先執行後判斷,因此判斷為False也還是會執行一次
        {
            int i = 11;
            string result = "";

            do
            {
                result += i ++ + "\n";
            }
            while(i <= 10);
            MessageBox.Show(result);
        }

        private void button5_Click(object sender, EventArgs e) //for迴圈可以設置一個以上的變數及初始值
        {
         
            string result = ""; //result設為字串,下面的i系統會自動替換為string

            for(int i =0, r =10; i <= 10; i++, r--) //起始值;判斷式;遞增減
            {
                result += i + "," + r +"\n";
            }
            MessageBox.Show(result);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            int i = 0;
            string result = "";

            for(int y = 10,x = 5; Test(y,x) ; i++, x++ , y-= 2) // Test(y,x)呼叫下方回傳值 i遞增1x遞增1y遞減2
            {
                result += i + "," + y + "," + x +"\n";
            }
            MessageBox.Show(result);

            bool Test(int y,int x) //因為迴圈的判斷式需要true或False的值所以使用boolean
            {
                return y - x >= 1;
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach(Control item in Controls) //Conrol類別可以控制所有控制項;foreach回直到所有元素取完才會結束
            {
                item.BackColor = Color.Beige;
                item.ForeColor = Color.Coral;
                item.Left -= 10;
                item.Top -= 10;

            }
        }
    }
}
