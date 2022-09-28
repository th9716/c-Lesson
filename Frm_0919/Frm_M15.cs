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
    public partial class Frm_M15 : Form
    {
        public Frm_M15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //ValueType實質型態 p 15-6
        {
            int B = 10; //設定變數內容:內容值
            int C = 20;

            C = B; 
            MessageBox.Show($"B:{B} , C:{C} ");
            C = B; 
            B = 50;
            
            MessageBox.Show($"B:{B} , C:{C} ");

        }

        private void button02_Click(object sender, EventArgs e) //ReferenceType參考型態 p15-10
        {
            TextBox rt = txtReferenceType; //設定變數內容:存放資料的位置

            rt.Text = "參考型態";
            rt.BackColor = Color.Teal;
            rt.ForeColor = Color.Goldenrod;

        }
    }
}
