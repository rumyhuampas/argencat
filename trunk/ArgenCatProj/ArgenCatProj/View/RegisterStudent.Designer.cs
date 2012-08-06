namespace ArgenCatProj.View
{
    partial class FRegisterStudent
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gboxCourses = new System.Windows.Forms.GroupBox();
            this.cboxCourses = new System.Windows.Forms.ComboBox();
            this.lblCourses = new System.Windows.Forms.Label();
            this.gboxCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(133, 71);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Aceptar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gboxCourses
            // 
            this.gboxCourses.Controls.Add(this.cboxCourses);
            this.gboxCourses.Controls.Add(this.lblCourses);
            this.gboxCourses.Location = new System.Drawing.Point(12, 12);
            this.gboxCourses.Name = "gboxCourses";
            this.gboxCourses.Size = new System.Drawing.Size(277, 53);
            this.gboxCourses.TabIndex = 4;
            this.gboxCourses.TabStop = false;
            this.gboxCourses.Text = "Cursos";
            // 
            // cboxCourses
            // 
            this.cboxCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCourses.FormattingEnabled = true;
            this.cboxCourses.Location = new System.Drawing.Point(54, 19);
            this.cboxCourses.Name = "cboxCourses";
            this.cboxCourses.Size = new System.Drawing.Size(217, 21);
            this.cboxCourses.TabIndex = 3;
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Location = new System.Drawing.Point(6, 22);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(42, 13);
            this.lblCourses.TabIndex = 2;
            this.lblCourses.Text = "Cursos:";
            // 
            // FRegisterStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 108);
            this.Controls.Add(this.gboxCourses);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRegisterStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inscribir a Curso";
            this.Load += new System.EventHandler(this.FRegisterStudent_Load);
            this.gboxCourses.ResumeLayout(false);
            this.gboxCourses.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gboxCourses;
        private System.Windows.Forms.ComboBox cboxCourses;
        private System.Windows.Forms.Label lblCourses;
    }
}