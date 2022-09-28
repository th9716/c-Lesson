using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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



        //-------------------------------------------------------M32 Regex p32-12
        private void button4_Click(object sender, EventArgs e)
        {
            labPassword.Text = isCorrectPassword(txt_Password.Text) ? "密碼格式正確" : "密碼格式錯誤";
            labID.Text = isCorrectID(txt_ID.Text) ? "格式正確" : "格式錯誤";
        }

        bool isCorrectPassword(string Password)
        {
            return Regex.IsMatch(Password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,16}$"); //Regex開頭^結尾$
            //(?=.*)任意位置
        }

        bool isCorrectID(string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$"); //[]限定位置 {}佔幾格
        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {
            //labPassword.Text = isCorrectPassword(txt_Password.Text) ? "密碼格式正確" : "密碼格式錯誤";
            if (isCorrectPassword(txt_Password.Text))
            {
                labPassword.Text = "密碼格式正確";
                timerPassword.Enabled = false;
            }
            else
            {
                labPassword.Text = "密碼格式錯誤";
                timerPassword.Enabled=true;
            }


        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            //labID.Text = isCorrectID(txt_ID.Text) ? "格式正確" : "格式錯誤";
            if (isCorrectID(txt_ID.Text))
            {
                labID.Text = "格式正確";
                timerID.Enabled = false;

            }
            else
            {
                labID.Text = "格式錯誤";
                timerID.Enabled = true;

            }

        }

        bool flag = true;
        bool flag2 = true;
        private void timerPassword_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                labPassword.BackColor = Color.Yellow;
                labPassword.ForeColor = Color.Red;
            }
            else
            {
                labPassword.BackColor = Color.Red;
                labPassword.ForeColor = Color.Yellow;
            }          
            flag = !flag;
        }


        private void timerID_Tick(object sender, EventArgs e)
        {
            if (flag2)
            {
                labID.BackColor = Color.Yellow;
                labID.ForeColor = Color.Red;
            }
            else
            {
                labID.BackColor = Color.Red;
                labID.ForeColor = Color.Yellow;
            }
            flag2 = !flag2;
        }
        
    }
}
