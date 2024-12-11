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
    public partial class reg : Form
    {
        db db = new db();
        public reg()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void reg_Load(object sender, EventArgs e)
        {

        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            
        }

        private Boolean check_user(string login)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand($"select login from [user] where login = '{login}'", db.get_sql_connection());

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует");
                return true;
            }
            else return false;
        }

        private void button_reg_Click_1(object sender, EventArgs e)
        {   
            try
            {
                var login = TB_login_reg.Text;
                var password = TB_password_reg.Text;
                var name = TB_name_reg.Text;
                var surname = TB_surname_reg.Text;

                if (login.Length > 0 && password.Length > 0 && name.Length > 0 && surname.Length > 0)
                {
                    if (check_user(login) == false)
                    {
                        SqlCommand command = new SqlCommand($"insert into [user](name, surname, login, password, id_status) values('{name}', '{surname}', '{login}', '{password}', '2')", db.get_sql_connection());
                        db.open_connection();

                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Пользователь зарегистрирован");
                            auth auth = new auth();
                            this.Hide();
                            auth.f_auth(login, password);
                        }
                        else MessageBox.Show("такого аккаунта нит");
                    }
                    db.close_connection();
                }
                else MessageBox.Show("Заполните все поля");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_go_to_auth_Click(object sender, EventArgs e)
        {
            auth auth = new auth();
            this.Hide();
            auth.Show();
        }
    }
}
