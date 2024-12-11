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
using static System.Net.Mime.MediaTypeNames;

namespace conditerskaya
{
    public partial class add : Form
    {
        db db = new db();
        public add()
        {
            InitializeComponent();
        }

        private void add_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                var title = TB_new_title.Text;
                var price = TB_new_price.Text;
                var type = CB_type.Text;
                var stock = CB_stock.Text;
                //string[] inp_text_value = { TB_new_title.Text, TB_new_price.Text, TB_new_id_type.Text, TB_new_id_stock_status.Text };
                if (title.Length > 0 && price.Length > 0 && type.Length > 0 && stock.Length > 0)
                {
                    if (int.TryParse(price, out int number))
                    {
                        string query_string = $"insert into product(title, id_stock_status, price, id_type) values ('{title}', '{stock}', '{price}', '{type}')";
                        SqlCommand command = new SqlCommand(query_string, db.get_sql_connection());
                        db.open_connection();
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Close();

                        MessageBox.Show("Поле добавлено!");
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
