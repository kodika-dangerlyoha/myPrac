using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conditerskaya
{
    public partial class change : Form
    {
        db db = new db();
        public change(DataGridViewRow row)
        {
            InitializeComponent();
            r = row;
        }

        DataGridViewRow r;

        private void change_Load(object sender, EventArgs e)
        {

        }

        //public void Change_Row()
        //{
        //    string[] inp_text_value = {TB_new_title.Text, TB_new_price.Text, TB_new_id_type.Text, TB_new_id_stock_status.Text};

        //    for (int i = 0; i < 4; i++)
        //    {
        //        if (inp_text_value[i] == "")
        //        {
        //            inp_text_value[i] = r.Cells[i + 1].Value.ToString();
        //        }
        //    }
        //    string query_string = $"Update products set ProductName = '{inp_text_value[0]}', Description = '{inp_text_value[1]}', Price = '{inp_text_value[2]}', StockQuantity = '{inp_text_value[3]}', SupplierID = '{inp_text_value[4]}', ClientID='{inp_text_value[5]}' where ProductID='{r.Cells[0].Value.ToString()}'";
        //    SqlCommand command = new SqlCommand(query_string, db.get_sql_connection());
        //    db.open_connection();
        //    SqlDataReader reader = command.ExecuteReader();
        //    reader.Close();
        //}

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                var title = TB_new_title.Text;
                var price = TB_new_price.Text;
                var type = CB_type.Text;
                var stock = CB_stock.Text;

                if (title.Length > 0 && price.Length > 0 && type.Length > 0 && stock.Length > 0)
                {
                    if (int.TryParse(price, out int number))
                    {
                        string query_string = $"Update product set title = '{title}', id_stock_status = '{stock}', price = '{price}', id_type = '{type}' where id_product='{r.Cells[0].Value.ToString()}'";
                        SqlCommand command = new SqlCommand(query_string, db.get_sql_connection());
                        db.open_connection();
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();

                        MessageBox.Show("Поле Изменено!");
                        catalog cat = new catalog();
                        cat.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Заполните поле с ценой числом");
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля");
                }

                //for (int i = 0; i < 4; i++)
                //{
                //    if (inp_text_value[i] == "")
                //    {
                //        inp_text_value[i] = r.Cells[i + 1].Value.ToString();
                //    }
                //}
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            catalog cat = new catalog();
            cat.Show();
            this.Hide();
        }
    }
}
