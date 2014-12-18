namespace WindowsFormsApplication5
{
    partial class userPanel
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textChat = new System.Windows.Forms.TextBox();
            this.butSend = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.formmainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formmainBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.formmainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formmainBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 29);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textChat
            // 
            this.textChat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textChat.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textChat.ForeColor = System.Drawing.Color.White;
            this.textChat.Location = new System.Drawing.Point(12, 176);
            this.textChat.Multiline = true;
            this.textChat.Name = "textChat";
            this.textChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textChat.Size = new System.Drawing.Size(426, 251);
            this.textChat.TabIndex = 4;
            this.textChat.TextChanged += new System.EventHandler(this.textChat_TextChanged);
            // 
            // butSend
            // 
            this.butSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butSend.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butSend.ForeColor = System.Drawing.Color.Black;
            this.butSend.Location = new System.Drawing.Point(83, 96);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(263, 41);
            this.butSend.TabIndex = 5;
            this.butSend.Text = "send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.messageBox.Location = new System.Drawing.Point(108, 24);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(238, 26);
            this.messageBox.TabIndex = 6;
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tell";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(103, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "TO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(199, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "I am";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formmainBindingSource
            // 
            this.formmainBindingSource.DataSource = typeof(WindowsFormsApplication5.Formmain);
            // 
            // formmainBindingSource1
            // 
            this.formmainBindingSource1.DataSource = typeof(WindowsFormsApplication5.Formmain);
            // 
            // userPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.textChat);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "userPanel";
            this.Text = "userPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userPanel_FormClosing);
            this.Load += new System.EventHandler(this.userPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.formmainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formmainBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource formmainBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource formmainBindingSource1;
        private System.Windows.Forms.TextBox textChat;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

    }
}