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
    public partial class FNewPayment : Form
    {
        private NewPayment _controller;
        private payment _payment;

        public FNewPayment(payment pmnt)
        {
            InitializeComponent();
            _controller = new NewPayment();
            _payment = pmnt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FNewPayment_Load(object sender, EventArgs e)
        {
            txtNumber.Text = _payment.Number.ToString();
            nudRecipNumber.Text = _payment.RecipNumber.ToString();
            txtAmount.Text = _payment.Amount.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (_controller.CheckFields(nudRecipNumber.Value, txtAmount.Text))
            {
                if (_controller.SavePayment(_payment.Id, nudRecipNumber.Value, txtAmount.Text))
                {
                    MessageBox.Show("Pago guardado.", "Nuevo Pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe completar el 'numero de recibo y cantidad a pagar' del pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
