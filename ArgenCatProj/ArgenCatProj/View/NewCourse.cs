using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArgenCatProj.Controller;

namespace ArgenCatProj.View
{
    public partial class FNewCourse : Form
    {
        private NewCourse controller;

        public FNewCourse()
        {
            InitializeComponent();
            controller = new NewCourse();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (controller.CheckFields(txtName.Text))
            {
                if(controller.SaveCourse(txtName.Text)){
                    if (MessageBox.Show("Curso guardado. Desea guardar otro?", "Nuevo Curso",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        txtName.Clear();
                        txtName.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar el 'nombre' del curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
        }
    }
}
