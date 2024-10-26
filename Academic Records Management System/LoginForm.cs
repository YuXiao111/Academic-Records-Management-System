using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;


namespace Academic_Records_Management_System
{
    public partial class LoginForm : UIForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserTxtBox.Text))
            {
                MessageBox.Show("用户名不能为空", "提示");
                return;
            }
            if (string.IsNullOrWhiteSpace(PsdTxtBox.Text))
            {
                MessageBox.Show("密码不能为空", "提示");
                return;
            }
            //它是一个数据上下文，它代表整个数据库
            StudentInfoDBEntities1 studentInfoDBEntities = new StudentInfoDBEntities1();
            var list = studentInfoDBEntities.User.ToList();
            var model = list.FirstOrDefault(t => t.Name.Equals(UserTxtBox.Text)&& t.Password.Equals(PsdTxtBox.Text));
            if( model != null )
            {
                //DialogResult = DialogResult.OK;
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "提示");
            }
        }

        /// <summary>
        /// 选中显示密码，不选中隐藏密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PwdCB_CheckedChanged(object sender, EventArgs e)
        {
            if(PwdCB.Checked)
            {
                PsdTxtBox.PasswordChar = '\0';
            }
            else
            {
                PsdTxtBox.PasswordChar = '*';
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PsdTxtBox.PasswordChar = '*';
        }
    }
}
