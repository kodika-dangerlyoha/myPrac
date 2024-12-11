namespace conditerskaya
{
    partial class change
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
            this.TB_new_title = new System.Windows.Forms.TextBox();
            this.TB_new_price = new System.Windows.Forms.TextBox();
            this.btn_change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.CB_stock = new System.Windows.Forms.ComboBox();
            this.CB_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TB_new_title
            // 
            this.TB_new_title.Location = new System.Drawing.Point(314, 76);
            this.TB_new_title.Name = "TB_new_title";
            this.TB_new_title.Size = new System.Drawing.Size(172, 20);
            this.TB_new_title.TabIndex = 0;
            // 
            // TB_new_price
            // 
            this.TB_new_price.Location = new System.Drawing.Point(314, 128);
            this.TB_new_price.Name = "TB_new_price";
            this.TB_new_price.Size = new System.Drawing.Size(172, 20);
            this.TB_new_price.TabIndex = 2;
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(314, 180);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(84, 23);
            this.btn_change.TabIndex = 4;
            this.btn_change.Text = "Изменить";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "id_stock_satus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "id_type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(310, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Изменение ";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(404, 180);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 23);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Вернуться";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // CB_stock
            // 
            this.CB_stock.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_stock.FormattingEnabled = true;
            this.CB_stock.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.CB_stock.Location = new System.Drawing.Point(314, 101);
            this.CB_stock.Name = "CB_stock";
            this.CB_stock.Size = new System.Drawing.Size(172, 21);
            this.CB_stock.TabIndex = 24;
            // 
            // CB_type
            // 
            this.CB_type.FormattingEnabled = true;
            this.CB_type.Items.AddRange(new object[] {
            "4",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.CB_type.Location = new System.Drawing.Point(314, 154);
            this.CB_type.Name = "CB_type";
            this.CB_type.Size = new System.Drawing.Size(172, 21);
            this.CB_type.TabIndex = 25;
            // 
            // change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CB_type);
            this.Controls.Add(this.CB_stock);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.TB_new_price);
            this.Controls.Add(this.TB_new_title);
            this.Name = "change";
            this.Text = "change";
            this.Load += new System.EventHandler(this.change_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_new_title;
        private System.Windows.Forms.TextBox TB_new_price;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox CB_stock;
        private System.Windows.Forms.ComboBox CB_type;
    }
}