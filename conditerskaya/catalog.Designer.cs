namespace conditerskaya
{
    partial class catalog
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
            this.product_grid = new System.Windows.Forms.DataGridView();
            this.btn_torti = new System.Windows.Forms.Button();
            this.btn_drinks = new System.Windows.Forms.Button();
            this.btn_pirojki = new System.Windows.Forms.Button();
            this.btn_add_product = new System.Windows.Forms.Button();
            this.btn_edit_product = new System.Windows.Forms.Button();
            this.btn_remove_product = new System.Windows.Forms.Button();
            this.group_product_cart = new System.Windows.Forms.GroupBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add_to_basket = new System.Windows.Forms.Button();
            this.TB_search = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.group_product_cart.SuspendLayout();
            this.SuspendLayout();
            // 
            // product_grid
            // 
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_grid.Location = new System.Drawing.Point(457, 64);
            this.product_grid.Name = "product_grid";
            this.product_grid.RowHeadersWidth = 51;
            this.product_grid.Size = new System.Drawing.Size(474, 401);
            this.product_grid.TabIndex = 0;
            this.product_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_grid_CellClick);
            // 
            // btn_torti
            // 
            this.btn_torti.Location = new System.Drawing.Point(12, 104);
            this.btn_torti.Name = "btn_torti";
            this.btn_torti.Size = new System.Drawing.Size(106, 50);
            this.btn_torti.TabIndex = 1;
            this.btn_torti.Text = "Торты";
            this.btn_torti.UseVisualStyleBackColor = true;
            // 
            // btn_drinks
            // 
            this.btn_drinks.Location = new System.Drawing.Point(12, 216);
            this.btn_drinks.Name = "btn_drinks";
            this.btn_drinks.Size = new System.Drawing.Size(106, 50);
            this.btn_drinks.TabIndex = 2;
            this.btn_drinks.Text = "Напитки";
            this.btn_drinks.UseVisualStyleBackColor = true;
            // 
            // btn_pirojki
            // 
            this.btn_pirojki.Location = new System.Drawing.Point(12, 160);
            this.btn_pirojki.Name = "btn_pirojki";
            this.btn_pirojki.Size = new System.Drawing.Size(106, 50);
            this.btn_pirojki.TabIndex = 3;
            this.btn_pirojki.Text = "Пирожки";
            this.btn_pirojki.UseVisualStyleBackColor = true;
            // 
            // btn_add_product
            // 
            this.btn_add_product.Location = new System.Drawing.Point(580, 471);
            this.btn_add_product.Name = "btn_add_product";
            this.btn_add_product.Size = new System.Drawing.Size(113, 46);
            this.btn_add_product.TabIndex = 4;
            this.btn_add_product.Text = "Добавить";
            this.btn_add_product.UseVisualStyleBackColor = true;
            this.btn_add_product.Click += new System.EventHandler(this.btn_add_product_Click);
            // 
            // btn_edit_product
            // 
            this.btn_edit_product.Location = new System.Drawing.Point(699, 471);
            this.btn_edit_product.Name = "btn_edit_product";
            this.btn_edit_product.Size = new System.Drawing.Size(113, 46);
            this.btn_edit_product.TabIndex = 5;
            this.btn_edit_product.Text = "Изменить";
            this.btn_edit_product.UseVisualStyleBackColor = true;
            this.btn_edit_product.Click += new System.EventHandler(this.btn_edit_product_Click);
            // 
            // btn_remove_product
            // 
            this.btn_remove_product.Location = new System.Drawing.Point(818, 471);
            this.btn_remove_product.Name = "btn_remove_product";
            this.btn_remove_product.Size = new System.Drawing.Size(113, 46);
            this.btn_remove_product.TabIndex = 6;
            this.btn_remove_product.Text = "Удалить";
            this.btn_remove_product.UseVisualStyleBackColor = true;
            this.btn_remove_product.Click += new System.EventHandler(this.btn_remove_product_Click);
            // 
            // group_product_cart
            // 
            this.group_product_cart.Controls.Add(this.lbl_price);
            this.group_product_cart.Controls.Add(this.btn_add_to_basket);
            this.group_product_cart.Location = new System.Drawing.Point(234, 64);
            this.group_product_cart.Name = "group_product_cart";
            this.group_product_cart.Size = new System.Drawing.Size(217, 401);
            this.group_product_cart.TabIndex = 7;
            this.group_product_cart.TabStop = false;
            this.group_product_cart.Text = "Карточка Еды";
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_price.Location = new System.Drawing.Point(6, 322);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(205, 33);
            this.lbl_price.TabIndex = 1;
            this.lbl_price.Text = "Price";
            // 
            // btn_add_to_basket
            // 
            this.btn_add_to_basket.Location = new System.Drawing.Point(6, 358);
            this.btn_add_to_basket.Name = "btn_add_to_basket";
            this.btn_add_to_basket.Size = new System.Drawing.Size(205, 37);
            this.btn_add_to_basket.TabIndex = 0;
            this.btn_add_to_basket.Text = "В корзину";
            this.btn_add_to_basket.UseVisualStyleBackColor = true;
            // 
            // TB_search
            // 
            this.TB_search.Location = new System.Drawing.Point(786, 38);
            this.TB_search.Name = "TB_search";
            this.TB_search.Size = new System.Drawing.Size(145, 20);
            this.TB_search.TabIndex = 8;
            this.TB_search.TextChanged += new System.EventHandler(this.TB_search_TextChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(13, 13);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Выход";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 529);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.TB_search);
            this.Controls.Add(this.group_product_cart);
            this.Controls.Add(this.btn_remove_product);
            this.Controls.Add(this.btn_edit_product);
            this.Controls.Add(this.btn_add_product);
            this.Controls.Add(this.btn_pirojki);
            this.Controls.Add(this.btn_drinks);
            this.Controls.Add(this.btn_torti);
            this.Controls.Add(this.product_grid);
            this.Name = "catalog";
            this.Text = "catalog";
            this.Load += new System.EventHandler(this.catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.group_product_cart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView product_grid;
        private System.Windows.Forms.Button btn_torti;
        private System.Windows.Forms.Button btn_drinks;
        private System.Windows.Forms.Button btn_pirojki;
        private System.Windows.Forms.Button btn_add_product;
        private System.Windows.Forms.Button btn_edit_product;
        private System.Windows.Forms.Button btn_remove_product;
        private System.Windows.Forms.GroupBox group_product_cart;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_add_to_basket;
        private System.Windows.Forms.TextBox TB_search;
        private System.Windows.Forms.Button btn_exit;
    }
}