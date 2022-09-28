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
    public partial class Frm_M12 : Form
    {
        
        
        public Frm_M12()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------
        public int num00 = 10;
        internal string foo = "Foo";
        protected int m_num;

        //--------------------------------------------------------------
        int count = 0; //放於類別中才能重複使用
        int count01 = 0;

        private void Btn_Count_Click(object sender, EventArgs e)
        {
            count += 1; //累加1
            labShowCount.Text = "Count:" + count; //show
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count01 -= 1; //累減1
            label1.Text = "Count:" + count01; //show
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = ++count; //前置遞增 p12-8

            labShowCount.Text = "Count:" + count;
            MessageBox.Show("num:" +num);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = count++; //後置遞增 p12-9

            labShowCount.Text = "Count:" + count;
            MessageBox.Show("num:" + num);
        }

        //-------------------------------------------------------------
        private void button4_Click(object sender, EventArgs e) //區域變數
        {

            num00 -= 1;
            string Num00 = num00.ToString(); //int轉成string

            //a = 0; 此處無法呼叫下層的變數
            int a = 0;

            if (true) 
            {
                int x = 1 ;
                a = x;
            }
            //x = 0; 此處無法呼叫下層的變數
            MessageBox.Show(Num00);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StaticLab sl = new StaticLab(); //沒有static所以要使用new創建實體
            sl.NoStaticCount++;

            labNoStaticCount.Text = "Count:" +sl.NoStaticCount; //變更文字內容

        }

        private void button6_Click(object sender, EventArgs e)
        {
            StaticLab.StaticCount++; //有static所以可以直接呼叫StaticLab類別

            labStaticCount.Text = "Count:" + StaticLab.StaticCount; //變更文字內容
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Frm_01 frm_01 = new Frm_01(); 
            frm_01.Show(); //開啟Form1
        }
    }
}
