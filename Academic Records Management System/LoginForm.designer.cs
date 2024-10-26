namespace Academic_Records_Management_System
{
    partial class LoginForm
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
            this.UserTxt = new Sunny.UI.UILabel();
            this.PasswrdTxt = new Sunny.UI.UILabel();
            this.UserTxtBox = new Sunny.UI.UITextBox();
            this.PsdTxtBox = new Sunny.UI.UITextBox();
            this.BtnLogin = new Sunny.UI.UIButton();
            this.PwdCB = new Sunny.UI.UICheckBox();
            this.SuspendLayout();
            // 
            // UserTxt
            // 
            this.UserTxt.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserTxt.Location = new System.Drawing.Point(158, 105);
            this.UserTxt.Name = "UserTxt";
            this.UserTxt.Size = new System.Drawing.Size(125, 64);
            this.UserTxt.TabIndex = 0;
            this.UserTxt.Text = "用户名：";
            this.UserTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswrdTxt
            // 
            this.PasswrdTxt.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PasswrdTxt.Location = new System.Drawing.Point(158, 196);
            this.PasswrdTxt.Name = "PasswrdTxt";
            this.PasswrdTxt.Size = new System.Drawing.Size(125, 64);
            this.PasswrdTxt.TabIndex = 1;
            this.PasswrdTxt.Text = "密   码：";
            this.PasswrdTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserTxtBox
            // 
            this.UserTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTxtBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserTxtBox.Location = new System.Drawing.Point(268, 116);
            this.UserTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserTxtBox.MaxLength = 20;
            this.UserTxtBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.UserTxtBox.Name = "UserTxtBox";
            this.UserTxtBox.Padding = new System.Windows.Forms.Padding(5);
            this.UserTxtBox.ShowText = false;
            this.UserTxtBox.Size = new System.Drawing.Size(276, 46);
            this.UserTxtBox.TabIndex = 2;
            this.UserTxtBox.Text = "admin";
            this.UserTxtBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserTxtBox.Watermark = "";
            // 
            // PsdTxtBox
            // 
            this.PsdTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PsdTxtBox.DoubleValue = 123456D;
            this.PsdTxtBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PsdTxtBox.IntValue = 123456;
            this.PsdTxtBox.Location = new System.Drawing.Point(268, 211);
            this.PsdTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PsdTxtBox.MaxLength = 20;
            this.PsdTxtBox.MinimumSize = new System.Drawing.Size(1, 16);
            this.PsdTxtBox.Name = "PsdTxtBox";
            this.PsdTxtBox.Padding = new System.Windows.Forms.Padding(5);
            this.PsdTxtBox.ShowText = false;
            this.PsdTxtBox.Size = new System.Drawing.Size(276, 46);
            this.PsdTxtBox.TabIndex = 3;
            this.PsdTxtBox.Text = "123456";
            this.PsdTxtBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PsdTxtBox.Watermark = "";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(268, 314);
            this.BtnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(228, 57);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "登     录";
            this.BtnLogin.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PwdCB
            // 
            this.PwdCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PwdCB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PwdCB.Location = new System.Drawing.Point(551, 220);
            this.PwdCB.MinimumSize = new System.Drawing.Size(1, 1);
            this.PwdCB.Name = "PwdCB";
            this.PwdCB.Size = new System.Drawing.Size(106, 37);
            this.PwdCB.TabIndex = 1;
            this.PwdCB.Text = "显示密码";
            this.PwdCB.CheckedChanged += new System.EventHandler(this.PwdCB_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(746, 452);
            this.Controls.Add(this.PwdCB);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PsdTxtBox);
            this.Controls.Add(this.UserTxtBox);
            this.Controls.Add(this.PasswrdTxt);
            this.Controls.Add(this.UserTxt);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "用户登录";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel UserTxt;
        private Sunny.UI.UILabel PasswrdTxt;
        private Sunny.UI.UITextBox UserTxtBox;
        private Sunny.UI.UITextBox PsdTxtBox;
        private Sunny.UI.UIButton BtnLogin;
        private Sunny.UI.UICheckBox PwdCB;
    }
}