namespace ArgenCatProj.View
{
    partial class FNewPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxPaymentData = new System.Windows.Forms.GroupBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRecipNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudRecipNumber = new System.Windows.Forms.NumericUpDown();
            this.gboxPaymentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxPaymentData
            // 
            this.gboxPaymentData.Controls.Add(this.nudRecipNumber);
            this.gboxPaymentData.Controls.Add(this.txtAmount);
            this.gboxPaymentData.Controls.Add(this.lblAmount);
            this.gboxPaymentData.Controls.Add(this.lblRecipNumber);
            this.gboxPaymentData.Controls.Add(this.txtNumber);
            this.gboxPaymentData.Controls.Add(this.lblNumber);
            this.gboxPaymentData.Location = new System.Drawing.Point(12, 12);
            this.gboxPaymentData.Name = "gboxPaymentData";
            this.gboxPaymentData.Size = new System.Drawing.Size(260, 104);
            this.gboxPaymentData.TabIndex = 0;
            this.gboxPaymentData.TabStop = false;
            this.gboxPaymentData.Text = "Datos";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(111, 71);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(143, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 74);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(91, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Cantidad a pagar:";
            // 
            // lblRecipNumber
            // 
            this.lblRecipNumber.AutoSize = true;
            this.lblRecipNumber.Location = new System.Drawing.Point(6, 48);
            this.lblRecipNumber.Name = "lblRecipNumber";
            this.lblRecipNumber.Size = new System.Drawing.Size(99, 13);
            this.lblRecipNumber.TabIndex = 2;
            this.lblRecipNumber.Text = "Numero de Recibo:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(111, 19);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(143, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Numero:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(116, 122);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 122);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // nudRecipNumber
            // 
            this.nudRecipNumber.Location = new System.Drawing.Point(111, 45);
            this.nudRecipNumber.Name = "nudRecipNumber";
            this.nudRecipNumber.Size = new System.Drawing.Size(143, 20);
            this.nudRecipNumber.TabIndex = 6;
            // 
            // FNewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gboxPaymentData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FNewPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Pago";
            this.Load += new System.EventHandler(this.FNewPayment_Load);
            this.gboxPaymentData.ResumeLayout(false);
            this.gboxPaymentData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecipNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPaymentData;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRecipNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudRecipNumber;
    }
}