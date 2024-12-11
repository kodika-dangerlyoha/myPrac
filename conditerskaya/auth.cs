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
using System.Collections;
using System.Diagnostics;

namespace conditerskaya
{
    public partial class auth : Form
    {
        db db = new db();
        public auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void auth_Load(object sender, EventArgs e)
        {
            inp_password_auth.PasswordChar = '*';
            inp_password_auth.MaxLength = 50;
            inp_login_auth.MaxLength = 50;
        }

        public void f_auth(string login_user, string password_user)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string query_string = $"select password, login from [user] where login = '{login_user}' and password = '{password_user}'";
                SqlCommand command = new SqlCommand(query_string, db.get_sql_connection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вход в систему");
                    catalog cat = new catalog();
                    this.Hide();
                    cat.Show();
                }
                else MessageBox.Show("такого аккаунта нит");
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void auth_Load_1(object sender, EventArgs e)
        {

        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            var login_user = inp_login_auth.Text;
            var password_user = inp_password_auth.Text;
            if (login_user.Length > 0 && password_user.Length > 0) f_auth(login_user, password_user);
            else MessageBox.Show("Заполните все поля");
        }

        private void button_to_reg_Click(object sender, EventArgs e)
        {
            try
            {
                reg reg = new reg();
                this.Hide();
                reg.Show();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
