using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonMothodHelper;

namespace GetHostsTool
{
    public partial class FrmAction : Form
    {
        public event Action CallBack;
        public FrmAction()
        {
            InitializeComponent();
        }

        private void txtImageLink_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewLink.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string NewLink = txtNewLink.Text.Trim();
            if (!string.IsNullOrEmpty(NewLink))
            {
                HostsGetTool.HostsLoader._link[2] = NewLink;
            }
            if (CallBack != null)
            {
                CallBack();
                this.Close();
            }
        }
    }
}
