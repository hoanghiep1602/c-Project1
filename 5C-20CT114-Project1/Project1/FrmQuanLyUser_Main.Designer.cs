namespace Project1
{
    partial class FrmQuanLyUser_Main
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


        
          /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyUser_Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNapLai = new System.Windows.Forms.ToolStripButton();
            this.actionAdd = new System.Windows.Forms.ToolStripButton();
            this.actionUpdate = new System.Windows.Forms.ToolStripButton();
            this.actionDelete = new System.Windows.Forms.ToolStripButton();
            this.actionQuit = new System.Windows.Forms.ToolStripLabel();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhoMatKhau = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            dgvUser = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(17, 17);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNapLai,
            this.actionAdd,
            this.actionUpdate,
            this.actionDelete,
            this.actionQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "Nạp Lại";
            // 
            // toolStripNapLai
            // 
            this.toolStripNapLai.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNapLai.Image")));
            this.toolStripNapLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNapLai.Name = "toolStripNapLai";
            this.toolStripNapLai.Size = new System.Drawing.Size(65, 22);
            this.toolStripNapLai.Text = "Nạp lại";
            this.toolStripNapLai.Click += new System.EventHandler(this.toolStripNapLai_Click);
            // 
            // actionAdd
            // 
            this.actionAdd.Image = ((System.Drawing.Image)(resources.GetObject("actionAdd.Image")));
            this.actionAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionAdd.Name = "actionAdd";
            this.actionAdd.Size = new System.Drawing.Size(58, 22);
            this.actionAdd.Text = "Thêm";
            this.actionAdd.Click += new System.EventHandler(this.ActionAdd_Click);
            // 
            // actionUpdate
            // 
            this.actionUpdate.Image = ((System.Drawing.Image)(resources.GetObject("actionUpdate.Image")));
            this.actionUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionUpdate.Name = "actionUpdate";
            this.actionUpdate.Size = new System.Drawing.Size(47, 22);
            this.actionUpdate.Text = "Sửa";
            this.actionUpdate.Click += new System.EventHandler(this.actionUpdate_Click);
            // 
            // actionDelete
            // 
            this.actionDelete.Image = ((System.Drawing.Image)(resources.GetObject("actionDelete.Image")));
            this.actionDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionDelete.Name = "actionDelete";
            this.actionDelete.Size = new System.Drawing.Size(48, 22);
            this.actionDelete.Text = "Xóa";
            this.actionDelete.Click += new System.EventHandler(this.actionDelete_Click);
            // 
            // actionQuit
            // 
            this.actionQuit.Name = "actionQuit";
            this.actionQuit.Size = new System.Drawing.Size(37, 22);
            this.actionQuit.Text = "Thoát";
            this.actionQuit.Click += new System.EventHandler(this.ActionQuit_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "ID";
            this.colId.FillWeight = 20F;
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colTaiKhoan
            // 
            this.colTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colTaiKhoan.DataPropertyName = "TaiKhoan";
            this.colTaiKhoan.FillWeight = 50F;
            this.colTaiKhoan.HeaderText = "Tài khoản";
            this.colTaiKhoan.Name = "colTaiKhoan";
            this.colTaiKhoan.ReadOnly = true;
            this.colTaiKhoan.Width = 80;
            // 
            // colMatKhau
            // 
            this.colMatKhau.DataPropertyName = "MatKhau";
            this.colMatKhau.FillWeight = 120F;
            this.colMatKhau.HeaderText = "Mật khẩu";
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.ReadOnly = true;
            // 
            // colHoVaTen
            // 
            this.colHoVaTen.DataPropertyName = "HoVaTen";
            this.colHoVaTen.FillWeight = 40F;
            this.colHoVaTen.HeaderText = "Họ và tên";
            this.colHoVaTen.Name = "colHoVaTen";
            this.colHoVaTen.ReadOnly = true;
            this.colHoVaTen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colHoVaTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNhoMatKhau
            // 
            this.colNhoMatKhau.DataPropertyName = "NhoMatKhau";
            this.colNhoMatKhau.FalseValue = "False";
            this.colNhoMatKhau.FillWeight = 30F;
            this.colNhoMatKhau.HeaderText = "Nhớ mật khẩu";
            this.colNhoMatKhau.Name = "colNhoMatKhau";
            this.colNhoMatKhau.ReadOnly = true;
            this.colNhoMatKhau.TrueValue = "True";
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.BackgroundColor = System.Drawing.Color.Azure;
            dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTaiKhoan,
            this.colMatKhau,
            this.colHoVaTen,
            this.colNhoMatKhau});
            dgvUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            dgvUser.Location = new System.Drawing.Point(0, 28);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.Size = new System.Drawing.Size(800, 422);
            dgvUser.TabIndex = 2;
            dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            // 
            // FrmQuanLyUser_Main
            // 
            var topLeftHeaderCell = dgvUser.TopLeftHeaderCell;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(dgvUser);
            this.Name = "FrmQuanLyUser_Main";
            this.Text = "FrmQuanLyUser";
            this.Load += new System.EventHandler(this.FrmQuanLyUser_Main_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        System.Windows.Forms.DataGridView dgvUser;

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNapLai;
        private System.Windows.Forms.ToolStripButton actionAdd;
        private System.Windows.Forms.ToolStripButton actionUpdate;
        private System.Windows.Forms.ToolStripButton actionDelete;
        private System.Windows.Forms.ToolStripLabel actionQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoVaTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colNhoMatKhau;
    }
    }
