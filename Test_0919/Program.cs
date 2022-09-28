using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Frm_0919; //參考

namespace Test_0919
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray; //背景顏色
            Console.Write("請輸入姓名:"); //Write不會換行 WriteLine會換行
            string name = Console.ReadLine(); //資料型態 變數 = 輸入文字
            Console.WriteLine("Hello!我是" + name); 
            Console.SetCursorPosition(0, 0); //鼠標位置
            Console.SetWindowPosition(0, 0); //視窗位置
            Console.SetWindowSize(0, 0); //視窗尺寸
            
            
            Console.ReadKey();

            //------------------------------------------------------------partial
            MyClass mc = new MyClass();

            //mc.Method03();
            mc.Method04();



            
        }
    }
}
