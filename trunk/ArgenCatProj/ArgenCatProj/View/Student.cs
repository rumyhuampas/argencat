using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArgenCatProj.Controller;
using ArgenCatProj.Model;

namespace ArgenCatProj.View
{
    public partial class FStudent : Form
    {
        private Student _controller;
        private student _student;

        public FStudent(student stdnt)
        {
            InitializeComponent();
            _controller = new Student(stdnt);
            _student = stdnt;
        }

        private void FStudent_Load(object sender, EventArgs e)
        {
            LoadStudent();
            LoadTree();
        }

        private void LoadStudent()
        {
            txtNumber.Text = _student.Number.ToString();
            txtName.Text = _student.Name;
            txtDni.Text = _student.Dni;
            txtAddress.Text = _student.Address;
            txtPhone.Text = _student.Phone;
            txtPhone2.Text = _student.Phone2;
        }

        private void LoadTree()
        {
            TreeNode root = new TreeNode(FMain.COURSES, 0, 1);
            foreach (student_courses sc in _student.student_courses)
            {
                TreeNode course = new TreeNode(sc.course.Name, 2, 3);
                root.Nodes.Add(course);
            }
            treeStudent.Nodes.Add(root);
            treeStudent.ExpandAll();
            treeStudent.SelectedNode = root;
        }

        private void treeStudent_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level != 0)
            {
                dgvStudent.DataSource = _controller.GetCursePayments(e.Node.Text);
                dgvStudent.Columns[0].Visible = false;
                dgvStudent.Columns[1].Visible = false;
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                imageCol.Name = "imageCol";
                imageCol.HeaderText = "Payed";
                dgvStudent.Columns.Add(imageCol);
                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "1")
                    {
                        row.Cells["imageCol"].Value = imgTreeStudent.Images["select.png"];
                    }
                    else
                    {
                        row.Cells["imageCol"].Value = imgTreeStudent.Images["stop.png"];
                    }
                }
            }
        }

        private void miAddCourse_Click(object sender, EventArgs e)
        {
            FRegisterStudent regStudent = new FRegisterStudent(_student);
            regStudent.ShowDialog(this);
        }
    }
}
