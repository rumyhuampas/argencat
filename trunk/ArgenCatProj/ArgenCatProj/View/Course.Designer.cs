namespace ArgenCatProj.View
{
    partial class FCourse
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
            this.gboxCourseData = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.statusStudent = new System.Windows.Forms.StatusStrip();
            this.tsslblLegend = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.gboxCourseData.SuspendLayout();
            this.statusStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxCourseData
            // 
            this.gboxCourseData.Controls.Add(this.txtName);
            this.gboxCourseData.Controls.Add(this.lblName);
            this.gboxCourseData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxCourseData.Location = new System.Drawing.Point(0, 0);
            this.gboxCourseData.Name = "gboxCourseData";
            this.gboxCourseData.Size = new System.Drawing.Size(684, 54);
            this.gboxCourseData.TabIndex = 4;
            this.gboxCourseData.TabStop = false;
            this.gboxCourseData.Text = "Curso";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 19);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 20);
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
            // statusStudent
            // 
            this.statusStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblLegend});
            this.statusStudent.Location = new System.Drawing.Point(0, 390);
            this.statusStudent.Name = "statusStudent";
            this.statusStudent.Size = new System.Drawing.Size(684, 22);
            this.statusStudent.TabIndex = 6;
            this.statusStudent.Text = "statusStrip1";
            // 
            // tsslblLegend
            // 
            this.tsslblLegend.Name = "tsslblLegend";
            this.tsslblLegend.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AllowUserToResizeRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudents.Location = new System.Drawing.Point(0, 54);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(684, 336);
            this.dgvStudents.TabIndex = 7;
            // 
            // FCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.gboxCourseData);
            this.Controls.Add(this.statusStudent);
            this.Name = "FCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.FCourse_Load);
            this.gboxCourseData.ResumeLayout(false);
            this.gboxCourseData.PerformLayout();
            this.statusStudent.ResumeLayout(false);
            this.statusStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCourseData;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.StatusStrip statusStudent;
        private System.Windows.Forms.ToolStripStatusLabel tsslblLegend;
        private System.Windows.Forms.DataGridView dgvStudents;
    }
}