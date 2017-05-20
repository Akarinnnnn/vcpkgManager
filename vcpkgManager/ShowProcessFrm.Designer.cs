namespace vcpkgManager
{
    partial class ShowProcessFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClosed = new System.Windows.Forms.Button();
            this.runLogs = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.runLogs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运行日志";
            // 
            // btnClosed
            // 
            this.btnClosed.Location = new System.Drawing.Point(393, 389);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(172, 23);
            this.btnClosed.TabIndex = 1;
            this.btnClosed.Text = "取消运行";
            this.btnClosed.UseVisualStyleBackColor = true;
            // 
            // runLogs
            // 
            this.runLogs.Location = new System.Drawing.Point(6, 20);
            this.runLogs.Multiline = true;
            this.runLogs.Name = "runLogs";
            this.runLogs.ReadOnly = true;
            this.runLogs.Size = new System.Drawing.Size(541, 344);
            this.runLogs.TabIndex = 0;
            // 
            // ShowProcessFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 424);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowProcessFrm";
            this.Text = "程序运行中...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.TextBox runLogs;
    }
}