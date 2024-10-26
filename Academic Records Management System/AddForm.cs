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
    public partial class AddForm : UIForm
    {
        public Student student { get; set; } = new Student();
        public AddForm()
        {
            InitializeComponent();
            // 字符串数组作为数据源
            string[] items = { "男", "女" };
            SexTxt.DataSource = items;

            // 使用List<string>作为数据源
            //List<string> itemList = new List<string> { "男", "女" };
            //SexTxt.DataSource = itemList;
            DateTimeNow();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            student.Name = NameTxt.Text;
            student.Sex = SexTxt.Text;
            student.Number = NumberTxt.Text;
            student.Major = MajorTxt.Text;
            student.ClassNumber = ClassNumberTxt.Text;
            student.Telephne = TelephneTxt.Text;
            student.Address = AddressTxt.Text;
            student.EnrolDate = EnrolDate.Value;
            student.InsertDate = InsertDate.Value;
            student.GraduateDate = GraduateDate.Value;

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            NameTxt.Text = string.Empty;
            SexTxt.SelectedIndex = 0;
            NumberTxt.Text = string.Empty;
            MajorTxt.Text = string.Empty;
            ClassNumberTxt.Text = string.Empty;
            TelephneTxt.Text = string.Empty;
            AddressTxt.Text = string.Empty;
            DateTimeNow();
        }
        private void DateTimeNow()
        {
            EnrolDate.Value = DateTime.Now;
            InsertDate.Value = DateTime.Now;
            DateTime currentTime = DateTime.Now; // 获取当前时间
            GraduateDate.Value = currentTime.AddYears(4); // 当前时间增加四年
        }
    }
}
