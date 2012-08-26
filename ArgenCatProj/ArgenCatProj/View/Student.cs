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
            _controller = new Student();
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
            foreach (student_course_paymentplan sc in _student.student_course_paymentplan)
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
                dgvStudent.Columns.Clear();
                dgvStudent.DataSource = _controller.GetCoursePayments(_student, e.Node.Text);
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

            _student = _controller.GetStudentData(_student.Id);
            treeStudent.Nodes.Clear();
            LoadTree();
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudent.SelectedRows.Count > 0)
            {
                FNewPayment np = new FNewPayment(_controller.GetPaymentData(Convert.ToInt32(dgvStudent.SelectedRows[0].Cells[0].Value)));
                np.ShowDialog(this);
                treeStudent_AfterSelect(this, new TreeViewEventArgs(treeStudent.SelectedNode));
            }
        }

        private void dgvStudent_DataSourceChanged(object sender, EventArgs e)
        {
            int payed = 0;
            int notPayed = 0;
            foreach(DataGridViewRow row in dgvStudent.Rows){
                if (row.Cells[1].Value.ToString() == "1"){
                    payed++;
                }
                else{
                    notPayed++;
                }
            }
            tsslblLegend.Text = "Cuotas pagadas: " + payed.ToString() + " - Coutas adeudadas: " + notPayed.ToString();
        }
    }
}
