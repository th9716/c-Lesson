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
    public partial class Frm_M18_enum : Form
    {
        public Frm_M18_enum()
        {
            InitializeComponent();
        }

        private void Btn_Product_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin");
            // Enable 設成False
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //Admin = 1
            //User = 2

            int Role = 1;

            int Admin = 1 ,User = 2;

            //Admin = 2;  //更改int值便會被改變

            if (Role == Admin)
            {
                Btn_Product.Enabled = true;
            }
            else
            {
                Btn_Product.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Admin = 1
            //User = 2

            int Role = 1;

            const int Admin = 1, User = 2; //設為常數

            //Admin = 2;  //常數不會在被更改值 

            if (Role == Admin)
            {
                Btn_Product.Enabled = true;
            }
            else
            {
                Btn_Product.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //-------------------------------------------------- 轉換值寫法

            //int Role = 1;
            //if (Role == (int)UserRole.Admin)     //將UserRloe.Admin轉成int
            //{
            //    Btn_Product.Enabled = true;
            //}
            //else
            //{
            //    Btn_Product.Enabled = false;
            //}


            //-------------------------------------------------- 呼叫類別寫法
            UserRole Role = UserRole.Admin;

            //---------------------------------------------------------------
            //if(Role == UserRole.Admin)
            //{
            //    Btn_Product.Enabled = true;
            //}
            //else
            //{
            //    Btn_Product.Enabled = false;
            //}

            //------------------------------------------------- switch寫法
            switch (Role) //找出符合的項目執行反之便不執行
            {
                case UserRole.Admin:
                    Btn_Product.Enabled = true;
                    break;
                case UserRole.User:
                    Btn_Product.Enabled = false;
                    break;



            }



        }

        
    }
}
