namespace conditerskaya
{
    partial class auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inp_login_auth = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inp_password_auth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_auth = new System.Windows.Forms.Button();
            this.button_to_reg = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inp_login_auth
            // 
            this.inp_login_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inp_login_auth.Location = new System.Drawing.Point(264, 254);
            this.inp_login_auth.Margin = new System.Windows.Forms.Padding(4);
            this.inp_login_auth.Name = "inp_login_auth";
            this.inp_login_auth.Size = new System.Drawing.Size(232, 30);
            this.inp_login_auth.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // inp_password_auth
            // 
            this.inp_password_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.inp_password_auth.Location = new System.Drawing.Point(264, 308);
            this.inp_password_auth.Margin = new System.Windows.Forms.Padding(4);
            this.inp_password_auth.Name = "inp_password_auth";
            this.inp_password_auth.Size = new System.Drawing.Size(232, 30);
            this.inp_password_auth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(257, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // btn_auth
            // 
            this.btn_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_auth.Location = new System.Drawing.Point(264, 361);
            this.btn_auth.Margin = new System.Windows.Forms.Padding(4);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(100, 38);
            this.btn_auth.TabIndex = 3;
            this.btn_auth.Text = "Войти";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.btn_auth_Click);
            // 
            // button_to_reg
            // 
            this.button_to_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button_to_reg.Location = new System.Drawing.Point(264, 407);
            this.button_to_reg.Margin = new System.Windows.Forms.Padding(4);
            this.button_to_reg.Name = "button_to_reg";
            this.button_to_reg.Size = new System.Drawing.Size(129, 26);
            this.button_to_reg.TabIndex = 4;
            this.button_to_reg.Text = "нет аккаунта";
            this.button_to_reg.UseVisualStyleBackColor = true;
            this.button_to_reg.Click += new System.EventHandler(this.button_to_reg_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Логин";
            // 
            // auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 649);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_to_reg);
            this.Controls.Add(this.btn_auth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inp_password_auth);
            this.Controls.Add(this.inp_login_auth);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "auth";
            this.Text = "auth";
            this.Load += new System.EventHandler(this.auth_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inp_login_auth;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox inp_password_auth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.Button button_to_reg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

