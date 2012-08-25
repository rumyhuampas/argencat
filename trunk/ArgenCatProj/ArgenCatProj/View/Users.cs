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
    public partial class FUsers : Form
    {
        private Users _controller;

        public FUsers()
        {
            InitializeComponent();
            _controller = new Users();
        }

        private void FUsers_Load(object sender, EventArgs e)
        {
            dgvUsers.Columns.Clear();
            dgvUsers.DataSource = _controller.GetUsers();
        }

        private void cmitemNew_Click(object sender, EventArgs e)
        {
            FNewUser newUser = new FNewUser();
            newUser.ShowDialog(this);
            FUsers_Load(this, e);
        }
    }
}
