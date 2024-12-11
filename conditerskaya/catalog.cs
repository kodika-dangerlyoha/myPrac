using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace conditerskaya
{
    public partial class catalog : Form
    {
        db db = new db();

        int selected_row;
        public catalog()
        {
            InitializeComponent();
        }

        public void Create_colums()
        {
            product_grid.Columns.Add("id_product", "id");
            product_grid.Columns.Add("title", "Название");
            product_grid.Columns.Add("price", "Цена");
            product_grid.Columns.Add("id_type", "Тип");
            //product_grid.Columns.Add("id_stock_status", "Акция");
        }

        public void Read_single_row(DataGridView dgw, IDataRecord record)
        {
            try
            {
                dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2), record.GetString(3));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Refresh_data_grid(DataGridView dgw)
        {
            try
            {
                dgw.Rows.Clear();

                //string query_string = $"select * from product";
                string query_string = $"select product.id_product, product.title, product.price, type.title from product join type ON product.id_type = type.id_drink_type";
                //string query_string = $"select product.id_product, product.title, (type.title stock_status.title) from product join type ON product.id_type = type.id_drink_type and product.id_stock_status = stock_status.id_stock_status";

                SqlCommand command = new SqlCommand(query_string, db.get_sql_connection());

                db.open_connection();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Read_single_row(dgw, reader);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void catalog_Load(object sender, EventArgs e)
        {
            Create_colums();
            Refresh_data_grid(product_grid);
        }

        private void product_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < product_grid.Rows.Count - 1)
                {
                    selected_row = e.RowIndex;
                    DataGridViewRow row = product_grid.Rows[selected_row];
                    lbl_price.Text = $"{row.Cells[2].Value.ToString()}₽";
                }
            }
            
            catch (Exception ex)
{
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_remove_product_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = product_grid.Rows[selected_row];
                string query_string = $"delete from ingredient_product where id_product={row.Cells[0].Value.ToString()}";
                string query_string_2 = $"delete from basket where id_product={row.Cells[0].Value.ToString()}";
                string query_string_3 = $"delete from favorite where id_product={row.Cells[0].Value.ToString()}";
                string query_string_4 = $"delete from product where id_product={row.Cells[0].Value.ToString()}";
                SqlCommand command = new SqlCommand(query_string, db.get_sql_connection());
                SqlCommand command_2 = new SqlCommand(query_string_2, db.get_sql_connection());
                SqlCommand command_3 = new SqlCommand(query_string_3, db.get_sql_connection());
                SqlCommand command_4 = new SqlCommand(query_string_4, db.get_sql_connection());
                db.open_connection();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                reader = command_2.ExecuteReader();
                reader.Close();
                reader = command_3.ExecuteReader();
                reader.Close();
                reader = command_4.ExecuteReader();
                reader.Close();
                MessageBox.Show("Товар удален");
                Refresh_data_grid(product_grid);
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void Search(DataGridView dgw)
        {
            try
            {
                dgw.Rows.Clear();

                string search_string = $"select id_product, product.title, price, type.title from product join type ON product.id_type = type.id_drink_type where concat (id_product, product.title, price, type.title) like '%" + TB_search.Text + "%'";

                SqlCommand command = new SqlCommand(search_string, db.get_sql_connection());
                db.open_connection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Read_single_row(dgw, reader);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_edit_product_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = product_grid.Rows[selected_row];
                change changeProduct = new change(row);
                changeProduct.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            try
            {
                add add = new add();
                add.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TB_search_TextChanged(object sender, EventArgs e)
        {
            Search(product_grid);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            auth a = new auth();
            a.Show();
            this.Hide();
        }
    }
}
