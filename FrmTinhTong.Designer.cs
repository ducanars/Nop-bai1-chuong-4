namespace Chuong4_part1
{
    partial class FrmTinhTong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTinhTong));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnhapb = new System.Windows.Forms.TextBox();
            this.btlTinhTong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTong = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a: ";
            // 
            // txtnhapa
            // 
            this.txtnhapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhapa.Location = new System.Drawing.Point(278, 135);
            this.txtnhapa.Name = "txtnhapa";
            this.txtnhapa.Size = new System.Drawing.Size(144, 29);
            this.txtnhapa.TabIndex = 1;
            this.txtnhapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhapa_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập b: ";
            // 
            // txtnhapb
            // 
            this.txtnhapb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhapb.Location = new System.Drawing.Point(278, 225);
            this.txtnhapb.Name = "txtnhapb";
            this.txtnhapb.Size = new System.Drawing.Size(144, 29);
            this.txtnhapb.TabIndex = 3;
            this.txtnhapb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnhapb_KeyPress);
            // 
            // btlTinhTong
            // 
            this.btlTinhTong.BackColor = System.Drawing.Color.Turquoise;
            this.btlTinhTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlTinhTong.Location = new System.Drawing.Point(28, 364);
            this.btlTinhTong.Name = "btlTinhTong";
            this.btlTinhTong.Size = new System.Drawing.Size(144, 52);
            this.btlTinhTong.TabIndex = 4;
            this.btlTinhTong.Text = "Tính Tổng";
            this.btlTinhTong.UseVisualStyleBackColor = false;
            this.btlTinhTong.Click += new System.EventHandler(this.btlTinhTong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tính tổng các số ở giữa a và b: ";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.BackColor = System.Drawing.Color.Transparent;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(443, 289);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(0, 29);
            this.lbTong.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(506, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(268, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "Làm lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmTinhTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 673);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btlTinhTong);
            this.Controls.Add(this.txtnhapb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnhapa);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "FrmTinhTong";
            this.Text = "FrmTinhTong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnhapb;
        private System.Windows.Forms.Button btlTinhTong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}