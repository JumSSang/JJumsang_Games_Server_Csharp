using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatrolSky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public void 대기유저추가(string user_name)
        {
            this.대기유저리스트.BeginInvoke(new Action(() => this.대기유저리스트.Items.Add(user_name)));
        }

        public void 서버상태업데이트(string msg)
        {
            this.WordCharList.BeginInvoke(new Action(() => this.WordCharList.Items.Add(msg)));
        }
    }
}
