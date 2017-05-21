using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vcpkgManager.Common;

namespace vcpkgManager
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            SetupVcpkgFrm frm = new SetupVcpkgFrm();
            if (frm.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
