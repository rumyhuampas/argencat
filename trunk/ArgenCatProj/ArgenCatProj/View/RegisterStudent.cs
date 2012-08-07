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
    public partial class FRegisterStudent : Form
    {
        private RegisterStudent _controller;
        private student _student;

        public FRegisterStudent(student stdnt)
        {
            InitializeComponent();
            _controller = new RegisterStudent();
            _student = stdnt;
        }

        private void FRegisterStudent_Load(object sender, EventArgs e)
        {
            cboxCourses.Items.AddRange(_controller.GetCourses().ToArray());
            if (cboxCourses.Items.Count > 0)
            {
                cboxCourses.SelectedItem = cboxCourses.Items[0];
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_controller.Register(_student, cboxCourses.SelectedItem.ToString()))
            {
                _student = _controller.GetStudentData(_student.Id);
                if (MessageBox.Show("Estudiante inscripto. Desea inscribir el estudiante a otro curso?", "Inscribir a Curso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}
