namespace WindowsForms4
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUsr = new System.Windows.Forms.TextBox();
            this.txbPwd = new System.Windows.Forms.TextBox();
            this.myDefaultBtn = new System.Windows.Forms.Button();
            this.myCancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码：";
            // 
            // txbUsr
            // 
            this.txbUsr.Location = new System.Drawing.Point(112, 57);
            this.txbUsr.Name = "txbUsr";
            this.txbUsr.Size = new System.Drawing.Size(100, 21);
            this.txbUsr.TabIndex = 2;
            this.txbUsr.TextChanged += new System.EventHandler(this.txbUsr_TextChanged);
            // 
            // txbPwd
            // 
            this.txbPwd.Location = new System.Drawing.Point(112, 106);
            this.txbPwd.Name = "txbPwd";
            this.txbPwd.Size = new System.Drawing.Size(100, 21);
            this.txbPwd.TabIndex = 3;
            // 
            // myDefaultBtn
            // 
            this.myDefaultBtn.Location = new System.Drawing.Point(32, 158);
            this.myDefaultBtn.Name = "myDefaultBtn";
            this.myDefaultBtn.Size = new System.Drawing.Size(75, 23);
            this.myDefaultBtn.TabIndex = 4;
            this.myDefaultBtn.Text = "登录";
            this.myDefaultBtn.UseVisualStyleBackColor = true;
            this.myDefaultBtn.Click += new System.EventHandler(this.myDefaultBtn_Click);
            // 
            // myCancelBtn
            // 
            this.myCancelBtn.Location = new System.Drawing.Point(158, 158);
            this.myCancelBtn.Name = "myCancelBtn";
            this.myCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.myCancelBtn.TabIndex = 5;
            this.myCancelBtn.Text = "重写";
            this.myCancelBtn.UseVisualStyleBackColor = true;
            this.myCancelBtn.Click += new System.EventHandler(this.myCancelBtn_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.myDefaultBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.myCancelBtn;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.myCancelBtn);
            this.Controls.Add(this.myDefaultBtn);
            this.Controls.Add(this.txbPwd);
            this.Controls.Add(this.txbUsr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUsr;
        private System.Windows.Forms.TextBox txbPwd;
        private System.Windows.Forms.Button myDefaultBtn;
        private System.Windows.Forms.Button myCancelBtn;
    }
}