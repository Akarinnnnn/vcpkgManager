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
    public partial class SetupVcpkgFrm : Form
    {
        public SetupVcpkgFrm()
        {
            InitializeComponent();
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            string targetDir = this.txtPathVcpkg.Text;
            this.btnSelPath.Enabled = false;
            this.btnSetup.Enabled = false;

            if (SoftwareChecker.checkTargetVcpkg(targetDir) == false)
            {
                if (System.IO.File.Exists(targetDir + "//.gitignore"))
                {
                    MessageBox.Show("该目录下存在Git Clone内容，无法安装至该目录，请使用一个空目录安装。");
                    return;
                }

                // step 1 克隆代码到指定目录
                if(lVcpkgManager.Ins.gitCloneVcpkg(targetDir) == false)
                {
                    MessageBox.Show("代码克隆失败，无法继续安装。");
                    return;
                }

                // step 2 执行安装程序
                lVcpkgManager.Ins.buildVcpkg(targetDir); // 运行安装VCPKG

                ConfigManager.Ins.isInited = true;
                ConfigManager.Ins.vcpkgPath = this.txtPathVcpkg.Text;
            }
            else
            {
                ConfigManager.Ins.isInited = true;
                ConfigManager.Ins.vcpkgPath = this.txtPathVcpkg.Text;
            }

            ConfigManager.Ins.saveConfig();
            this.DialogResult = DialogResult.OK;
        }

        private void SetupVcpkgFrm_Load(object sender, EventArgs e)
        {
            if(ConfigManager.Ins.loadConfig() == false)
            {
                MessageBox.Show("载入配置文件错误，无法执行程序。");
                Application.Exit(); 
            }

            if(SoftwareChecker.checkGit() == false)
            {
                MessageBox.Show("未检测到Git安装，无法运行程序，如果安装Git请设置到PATH中。");
                Application.Exit();
            }

            lVcpkgManager.Ins.setupGit(); // 安装GIT目录
            if(ConfigManager.Ins.isInited && ConfigManager.Ins.vcpkgPath != "")
            {
                if(SoftwareChecker.checkTargetVcpkg(ConfigManager.Ins.vcpkgPath))
                {
                    lVcpkgManager.Ins.setupVcpkg(ConfigManager.Ins.vcpkgPath);
                    this.DialogResult = DialogResult.OK;
                    return;
                }
            }

            this.txtPathVcpkg.Text = System.Environment.CurrentDirectory + "\\vcpkgInstall";
        }

        private void btnSelPath_Click(object sender, EventArgs e)
        {
            if(vcpkgFBDialog.ShowDialog() == DialogResult.OK)
            {
                this.txtPathVcpkg.Text = vcpkgFBDialog.SelectedPath;
            }
        }
    }
}
