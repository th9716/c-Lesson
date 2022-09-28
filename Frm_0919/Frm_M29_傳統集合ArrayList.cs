using System;
using System.Collections;
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
    public partial class Frm_M29_傳統集合ArrayList : Form
    {
        public Frm_M29_傳統集合ArrayList()
        {
            InitializeComponent();
        }


        ArrayList lsPro = new ArrayList(); //創建ArrayList

        
        void ShowList() //顯示產品
        {
            decimal totalPrice = 0m;

            lab_Show.Text = "產品 \n ------------------ \n"; //清掉舊的值不重複

            for (int i = 0; i < lsPro.Count; i++)
            {
                lab_Show.Text += $" 名稱: {((Product)lsPro[i]).Name} , 單價: {((Product)lsPro[i]).Price} \n" ; //傳統集合object需要轉型
                totalPrice+= ((Product)lsPro[i]).Price;
            }
            lab_Show.Text += $"============== \n" + $"數量: {lsPro.Count} \n 總單價: {totalPrice}  ";

            if (lsPro.Count > 0)
            {
                lab_Show.Text += $"平均單價: {totalPrice / lsPro.Count }";
                //若數量為0則不執行
            }

        }


        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Product pro = new Product(txt_ProductName.Text , decimal.Parse( txt_ProductPrice.Text));

            lsPro.Add(pro);
            ShowList();
            
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            Product pro = new Product(txt_ProductName.Text, decimal.Parse(txt_ProductPrice.Text));

            lsPro.Insert(0,pro);
            ShowList();

        }

        private void Btn_RemoveAt_Click(object sender, EventArgs e)
        {
            lsPro.RemoveAt(0);
            ShowList();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            lsPro.Clear();
            ShowList();
        }

        private void Btn_Dif_Click(object sender, EventArgs e)
        {
            //lsPro.Add("string");  //型態為Product因此string及int無法加入但不會出現錯誤
            //lsPro.Add(100);
            //ShowList();
        }
    }
}
