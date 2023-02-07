using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _07_02_2023
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Авторизация по логину и паролю
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.CourierConnectionString))
            {
                try
                {
                    string query = "SELECT * FROM `Courier`.`users` WHERE `user_log` = @user AND `user_pwd` = @password";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                    da.SelectCommand.Parameters.AddWithValue("@user", txtLogin.Text);
                    da.SelectCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                    da.Fill(dt);

                    if (txtLogin.Text == "") { MessageBox.Show("Вы не ввели логин. Перепроверьте вводимые данные!"); }
                    else if (txtPassword.Text == "") { MessageBox.Show("Вы не ввели пароль. Перепроверьте вводимые данные!"); }
                    else if (dt.Rows.Count == 1)
                    {
                        User.UserId = Convert.ToInt32(dt.Rows[0]["user_id"]);
                        Main mainForm = new Main();
                        this.Hide();
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Перепроверьте вводимые данные!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }      
        }
    }
}