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
    public partial class Frm_M19_struct : Form
    {
        public Frm_M19_struct()
        {
            InitializeComponent();
        }

        string result = "產品 \n-------------\n";
        decimal total = 0;
        decimal amount = 0;
       
        private void button1_Click(object sender, EventArgs e)
        {
            //Product pro;
            //pro.Name = txt_ProductName.Text;
            //pro.Price = decimal.Parse(txt_ProductPrice.Text);


            //Product pro = new Product(txt_ProductName.Text ,decimal.Parse (txt_ProductPrice.Text)); //有建構方法或屬性就需要new


            decimal priceResult = 0;  //給output回傳的變數
            bool isSuccess = decimal.TryParse(txt_ProductPrice.Text ,out priceResult); //isSuccess接收TryParse辨認true or False // p20-11

            if (isSuccess)
            {
                Product pro = new Product();
                pro.Name = txt_ProductName.Text;
                pro.Price = decimal.Parse(txt_ProductPrice.Text);


                amount += 1; //產品數
                total += pro.Price; //總金額


                result += $"名稱:{pro.Name} , 單價: {pro.Price}\n 產品數:{amount} , 總金額:{total} \n";
            }
            else
            {
                MessageBox.Show("輸入格式錯誤");
                txt_ProductPrice.Focus(); //焦點放回價格輸入
                txt_ProductPrice.Clear(); //清除原本的輸入值

            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labProductShow.Text = result;


        }
    }
}
