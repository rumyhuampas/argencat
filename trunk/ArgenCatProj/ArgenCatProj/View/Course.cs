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
    public partial class FCourse : Form
    {
        private Course _controller;
        private course _course;

        public FCourse(course crs)
        {
            InitializeComponent();
            _controller = new Course();
            _course = crs;
        }

        private void FCourse_Load(object sender, EventArgs e)
        {
            LoadCourse();
            LoadGrid();
        }

        private void LoadCourse()
        {
            txtName.Text = _course.Name;
        }

        private void LoadGrid()
        {
            dgvStudents.Columns.Clear();
            dgvStudents.DataSource = _controller.GetCourseStudents(_course);
        }
    }
}
