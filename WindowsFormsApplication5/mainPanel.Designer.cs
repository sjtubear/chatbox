namespace WindowsFormsApplication5
{
    partial class Formmain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.butCreat = new System.Windows.Forms.Button();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.userList = new System.Windows.Forms.TextBox();
            this.lblOnline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCreat
            // 
            this.butCreat.Font = new System.Drawing.Font("Verdana Ref", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreat.Location = new System.Drawing.Point(185, 12);
            this.butCreat.Name = "butCreat";
            this.butCreat.Size = new System.Drawing.Size(101, 47);
            this.butCreat.TabIndex = 0;
            this.butCreat.Text = "CREATE";
            this.butCreat.UseVisualStyleBackColor = true;
            this.butCreat.Click += new System.EventHandler(this.butCreat_Click);
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Verdana Ref", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(15, 22);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(151, 31);
            this.textUserName.TabIndex = 1;
            // 
            // userList
            // 
            this.userList.BackColor = System.Drawing.Color.Silver;
            this.userList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userList.Location = new System.Drawing.Point(0, 88);
            this.userList.Multiline = true;
            this.userList.Name = "userList";
            this.userList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userList.Size = new System.Drawing.Size(315, 207);
            this.userList.TabIndex = 2;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOnline.Location = new System.Drawing.Point(12, 69);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(107, 16);
            this.lblOnline.TabIndex = 3;
            this.lblOnline.Text = "USER ONLINE";
            // 
            // Formmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 295);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.butCreat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formmain";
            this.Text = "Control PANEL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formmain_FormClosing);
            this.Load += new System.EventHandler(this.Formmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCreat;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox userList;
        private System.Windows.Forms.Label lblOnline;
    }
}

