using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_0919
{
    //------------------------------------------------------------物件初始化
    public class Member
    {
        public string Name;
        public DateTime BirthDay; //列欄位
    }


    //------------------------------------------------------------靜態變數
    public class StaticLab 
    {
        public int NoStaticCount; //無static
        public static int StaticCount; //經static宣告
        //public是誰能取用 ,static則是儲存位置
    }

    //-------------------------------------------------------------enum p18

    public enum UserRole
    {
        Admin =1,
        User = 2
    }

    //-------------------------------------------------------------struct p19

    public struct Product
    {
        //public string Name;
        //public decimal Price;




        public Product(string ProductName, decimal ProductPrice)
        {
            Name = ProductName;
            Price = ProductPrice;

        }


        public string Name { get; set; }
        public decimal Price { get; set; } //設定屬性  //  set = get



    }






}
