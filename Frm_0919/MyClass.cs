using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_0919
{
    public partial class MyClass
    {
        //------------------------------------------------------------存取修辭
        void Method01()
        {
            MessageBox.Show("Method01");
        }

        private void Method02()
        {
            MessageBox.Show("Method02");
        }

        internal void Method03()
        {
            MessageBox.Show("Method03 internal");
        }

        public void Method04()
        {
            MessageBox.Show("Method04 public");
        }


        public void Method05() //封裝
        {
            Method01();
            Method02();
        }






    }
}
