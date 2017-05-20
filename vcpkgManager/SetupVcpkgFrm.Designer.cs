namespace vcpkgManager
{
    partial class SetupVcpkgFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupVcpkgFrm));
            this.PathGroupID = new System.Windows.Forms.GroupBox();
            this.PathLabel = new System.Windows.Forms.Label();
            this.vcpkgFBDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtPathVcpkg = new System.Windows.Forms.TextBox();
            this.btnSelPath = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.TipLabel = new System.Windows.Forms.Label();
            this.PathGroupID.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathGroupID
            // 
            this.PathGroupID.Controls.Add(this.TipLabel);
            this.PathGroupID.Controls.Add(this.btnSetup);
            this.PathGroupID.Controls.Add(this.btnSelPath);
            this.PathGroupID.Controls.Add(this.txtPathVcpkg);
            this.PathGroupID.Controls.Add(this.PathLabel);
            this.PathGroupID.Location = new System.Drawing.Point(12, 12);
            this.PathGroupID.Name = "PathGroupID";
            this.PathGroupID.Size = new System.Drawing.Size(499, 125);
            this.PathGroupID.TabIndex = 0;
            this.PathGroupID.TabStop = false;
            this.PathGroupID.Text = "Vcpkg选择目录";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(6, 30);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(71, 12);
            this.PathLabel.TabIndex = 0;
            this.PathLabel.Text = "Vcpkg Path:";
            // 
            // txtPathVcpkg
            // 
            this.txtPathVcpkg.Location = new System.Drawing.Point(83, 26);
            this.txtPathVcpkg.Name = "txtPathVcpkg";
            this.txtPathVcpkg.Size = new System.Drawing.Size(325, 21);
            this.txtPathVcpkg.TabIndex = 1;
            // 
            // btnSelPath
            // 
            this.btnSelPath.Location = new System.Drawing.Point(414, 25);
            this.btnSelPath.Name = "btnSelPath";
            this.btnSelPath.Size = new System.Drawing.Size(75, 23);
            this.btnSelPath.TabIndex = 2;
            this.btnSelPath.Text = "...";
            this.btnSelPath.UseVisualStyleBackColor = true;
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(364, 63);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(125, 23);
            this.btnSetup.TabIndex = 3;
            this.btnSetup.Text = "安装";
            this.btnSetup.UseVisualStyleBackColor = true;
            // 
            // TipLabel
            // 
            this.TipLabel.AutoSize = true;
            this.TipLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TipLabel.Location = new System.Drawing.Point(6, 98);
            this.TipLabel.Name = "TipLabel";
            this.TipLabel.Size = new System.Drawing.Size(317, 12);
            this.TipLabel.TabIndex = 4;
            this.TipLabel.Text = "提示:如果该目录下不存在Vcpkg会自动使用git安装Vcpkg。";
            // 
            // SetupVcpkgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 146);
            this.Controls.Add(this.PathGroupID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SetupVcpkgFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "安装Vcpkg";
            this.PathGroupID.ResumeLayout(false);
            this.PathGroupID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PathGroupID;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.FolderBrowserDialog vcpkgFBDialog;
        private System.Windows.Forms.TextBox txtPathVcpkg;
        private System.Windows.Forms.Button btnSelPath;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label TipLabel;
    }
}