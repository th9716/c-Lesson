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
    public partial class Frm_M30_泛用集合_List : Form
    {
        public Frm_M30_泛用集合_List()
        {
            InitializeComponent();
        }

        void ShowList()
        {
            decimal totalPrice = 0m;

            lab_Show.Text = "產品 \n ------------------ \n"; //清掉舊的值不重複

            //for (int i = 0; i < lsPro.Count; i++)
            //{
            //    lab_Show.Text += $" 名稱: {lsPro[i].Name} , 單價: {lsPro[i].Price} \n"; //泛用集合不用轉型
            //    totalPrice += lsPro[i].Price;
            //}
            //lab_Show.Text += $"============== \n" + $"數量: {lsPro.Count} \n 總單價: {totalPrice}  ";

            foreach(Product pro in lsPro)
            {
                lab_Show.Text += $" 名稱: {pro.Name} , 單價: {pro.Price} \n"; 
                totalPrice += pro.Price;
            }


            if (lsPro.Count > 0)
            {
                lab_Show.Text += $"平均單價: {totalPrice / lsPro.Count}"; //若數量為0則不執行

            }

        }


        List<Product> lsPro = new List<Product>();
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Product pro = new Product(txt_ProductName.Text, decimal.Parse(txt_ProductPrice.Text));
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
            //lsPro.Add("string");  //型態為Product因此string及int無法加入,會出現錯誤
            //lsPro.Add(100)
        }
    }
}
