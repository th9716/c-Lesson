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
    public partial class Frm_M26_Array : Form
    {
        public Frm_M26_Array()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e) // p26-4
        {
            //int[] arr = new int [4] ; //有三種陣列列法
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;

            //int[] arr = new int[3] { 10, 20, 30 };

            int[] arr = { 10, 20, 30 };

            string result = "";
            for (int i = 0; i < arr.Length; i++)  //用迴圈抓取所有陣列值 //起始值;陣列長度;遞增1
            {
                result += arr[i] + "\n";
            }
            MessageBox.Show(result);

        }


        //-------------------------------------------------------------------二維陣列 p26-6
        private void button2_Click(object sender, EventArgs e)
        {
            int[,] arr =
            {
                {10,20,30},
                {40,50,60}
            };

            string result = "";
            for(int i = 0; i < arr.GetLength(0); i++) //巢狀迴圈外層抓取陣列1的值內層抓取陣列2
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    result += $" arr{i} , {j} : " + arr[i , j] + "\n";
                }
            }
            MessageBox.Show(result);

            //-----------------------------------------------三維陣列

            int[,,] arr3 = new int[2, 3, 2]
            {
                {
                    {10,20} ,
                    {30,40}  ,
                    {50,60 }
                } ,
                {
                    {70,80} ,
                    {90,100}  ,
                    {110,120 }
                }
            };

            MessageBox.Show(arr3[0, 1, 0].ToString());





        }


        //----------------------------------------------------------類別陣列 p27-5
        private void button3_Click(object sender, EventArgs e)
        {

            //Member[] members = new Member[2];
            //members[0] = new Member();     //陣列內部元件也需要new
            //members[0].Name = "AAA";
            //members[0].BirthDay = new DateTime(1998, 4, 15);
            //members[1] = new Member();
            //members[1].Name = "BBB";
            //members[1].BirthDay = new DateTime(2000, 10, 7);

            Member[] members =
            {
                new Member{Name ="AAA" ,BirthDay = new DateTime(1998,4,15)},
                new Member{Name = "BBB" ,BirthDay = new DateTime(2000,10,7)}
            }; //格式化


            MessageBox.Show($"Name: {members[0].Name} ,BirthDay: {members[0].BirthDay} \n " +
                $"Name: {members[1].Name} ,BirthDay: {members[1].BirthDay}");


        }




        //--------------------------------------------------------------回傳陣列的方法

        private void button4_Click(object sender, EventArgs e)
        {
            int[] resultArr = CreateArray(20); //設置長度為20

            string result = "";

            //for(int i =0; i < resultArr.Length; i++)
            //{
            //    result += resultArr[i] +"\n"; //result+= arr[i] = i+1
            //}

            //----p 27-12
            foreach (int item in resultArr) // foreach迴圈 陣列資料取完便結束迴圈
            {
                result += item + "\n";
                
            }

            

            MessageBox.Show(result);

        }

        int[] CreateArray(int Length) //利用迴圈設置陣列長度為arr
        {
            int[] arr = new int[Length];

            for (int i =0; i < Length; i++)
            {
                arr[i] = i +1;
            }

            return arr;
        }





    }
}
