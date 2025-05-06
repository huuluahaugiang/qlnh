namespace QuanLyNhaHang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstBan = new System.Windows.Forms.ListBox();
            this.lstMon = new System.Windows.Forms.ListBox();
            this.contextMenuStripMon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDatBan = new System.Windows.Forms.DataGridView();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btgnTinhTien = new System.Windows.Forms.Button();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tStDongHo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStThanhTien = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStripMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBan
            // 
            this.lstBan.FormattingEnabled = true;
            this.lstBan.Location = new System.Drawing.Point(12, 8);
            this.lstBan.Margin = new System.Windows.Forms.Padding(2);
            this.lstBan.Name = "lstBan";
            this.lstBan.Size = new System.Drawing.Size(211, 173);
            this.lstBan.TabIndex = 0;
            this.lstBan.SelectedIndexChanged += new System.EventHandler(this.lstBan_SelectedIndexChanged);
            this.lstBan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBan_MouseDoubleClick);
            // 
            // lstMon
            // 
            this.lstMon.ContextMenuStrip = this.contextMenuStripMon;
            this.lstMon.FormattingEnabled = true;
            this.lstMon.Location = new System.Drawing.Point(326, 2);
            this.lstMon.Margin = new System.Windows.Forms.Padding(2);
            this.lstMon.Name = "lstMon";
            this.lstMon.Size = new System.Drawing.Size(209, 394);
            this.lstMon.TabIndex = 3;
            this.lstMon.SelectedIndexChanged += new System.EventHandler(this.lstMon_SelectedIndexChanged);
            // 
            // contextMenuStripMon
            // 
            this.contextMenuStripMon.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chọnMónToolStripMenuItem,
            this.thêmMónMớiToolStripMenuItem});
            this.contextMenuStripMon.Name = "contextMenuStripMon";
            this.contextMenuStripMon.Size = new System.Drawing.Size(157, 48);
            // 
            // chọnMónToolStripMenuItem
            // 
            this.chọnMónToolStripMenuItem.Name = "chọnMónToolStripMenuItem";
            this.chọnMónToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.chọnMónToolStripMenuItem.Text = "Chọn món";
            // 
            // thêmMónMớiToolStripMenuItem
            // 
            this.thêmMónMớiToolStripMenuItem.Name = "thêmMónMớiToolStripMenuItem";
            this.thêmMónMớiToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.thêmMónMớiToolStripMenuItem.Text = "Thêm món mới";
            // 
            // dgvDatBan
            // 
            this.dgvDatBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatBan.Location = new System.Drawing.Point(11, 183);
            this.dgvDatBan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatBan.Name = "dgvDatBan";
            this.dgvDatBan.RowHeadersWidth = 51;
            this.dgvDatBan.RowTemplate.Height = 24;
            this.dgvDatBan.Size = new System.Drawing.Size(311, 213);
            this.dgvDatBan.TabIndex = 7;
            this.dgvDatBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhach_CellClick_1);
            this.dgvDatBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatBan_CellContentClick);
            this.dgvDatBan.SelectionChanged += new System.EventHandler(this.dgvDatBan_SelectionChanged);
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Location = new System.Drawing.Point(91, 16);
            this.btnGoiMon.Margin = new System.Windows.Forms.Padding(2);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(72, 22);
            this.btnGoiMon.TabIndex = 8;
            this.btnGoiMon.Text = "Gọi món";
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 20);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // btgnTinhTien
            // 
            this.btgnTinhTien.Location = new System.Drawing.Point(237, 67);
            this.btgnTinhTien.Margin = new System.Windows.Forms.Padding(2);
            this.btgnTinhTien.Name = "btgnTinhTien";
            this.btgnTinhTien.Size = new System.Drawing.Size(69, 24);
            this.btgnTinhTien.TabIndex = 11;
            this.btgnTinhTien.Text = "Tính tiền";
            this.btgnTinhTien.UseVisualStyleBackColor = true;
            this.btgnTinhTien.Click += new System.EventHandler(this.btgnTinhTien_Click);
            // 
            // btnDatBan
            // 
            this.btnDatBan.Location = new System.Drawing.Point(237, 11);
            this.btnDatBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(69, 24);
            this.btnDatBan.TabIndex = 13;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.UseVisualStyleBackColor = true;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.Location = new System.Drawing.Point(237, 39);
            this.btnHuyBan.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(69, 24);
            this.btnHuyBan.TabIndex = 14;
            this.btnHuyBan.Text = "Hủy bàn";
            this.btnHuyBan.UseVisualStyleBackColor = true;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDatBan);
            this.splitContainer1.Panel1.Controls.Add(this.lstMon);
            this.splitContainer1.Panel1.Controls.Add(this.lstBan);
            this.splitContainer1.Panel1.Controls.Add(this.btgnTinhTien);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuyBan);
            this.splitContainer1.Panel1.Controls.Add(this.btnDatBan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 478);
            this.splitContainer1.SplitterDistance = 537;
            this.splitContainer1.TabIndex = 17;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer2.Panel1.Controls.Add(this.btnGoiMon);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lsvHoaDon);
            this.splitContainer2.Size = new System.Drawing.Size(506, 478);
            this.splitContainer2.SplitterDistance = 51;
            this.splitContainer2.TabIndex = 17;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(506, 423);
            this.lsvHoaDon.TabIndex = 16;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1,
            this.toolStripSplitButton1,
            this.tStDongHo,
            this.tStThanhTien});
            this.statusStrip1.Location = new System.Drawing.Point(0, 456);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1047, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // tStDongHo
            // 
            this.tStDongHo.Name = "tStDongHo";
            this.tStDongHo.Size = new System.Drawing.Size(90, 17);
            this.tStDongHo.Text = "Thứ ngày tháng";
            // 
            // tStThanhTien
            // 
            this.tStThanhTien.Name = "tStThanhTien";
            this.tStThanhTien.Size = new System.Drawing.Size(66, 17);
            this.tStThanhTien.Text = "Thành tiền:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 478);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Quản lý quán ăn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBan;
        private System.Windows.Forms.ListBox lstMon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMon;
        private System.Windows.Forms.ToolStripMenuItem chọnMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónMớiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDatBan;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btgnTinhTien;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.Button btnHuyBan;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel tStDongHo;
        private System.Windows.Forms.ToolStripStatusLabel tStThanhTien;
    }
}

