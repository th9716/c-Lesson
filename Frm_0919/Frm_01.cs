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
    public partial class Frm_01 : Form
    {
        public Frm_01()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text; ; // .Text 抓取文字字串
            MessageBox.Show("Hello," + Name + "!" +  StaticLab.StaticCount);  //最後StaticLab.StaticCount為從F_M12抓取Count值並print出來
        }
    }
}
