namespace conditerskaya
{
    partial class reg
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
            this.button_reg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_name_reg = new System.Windows.Forms.TextBox();
            this.TB_surname_reg = new System.Windows.Forms.TextBox();
            this.TB_login_reg = new System.Windows.Forms.TextBox();
            this.TB_password_reg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_go_to_auth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(326, 297);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(162, 23);
            this.button_reg.TabIndex = 0;
            this.button_reg.Text = "Зарегистрироваться";
            this.button_reg.UseVisualStyleBackColor = true;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(323, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // TB_name_reg
            // 
            this.TB_name_reg.Location = new System.Drawing.Point(326, 128);
            this.TB_name_reg.Name = "TB_name_reg";
            this.TB_name_reg.Size = new System.Drawing.Size(183, 22);
            this.TB_name_reg.TabIndex = 2;
            // 
            // TB_surname_reg
            // 
            this.TB_surname_reg.Location = new System.Drawing.Point(326, 170);
            this.TB_surname_reg.Name = "TB_surname_reg";
            this.TB_surname_reg.Size = new System.Drawing.Size(183, 22);
            this.TB_surname_reg.TabIndex = 3;
            // 
            // TB_login_reg
            // 
            this.TB_login_reg.Location = new System.Drawing.Point(326, 207);
            this.TB_login_reg.Name = "TB_login_reg";
            this.TB_login_reg.Size = new System.Drawing.Size(183, 22);
            this.TB_login_reg.TabIndex = 4;
            // 
            // TB_password_reg
            // 
            this.TB_password_reg.Location = new System.Drawing.Point(326, 249);
            this.TB_password_reg.Name = "TB_password_reg";
            this.TB_password_reg.Size = new System.Drawing.Size(183, 22);
            this.TB_password_reg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Второе имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Логин";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пароль";
            // 
            // button_go_to_auth
            // 
            this.button_go_to_auth.Location = new System.Drawing.Point(326, 335);
            this.button_go_to_auth.Name = "button_go_to_auth";
            this.button_go_to_auth.Size = new System.Drawing.Size(162, 23);
            this.button_go_to_auth.TabIndex = 12;
            this.button_go_to_auth.Text = "Есть аккаунт";
            this.button_go_to_auth.UseVisualStyleBackColor = true;
            this.button_go_to_auth.Click += new System.EventHandler(this.button_go_to_auth_Click);
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_go_to_auth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_password_reg);
            this.Controls.Add(this.TB_login_reg);
            this.Controls.Add(this.TB_surname_reg);
            this.Controls.Add(this.TB_name_reg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reg);
            this.Name = "reg";
            this.Text = "reg";
            this.Load += new System.EventHandler(this.reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_name_reg;
        private System.Windows.Forms.TextBox TB_surname_reg;
        private System.Windows.Forms.TextBox TB_login_reg;
        private System.Windows.Forms.TextBox TB_password_reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_go_to_auth;
    }
}