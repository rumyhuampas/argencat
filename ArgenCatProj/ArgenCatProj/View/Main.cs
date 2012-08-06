﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArgenCatProj.Model;
using ArgenCatProj.View;
using ArgenCatProj.Controller;

namespace ArgenCatProj
{
    public partial class FMain : Form
    {
        public static user CurrentUser;
        private Main _controller;

        public const string COURSES = "Cursos";
        public const string STUDENTS = "Estudiantes";

        public FMain()
        {
            InitializeComponent();
            _controller = new Main();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            FLogin login = new FLogin();
            login.ShowDialog(this);
            if (CurrentUser == null)
            {
                Application.Exit();
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.ShowInTaskbar = true;

                LoadTree();
            }
        }

        private void LoadTree()
        {
            TreeNode root = new TreeNode("ArgenCat", 0, 0);
            TreeNode course = new TreeNode(COURSES, 1, 2);
            TreeNode student = new TreeNode(STUDENTS, 3, 4);
            root.Nodes.Add(course);
            root.Nodes.Add(student);

            treeMain.Nodes.Add(root);
            treeMain.ExpandAll();
            treeMain.SelectedNode = course;
        }

        private void treeMain_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == COURSES)
            {
                dgvMain.DataSource = _controller.GetAllCurses();
            }
            if (e.Node.Text == STUDENTS)
            {
                dgvMain.DataSource = _controller.GetAllStudents();
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMain.DataSource = _controller.FilterList(treeMain.SelectedNode.Text, txtSearch.Text);
            dgvMain.Columns[1].Visible = false;
        }

        private void dgvMain_DoubleClick(object sender, EventArgs e)
        {
            if (treeMain.SelectedNode.Text == STUDENTS)
            {
                FStudent student = new FStudent(_controller.GetStudent(Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value)));
                student.ShowDialog(this);
            }
        }
    }
}