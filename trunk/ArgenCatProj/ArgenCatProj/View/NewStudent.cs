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
    public partial class FNewStudent : Form
    {
        private NewStudent _controller;

        public FNewStudent()
        {
            InitializeComponent();
            _controller = new NewStudent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete && !char.IsNumber(e.KeyChar))
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_controller.CheckFields(txtNumber.Text, txtName.Text, txtDni.Text, txtAddress.Text, txtPhone.Text, txtPhone2.Text))
            {
                if (_controller.SaveStudent(txtNumber.Text, txtName.Text, txtDni.Text, txtAddress.Text, txtPhone.Text, txtPhone2.Text))
                {
                    if (MessageBox.Show("Estudiante guardado. Desea guardar otro?", "Nuevo Estudiante",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        txtNumber.Clear();
                        txtName.Clear();
                        txtDni.Clear();
                        txtAddress.Clear();
                        txtPhone.Clear();
                        txtPhone2.Clear();
                        txtNumber.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar el 'numero, nombre y dni' del estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
            }
        }
    }
}
