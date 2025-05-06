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
            this.lstBan = new System.Windows.Forms.ListBox();
            this.lstMon = new System.Windows.Forms.ListBox();
            this.contextMenuStripMon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chọnMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.btnGoiMon = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btgnTinhTien = new System.Windows.Forms.Button();
            this.lstKhach = new System.Windows.Forms.ListBox();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.contextMenuStripMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBan
            // 
            this.lstBan.FormattingEnabled = true;
            this.lstBan.Location = new System.Drawing.Point(14, 10);
            this.lstBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstBan.Name = "lstBan";
            this.lstBan.Size = new System.Drawing.Size(224, 134);
            this.lstBan.TabIndex = 0;
            this.lstBan.SelectedIndexChanged += new System.EventHandler(this.lstBan_SelectedIndexChanged);
            this.lstBan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBan_MouseDoubleClick);
            // 
            // lstMon
            // 
            this.lstMon.ContextMenuStrip = this.contextMenuStripMon;
            this.lstMon.FormattingEnabled = true;
            this.lstMon.Location = new System.Drawing.Point(241, 9);
            this.lstMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstMon.Name = "lstMon";
            this.lstMon.Size = new System.Drawing.Size(209, 316);
            this.lstMon.TabIndex = 3;
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
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(476, 67);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(509, 258);
            this.dgvHoaDon.TabIndex = 7;
            // 
            // btnGoiMon
            // 
            this.btnGoiMon.Location = new System.Drawing.Point(544, 21);
            this.btnGoiMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGoiMon.Name = "btnGoiMon";
            this.btnGoiMon.Size = new System.Drawing.Size(72, 22);
            this.btnGoiMon.TabIndex = 8;
            this.btnGoiMon.Text = "Gọi món";
            this.btnGoiMon.UseVisualStyleBackColor = true;
            this.btnGoiMon.Click += new System.EventHandler(this.btnGoiMon_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(476, 25);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // btgnTinhTien
            // 
            this.btgnTinhTien.Location = new System.Drawing.Point(140, 148);
            this.btgnTinhTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btgnTinhTien.Name = "btgnTinhTien";
            this.btgnTinhTien.Size = new System.Drawing.Size(69, 24);
            this.btgnTinhTien.TabIndex = 11;
            this.btgnTinhTien.Text = "Tính tiền";
            this.btgnTinhTien.UseVisualStyleBackColor = true;
            // 
            // lstKhach
            // 
            this.lstKhach.FormattingEnabled = true;
            this.lstKhach.Location = new System.Drawing.Point(14, 174);
            this.lstKhach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstKhach.Name = "lstKhach";
            this.lstKhach.Size = new System.Drawing.Size(224, 147);
            this.lstKhach.TabIndex = 12;
            // 
            // btnDatBan
            // 
            this.btnDatBan.Location = new System.Drawing.Point(14, 148);
            this.btnDatBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(55, 24);
            this.btnDatBan.TabIndex = 13;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.UseVisualStyleBackColor = true;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.Location = new System.Drawing.Point(73, 148);
            this.btnHuyBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(63, 24);
            this.btnHuyBan.TabIndex = 14;
            this.btnHuyBan.Text = "Hủy bàn";
            this.btnHuyBan.UseVisualStyleBackColor = true;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 338);
            this.Controls.Add(this.btnHuyBan);
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.lstKhach);
            this.Controls.Add(this.btgnTinhTien);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnGoiMon);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.lstMon);
            this.Controls.Add(this.lstBan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Quản lý quán ăn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripMon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBan;
        private System.Windows.Forms.ListBox lstMon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMon;
        private System.Windows.Forms.ToolStripMenuItem chọnMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónMớiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnGoiMon;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btgnTinhTien;
        private System.Windows.Forms.ListBox lstKhach;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.Button btnHuyBan;
    }
}

