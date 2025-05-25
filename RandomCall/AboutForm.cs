using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCall
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("以前在github上抄代码，作者跟我说点个star，我都会说好好好，但是编译完也没想起来打。其实这样挺不好的。\r\n现在作者跟我说点个star，除非代码真的很好到我想打好评的程度，否则我就会在issue直接说，抱歉我不想star，然后直接抄。作为一个有讨好倾向的人，这是我锻炼真诚和勇气的方式", "你发现了彩蛋！");
        }
    }
}
