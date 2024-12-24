namespace FormChinh
{
    partial class frmQuenMK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuenMK = new System.Windows.Forms.TextBox();
            this.btnQuenMK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khôi phục mật khẩu";
            // 
            // txtQuenMK
            // 
            this.txtQuenMK.Location = new System.Drawing.Point(124, 107);
            this.txtQuenMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuenMK.Name = "txtQuenMK";
            this.txtQuenMK.Size = new System.Drawing.Size(473, 22);
            this.txtQuenMK.TabIndex = 2;
            // 
            // btnQuenMK
            // 
            this.btnQuenMK.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuenMK.Location = new System.Drawing.Point(81, 187);
            this.btnQuenMK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuenMK.Name = "btnQuenMK";
            this.btnQuenMK.Size = new System.Drawing.Size(475, 55);
            this.btnQuenMK.TabIndex = 3;
            this.btnQuenMK.Text = "Gửi";
            this.btnQuenMK.UseVisualStyleBackColor = true;
            // 
            // frmQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 257);
            this.Controls.Add(this.btnQuenMK);
            this.Controls.Add(this.txtQuenMK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuenMK";
            this.Text = "Quên mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuenMK;
        private System.Windows.Forms.Button btnQuenMK;
    }
}