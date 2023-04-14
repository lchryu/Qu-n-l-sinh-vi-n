namespace LuongChungHoi
{
    partial class FormCon
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
            this.dgvCon = new System.Windows.Forms.DataGridView();
            this.btnTimKiemNgaySinh = new System.Windows.Forms.Button();
            this.msvTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoiSinhTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NgaySinhTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiemNoiSinh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCon
            // 
            this.dgvCon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCon.Location = new System.Drawing.Point(6, 177);
            this.dgvCon.Name = "dgvCon";
            this.dgvCon.Size = new System.Drawing.Size(782, 261);
            this.dgvCon.TabIndex = 0;
            // 
            // btnTimKiemNgaySinh
            // 
            this.btnTimKiemNgaySinh.Location = new System.Drawing.Point(454, 11);
            this.btnTimKiemNgaySinh.Name = "btnTimKiemNgaySinh";
            this.btnTimKiemNgaySinh.Size = new System.Drawing.Size(186, 23);
            this.btnTimKiemNgaySinh.TabIndex = 1;
            this.btnTimKiemNgaySinh.Text = "Tìm kiếm theo msv";
            this.btnTimKiemNgaySinh.UseVisualStyleBackColor = true;
            this.btnTimKiemNgaySinh.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // msvTimKiem
            // 
            this.msvTimKiem.Location = new System.Drawing.Point(113, 13);
            this.msvTimKiem.Name = "msvTimKiem";
            this.msvTimKiem.Size = new System.Drawing.Size(278, 20);
            this.msvTimKiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sinh viên";
            // 
            // NoiSinhTimKiem
            // 
            this.NoiSinhTimKiem.Location = new System.Drawing.Point(113, 39);
            this.NoiSinhTimKiem.Name = "NoiSinhTimKiem";
            this.NoiSinhTimKiem.Size = new System.Drawing.Size(278, 20);
            this.NoiSinhTimKiem.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nơi Sinh";
            // 
            // NgaySinhTimKiem
            // 
            this.NgaySinhTimKiem.Location = new System.Drawing.Point(113, 65);
            this.NgaySinhTimKiem.Name = "NgaySinhTimKiem";
            this.NgaySinhTimKiem.Size = new System.Drawing.Size(278, 20);
            this.NgaySinhTimKiem.TabIndex = 2;
            this.NgaySinhTimKiem.TextChanged += new System.EventHandler(this.NgaySinhTimKiem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày sinh";
            // 
            // btnTimKiemNoiSinh
            // 
            this.btnTimKiemNoiSinh.Location = new System.Drawing.Point(454, 37);
            this.btnTimKiemNoiSinh.Name = "btnTimKiemNoiSinh";
            this.btnTimKiemNoiSinh.Size = new System.Drawing.Size(186, 23);
            this.btnTimKiemNoiSinh.TabIndex = 1;
            this.btnTimKiemNoiSinh.Text = "Tìm kiếm theo nơi sinh";
            this.btnTimKiemNoiSinh.UseVisualStyleBackColor = true;
            this.btnTimKiemNoiSinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tìm kiếm theo ngày sinh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NgaySinhTimKiem);
            this.Controls.Add(this.NoiSinhTimKiem);
            this.Controls.Add(this.msvTimKiem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTimKiemNoiSinh);
            this.Controls.Add(this.btnTimKiemNgaySinh);
            this.Controls.Add(this.dgvCon);
            this.Name = "FormCon";
            this.Text = "S";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCon;
        private System.Windows.Forms.Button btnTimKiemNgaySinh;
        private System.Windows.Forms.TextBox msvTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoiSinhTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NgaySinhTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiemNoiSinh;
        private System.Windows.Forms.Button button2;
    }
}