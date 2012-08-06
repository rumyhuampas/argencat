namespace ArgenCatProj
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.treeMain = new System.Windows.Forms.TreeView();
            this.pnlMainDGV = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlMainSearch = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.toolMain = new System.Windows.Forms.ToolStrip();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.imgTreeMain = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlMainDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlMainSearch.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 49);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.treeMain);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.pnlMainDGV);
            this.splitMain.Panel2.Controls.Add(this.pnlMainSearch);
            this.splitMain.Size = new System.Drawing.Size(779, 401);
            this.splitMain.SplitterDistance = 258;
            this.splitMain.TabIndex = 8;
            // 
            // treeMain
            // 
            this.treeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMain.ImageIndex = 0;
            this.treeMain.ImageList = this.imgTreeMain;
            this.treeMain.Location = new System.Drawing.Point(0, 0);
            this.treeMain.Name = "treeMain";
            this.treeMain.SelectedImageIndex = 0;
            this.treeMain.Size = new System.Drawing.Size(258, 401);
            this.treeMain.TabIndex = 0;
            this.treeMain.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMain_AfterSelect);
            // 
            // pnlMainDGV
            // 
            this.pnlMainDGV.Controls.Add(this.dgvMain);
            this.pnlMainDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainDGV.Location = new System.Drawing.Point(0, 43);
            this.pnlMainDGV.Name = "pnlMainDGV";
            this.pnlMainDGV.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainDGV.Size = new System.Drawing.Size(517, 358);
            this.pnlMainDGV.TabIndex = 2;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(15, 15);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(487, 328);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.DoubleClick += new System.EventHandler(this.dgvMain_DoubleClick);
            // 
            // pnlMainSearch
            // 
            this.pnlMainSearch.Controls.Add(this.txtSearch);
            this.pnlMainSearch.Controls.Add(this.lblSearch);
            this.pnlMainSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlMainSearch.Name = "pnlMainSearch";
            this.pnlMainSearch.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMainSearch.Size = new System.Drawing.Size(517, 43);
            this.pnlMainSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(53, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(454, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSearch.Location = new System.Drawing.Point(10, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(43, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Buscar:";
            // 
            // toolMain
            // 
            this.toolMain.Location = new System.Drawing.Point(0, 24);
            this.toolMain.Name = "toolMain";
            this.toolMain.Size = new System.Drawing.Size(779, 25);
            this.toolMain.TabIndex = 7;
            this.toolMain.Text = "toolMain";
            // 
            // statusMain
            // 
            this.statusMain.Location = new System.Drawing.Point(0, 450);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(779, 22);
            this.statusMain.TabIndex = 6;
            this.statusMain.Text = "statusMain";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(779, 24);
            this.menuMain.TabIndex = 5;
            this.menuMain.Text = "menuMain";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(60, 20);
            this.miFile.Text = "Archivo";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(96, 22);
            this.miExit.Text = "Salir";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // imgTreeMain
            // 
            this.imgTreeMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeMain.ImageStream")));
            this.imgTreeMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeMain.Images.SetKeyName(0, "home.png");
            this.imgTreeMain.Images.SetKeyName(1, "couse_grey.png");
            this.imgTreeMain.Images.SetKeyName(2, "course_color.png");
            this.imgTreeMain.Images.SetKeyName(3, "show_offliners.png");
            this.imgTreeMain.Images.SetKeyName(4, "edit_user.png");
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 472);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.toolMain);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.Name = "FMain";
            this.ShowInTaskbar = false;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FMain_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlMainDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlMainSearch.ResumeLayout(false);
            this.pnlMainSearch.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TreeView treeMain;
        private System.Windows.Forms.Panel pnlMainDGV;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel pnlMainSearch;
        private System.Windows.Forms.ToolStrip toolMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ImageList imgTreeMain;
    }
}

