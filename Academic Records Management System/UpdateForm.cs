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
    public partial class UpdateForm : UIForm
    {
        public Student UpdateStudent = null;
        public UpdateForm(Student student)
        {
            InitializeComponent(); UpdateStudent = student;
            Load += UpdateStudentForm_Load;
        }

        private void UpdateStudentForm_Load(object sender, EventArgs e)
        {
            // 字符串数组作为数据源
            string[] items = { "男", "女" };
            SexTxt.DataSource = items;
            if (UpdateStudent != null)
            {
                NameTxt.Text = UpdateStudent.Name;


                NumberTxt.Text = UpdateStudent.Number;
                MajorTxt.Text = UpdateStudent.Major;
                ClassNumberTxt.Text = UpdateStudent.ClassNumber;
                TelephneTxt.Text = UpdateStudent.Telephne;
                AddressTxt.Text = UpdateStudent.Address;
                EnrolDate.Value = (DateTime)UpdateStudent.EnrolDate;
                InsertDate.Value = (DateTime)UpdateStudent.InsertDate;
                GraduateDate.Value = (DateTime)UpdateStudent.GraduateDate;

                SexTxt.Text = UpdateStudent.Sex;


                //DialogResult = DialogResult.OK;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            UpdateStudent.Name = NameTxt.Text;
            UpdateStudent.Sex = SexTxt.Text;
            UpdateStudent.Number = NumberTxt.Text;
            UpdateStudent.Major = MajorTxt.Text;
            UpdateStudent.ClassNumber = ClassNumberTxt.Text;
            UpdateStudent.Telephne = TelephneTxt.Text;
            UpdateStudent.Address = AddressTxt.Text;
            UpdateStudent.EnrolDate = EnrolDate.Value;
            UpdateStudent.InsertDate = InsertDate.Value;
            UpdateStudent.GraduateDate = GraduateDate.Value;

            DialogResult = DialogResult.OK;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            NameTxt.Text = string.Empty;
            //SexTxt.SelectedIndex = 0;
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
