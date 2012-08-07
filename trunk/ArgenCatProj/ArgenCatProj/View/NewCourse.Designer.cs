namespace ArgenCatProj.View
{
    partial class FNewCourse
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
            this.gboxData = new System.Windows.Forms.GroupBox();
            this.nudPCount = new System.Windows.Forms.NumericUpDown();
            this.lblPCount = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxData
            // 
            this.gboxData.Controls.Add(this.nudPCount);
            this.gboxData.Controls.Add(this.lblPCount);
            this.gboxData.Controls.Add(this.txtName);
            this.gboxData.Controls.Add(this.lblName);
            this.gboxData.Location = new System.Drawing.Point(12, 12);
            this.gboxData.Name = "gboxData";
            this.gboxData.Size = new System.Drawing.Size(293, 80);
            this.gboxData.TabIndex = 0;
            this.gboxData.TabStop = false;
            this.gboxData.Text = "Datos";
            // 
            // nudPCount
            // 
            this.nudPCount.Location = new System.Drawing.Point(114, 45);
            this.nudPCount.Name = "nudPCount";
            this.nudPCount.Size = new System.Drawing.Size(46, 20);
            this.nudPCount.TabIndex = 3;
            // 
            // lblPCount
            // 
            this.lblPCount.AutoSize = true;
            this.lblPCount.Location = new System.Drawing.Point(6, 47);
            this.lblPCount.Name = "lblPCount";
            this.lblPCount.Size = new System.Drawing.Size(102, 13);
            this.lblPCount.TabIndex = 2;
            this.lblPCount.Text = "Cantidad de coutas:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(149, 98);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 133);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gboxData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FNewCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Curso";
            this.gboxData.ResumeLayout(false);
            this.gboxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudPCount;
        private System.Windows.Forms.Label lblPCount;
    }
}