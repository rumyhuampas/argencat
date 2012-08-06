using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArgenCatProj.Model;
using ArgenCatProj.Controller;

namespace ArgenCatProj.View
{
    public partial class FLogin : Form
    {
        private Login _controller;

        public FLogin()
        {
            InitializeComponent();
            _controller = new Login();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_controller.CheckFields(txtUser.Text, txtPass.Text))
            {
                if (_controller.CheckLogin(txtUser.Text, txtPass.Text))
                {
                    _controller.UpdateCurrentUser(txtUser.Text, txtPass.Text);
                    this.Close();
                }
                else
                {
                    lblError.Text = "Usuario o password incorrectos.";
                }
            }
            else
            {
                lblError.Text = "Debe completar todos los campos.";
            }
            lblError.Visible = true;
            txtPass.Clear();
            txtUser.SelectAll();
            txtUser.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
