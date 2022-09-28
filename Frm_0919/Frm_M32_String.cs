using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_0919
{
    public partial class Frm_M32_String : Form
    {
        public Frm_M32_String()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "AAA";
            str1 = "BBB";
            string str2 = str1;
            MessageBox.Show($"str1: {str1}, str2: {str2}");
            str2 = "CCC";
            MessageBox.Show($"str1: {str1}, str2: {str2}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("AAA");
            MessageBox.Show($"sb1: {sb1.ToString()}");
            StringBuilder sb2 = sb1;
            sb2.Append("BBB");
            MessageBox.Show($"sb1: {sb2.ToString()}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string shiba = "C:\\Users\\Student\\Downloads\\shiba.jpg";
            string shiba = @"C:\Users\Student\Downloads\shiba.jpg";

            string result = $"{Path.GetFileName(shiba)}\n"+
                $"{Path.GetExtension(shiba)}\n"+
                $"{Path.GetDirectoryName(shiba)}\n"+
                $"{Path.GetFullPath(shiba)}\n"+
                $"{Path.GetFileNameWithoutExtension(shiba)}";

        }

        private void timerTime_Tick(object sender, EventArgs e) //Timer設置時間
        {
            labTime2.Text = DateTime.Now.ToShortTimeString();
            labTime3.Text = DateTime.Now.ToShortDateString();
            labTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
