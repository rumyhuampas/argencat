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
    public partial class FNewUser : Form
    {
        NewUser _controller;

        public FNewUser()
        {
            InitializeComponent();
            _controller = new NewUser();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_controller.CheckFields(txtName.Text, txtPass.Text, txtPass2.Text))
            {
                if (_controller.CheckEqualPass(txtPass.Text, txtPass2.Text))
                {
                    if (_controller.SaveUser(txtName.Text, txtPass.Text))
                    {
                        if (MessageBox.Show("Ususario guardado. Desea guardar otro?", "Nuevo Usuario",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            txtName.Clear();
                            txtPass.Clear();
                            txtPass2.Clear();
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
                    MessageBox.Show("Las contraseñas deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
        }
    }
}
