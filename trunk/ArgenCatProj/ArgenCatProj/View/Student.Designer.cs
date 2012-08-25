namespace ArgenCatProj.View
{
    partial class FStudent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FStudent));
            this.gboxStudentData = new System.Windows.Forms.GroupBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.splitStudent = new System.Windows.Forms.SplitContainer();
            this.treeStudent = new System.Windows.Forms.TreeView();
            this.cmenuTreeStudent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imgTreeStudent = new System.Windows.Forms.ImageList(this.components);
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.statusStudent = new System.Windows.Forms.StatusStrip();
            this.miAddCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsslblLegend = new System.Windows.Forms.ToolStripStatusLabel();
            this.gboxStudentData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitStudent)).BeginInit();
            this.splitStudent.Panel1.SuspendLayout();
            this.splitStudent.Panel2.SuspendLayout();
            this.splitStudent.SuspendLayout();
            this.cmenuTreeStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.statusStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxStudentData
            // 
            this.gboxStudentData.Controls.Add(this.txtPhone2);
            this.gboxStudentData.Controls.Add(this.lblPhone2);
            this.gboxStudentData.Controls.Add(this.txtPhone);
            this.gboxStudentData.Controls.Add(this.lblPhone);
            this.gboxStudentData.Controls.Add(this.txtAddress);
            this.gboxStudentData.Controls.Add(this.lblAddress);
            this.gboxStudentData.Controls.Add(this.txtDni);
            this.gboxStudentData.Controls.Add(this.lblDni);
            this.gboxStudentData.Controls.Add(this.txtName);
            this.gboxStudentData.Controls.Add(this.lblName);
            this.gboxStudentData.Controls.Add(this.txtNumber);
            this.gboxStudentData.Controls.Add(this.lblNumber);
            this.gboxStudentData.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboxStudentData.Location = new System.Drawing.Point(10, 10);
            this.gboxStudentData.Name = "gboxStudentData";
            this.gboxStudentData.Size = new System.Drawing.Size(664, 106);
            this.gboxStudentData.TabIndex = 0;
            this.gboxStudentData.TabStop = false;
            this.gboxStudentData.Text = "Estudiante";
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(380, 45);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.ReadOnly = true;
            this.txtPhone2.Size = new System.Drawing.Size(200, 20);
            this.txtPhone2.TabIndex = 11;
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Location = new System.Drawing.Point(313, 48);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(61, 13);
            this.lblPhone2.TabIndex = 10;
            this.lblPhone2.Text = "Telefono 2:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(380, 19);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(313, 22);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Telefono:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(380, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(313, 74);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Direccion:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(107, 71);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(200, 20);
            this.txtDni.TabIndex = 5;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 74);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 4;
            this.lblDni.Text = "DNI:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 45);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Apellido y Nombre:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(107, 19);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.ReadOnly = true;
            this.txtNumber.Size = new System.Drawing.Size(200, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(42, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Legajo:";
            // 
            // splitStudent
            // 
            this.splitStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitStudent.Location = new System.Drawing.Point(10, 116);
            this.splitStudent.Name = "splitStudent";
            // 
            // splitStudent.Panel1
            // 
            this.splitStudent.Panel1.Controls.Add(this.treeStudent);
            // 
            // splitStudent.Panel2
            // 
            this.splitStudent.Panel2.Controls.Add(this.dgvStudent);
            this.splitStudent.Size = new System.Drawing.Size(664, 264);
            this.splitStudent.SplitterDistance = 221;
            this.splitStudent.TabIndex = 1;
            // 
            // treeStudent
            // 
            this.treeStudent.ContextMenuStrip = this.cmenuTreeStudent;
            this.treeStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeStudent.ImageIndex = 0;
            this.treeStudent.ImageList = this.imgTreeStudent;
            this.treeStudent.Location = new System.Drawing.Point(0, 0);
            this.treeStudent.Name = "treeStudent";
            this.treeStudent.SelectedImageIndex = 0;
            this.treeStudent.Size = new System.Drawing.Size(221, 264);
            this.treeStudent.TabIndex = 0;
            this.treeStudent.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeStudent_AfterSelect);
            // 
            // cmenuTreeStudent
            // 
            this.cmenuTreeStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddCourse});
            this.cmenuTreeStudent.Name = "cmenuTreeStudent";
            this.cmenuTreeStudent.Size = new System.Drawing.Size(160, 26);
            // 
            // imgTreeStudent
            // 
            this.imgTreeStudent.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeStudent.ImageStream")));
            this.imgTreeStudent.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeStudent.Images.SetKeyName(0, "couse_grey.png");
            this.imgTreeStudent.Images.SetKeyName(1, "course_color.png");
            this.imgTreeStudent.Images.SetKeyName(2, "control_play.png");
            this.imgTreeStudent.Images.SetKeyName(3, "control_play_blue.png");
            this.imgTreeStudent.Images.SetKeyName(4, "select.png");
            this.imgTreeStudent.Images.SetKeyName(5, "stop.png");
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(439, 264);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.DataSourceChanged += new System.EventHandler(this.dgvStudent_DataSourceChanged);
            this.dgvStudent.DoubleClick += new System.EventHandler(this.dgvStudent_DoubleClick);
            // 
            // statusStudent
            // 
            this.statusStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblLegend});
            this.statusStudent.Location = new System.Drawing.Point(10, 380);
            this.statusStudent.Name = "statusStudent";
            this.statusStudent.Size = new System.Drawing.Size(664, 22);
            this.statusStudent.TabIndex = 3;
            this.statusStudent.Text = "statusStrip1";
            // 
            // miAddCourse
            // 
            this.miAddCourse.Image = global::ArgenCatProj.Properties.Resources.list_add;
            this.miAddCourse.Name = "miAddCourse";
            this.miAddCourse.Size = new System.Drawing.Size(159, 22);
            this.miAddCourse.Text = "Inscribir a Curso";
            this.miAddCourse.Click += new System.EventHandler(this.miAddCourse_Click);
            // 
            // tsslblLegend
            // 
            this.tsslblLegend.Name = "tsslblLegend";
            this.tsslblLegend.Size = new System.Drawing.Size(0, 17);
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.splitStudent);
            this.Controls.Add(this.gboxStudentData);
            this.Controls.Add(this.statusStudent);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FStudent";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estudiante";
            this.Load += new System.EventHandler(this.FStudent_Load);
            this.gboxStudentData.ResumeLayout(false);
            this.gboxStudentData.PerformLayout();
            this.splitStudent.Panel1.ResumeLayout(false);
            this.splitStudent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitStudent)).EndInit();
            this.splitStudent.ResumeLayout(false);
            this.cmenuTreeStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.statusStudent.ResumeLayout(false);
            this.statusStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxStudentData;
        private System.Windows.Forms.SplitContainer splitStudent;
        private System.Windows.Forms.TreeView treeStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ImageList imgTreeStudent;
        private System.Windows.Forms.ContextMenuStrip cmenuTreeStudent;
        private System.Windows.Forms.ToolStripMenuItem miAddCourse;
        private System.Windows.Forms.StatusStrip statusStudent;
        private System.Windows.Forms.ToolStripStatusLabel tsslblLegend;
    }
}