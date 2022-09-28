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
    public partial class Frm_Member : Form
    {
        //------------------------------------------------------------物件初始化
        public Frm_Member()
        {
            InitializeComponent();
        }

        private void Btn_Member_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "John";
            mem1.BirthDay = new DateTime(1970, 9, 20); // 建立實體物件後再給予值

            MessageBox.Show("姓名:" + mem1.Name + "生日:" + mem1.BirthDay);



            Member mem2 = new Member()
            {
                Name = "Eric",
                BirthDay = new DateTime(1980, 5, 15), //利用,列欄位 建立實體物件的同時給予值
            };
            MessageBox.Show("姓名:" + mem2.Name + "生日:" + mem2.BirthDay);
        }



        //-----------------------------------------------------------註冊事件p8-4
        private void Btn_RegisterEvent_Click(object sender, EventArgs e)
        {
            //this.Btn_RegisterEvent.Click += new System.EventHandler(this.Btn_RegisterEvent_Click);      // Designer.cs中的註冊寫法
            Btn_RegisterEvent01.Click += new System.EventHandler(Btn_RegisterEvent01_Click); //註冊Btn01,+=(累加)事件處理方法
            Btn_RegisterEvent02.Click += Btn_RegisterEvent02_Click; //註冊的另一種寫法,+=後直接按tab系統會直接在下方生成Btn的觸發事件

        }

        private void Btn_RegisterEvent02_Click(object sender, EventArgs e) //生成的
        {
            MessageBox.Show("Register02");
        }

        private void Btn_RegisterEvent01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register01");
        }


        // todo
        //--------------------------------------------------------事件委派多個 p8-8

        private void Btn_sure_Click(object sender, EventArgs e)
        {

        }


        //-------------------------------------------------------設定屬性

        private void Btn_SetProperty_Click(object sender, EventArgs e)
        {
            Btn_SetProperty.Text = "設定屬性"; //MB內容改變
            Btn_SetProperty.BackColor = Color.AliceBlue; //MB的背景色
            this.Text = "顧客表單"; // this代表這個form因此會改變form名稱
            Btn_SetProperty.SetBounds(500,500,100,100); //MessageBox位置
        }


        private void Btn_GetProperty_Click(object sender, EventArgs e)
        {
            string txt = Btn_GetProperty.Text; //定義Btn的text內容為txt
            MessageBox.Show(txt); 
        }





        //---------------------------------------------------MessageBox類別 p10-7
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("請問今天是星期二嗎?","你好,", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes) 
            {
                MessageBox.Show("真的嗎?");
            }
            else 
            {
                MessageBox.Show("真的不是嗎?");
            }
        }

        
    }
}
