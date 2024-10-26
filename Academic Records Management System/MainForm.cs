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
    public partial class MainForm : UIForm
    {
        //它是一个数据上下文，它代表整个数据库
        StudentInfoDBEntities1 studentInfoDBEntities = new StudentInfoDBEntities1();
        public MainForm()
        {
            InitializeComponent();
            Load += FormMain_Load;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
        }

        /// <summary>
        /// 窗口关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要关闭系统吗？", "提示", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; // 取消窗口关闭操作
            }
            else
            {
                //强制关闭所有线程
                System.Environment.Exit(0);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //LoginForm loginForm = new LoginForm();
            //var result = loginForm.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    this.Show();
            //}

            GetDataSource();
        }

        /// <summary>
        /// 学籍录入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddForm addStudentForm = new AddForm();

            var result = addStudentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //向数据库插入一条学籍记录
                var Students = addStudentForm.student;

                //数据合法性验证
                if (string.IsNullOrWhiteSpace(Students.Name) || string.IsNullOrWhiteSpace(Students.Number) || string.IsNullOrWhiteSpace(Students.Telephne) || string.IsNullOrWhiteSpace(Students.Address) || string.IsNullOrWhiteSpace(Students.Major)
                    || string.IsNullOrWhiteSpace(Students.ClassNumber))
                {
                    MessageBox.Show("输入的内容不能有空！");
                    return;
                }


                studentInfoDBEntities.Student.Add(Students);
                int count = studentInfoDBEntities.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show($"{Students.Name}的学籍录入成功！");


                    //显示最新的数据
                    GetDataSource();
                    //StudentDataGridView.DataSource = studentInfoDBEntities.Student.ToList();

                }
                else
                {
                    MessageBox.Show("录入失败！");
                }
            }
        }

        /// <summary>
        /// 学籍修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            //new Form1(students).ShowDialog();
            //return;
               

            var list = StudentDataGridView.SelectedRows;

            if (list.Count == 0) return;
            var students = list[0].DataBoundItem as Student;

            UpdateForm updateStudentForm = new UpdateForm(students);
            var result = updateStudentForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                studentInfoDBEntities.Entry(updateStudentForm.UpdateStudent).State=System.Data.Entity.EntityState.Modified;
                var count=studentInfoDBEntities.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show($"{students.Name}的学籍更新成功！");
                    //显示最新的数据
                    GetDataSource();
                    //StudentDataGridView.DataSource = studentInfoDBEntities.Student.ToList();
                }
                else
                {
                    MessageBox.Show("更新失败！");
                }
                GetDataSource();
            }
        }

        /// <summary>
        /// 学籍删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var list = StudentDataGridView.SelectedRows;
            if (list.Count == 0) return;
            var students = list[0].DataBoundItem as Student;
            //删除确认
            if (MessageBox.Show($"确定要删除{students.Name}吗？","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
           
                studentInfoDBEntities.Entry(students).State = System.Data.Entity.EntityState.Deleted;
                int count = studentInfoDBEntities.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show($"删除成功！");
                    //显示最新的数据
                    GetDataSource();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }

            
        }

        /// <summary>
        /// 显示最新的数据
        /// </summary>
        private void GetDataSource()
        {
            StudentDataGridView.DataSource = studentInfoDBEntities.Student.ToList();
        }
    }
}
