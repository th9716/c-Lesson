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
    public partial class Frm_HelloForm : Form
    {
        public Frm_HelloForm()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------呼叫視窗
        private void Btn_open_Click(object sender, EventArgs e)
        {
            Frm_01 frm = new Frm_01(); //實作類別
            frm.Show(); //show視窗
        }


        //------------------------------------------------------------ DialogResult屬性更改值來製作連續對話方塊
        private void Btn_DialogResult_Click(object sender, EventArgs e)
        {
            Frm_01 frm = new Frm_01();
            DialogResult result = frm.ShowDialog();  //DialogResult強制回應MessageBox

            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK!");
            }
        }




        //------------------------------------------------------------呼叫同類別
        private void Btn_void_Click(object sender, EventArgs e)
        {
            MyFirestMethod();
        }

        void MyFirestMethod()
        {
            string Name = "John Wick";
            MessageBox.Show("My Name is:" + Name); //宣告名稱
        
        
        }

        //------------------------------------------------------------呼叫不同類別Return
        
        private void Btn_ReturnMethod_Click(object sender, EventArgs e)
        {
            string birthYear = BirthYear(25);

            MessageBox.Show(birthYear);
        }

        
        string BirthYear(int Age) 
        {
            int year = DateTime.Now.Year - Age; //DateTime.Now.Year現在的年份
            string result = "出生於" + year + "年";
            return result;

        }
        //------------------------------------------------------------存取修飾詞
        private void Btn_NewClass_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            
            //mc.Method01();
            //mc.Method02();
            mc.Method03();
            mc.Method04();
        }

        //------------------------------------------------------------封裝
        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method05(); //利用public封裝private

        }

        //------------------------------------------------------------Partial
        private void Btn_PartialClass_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method06(); //class加上partial

        }

        
    }
}
