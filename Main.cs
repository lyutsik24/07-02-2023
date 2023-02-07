using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_02_2023
{
    public partial class Main : Form
    {
        public int? DelID; //Хранение ID заказа

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Сортировка от меньшего к большему
        /// </summary>
        private void btnDownUp_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.CourierConnectionString))
            {
                try
                {
                    string query = @"SELECT 
			                            `del_id` AS `№ заказа`,
			                            `del_date` AS `Дата`,
			                            `cour_name` AS `Курьер`,
			                            `del_list` AS `Заказ`,
			                            `del_comm` AS `Комментарий`,
			                            `status_name` AS `Статус`
		                            FROM `Courier`.`delivery`
			                            JOIN `Courier`.`courier` ON `Courier`.`delivery`.`del_courier` = `Courier`.`courier`.`cour_id`
			                            JOIN `Courier`.`statuses` ON `Courier`.`delivery`.`del_status` = `Courier`.`statuses`.`status_id`
		                            WHERE `del_recive` =@u_id ORDER BY `del_date` ASC";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                    da.SelectCommand.Parameters.AddWithValue("@u_id", User.UserId);
                    da.Fill(dt);
                    dgvMain.DataSource = dt;
                    dgvMain.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[0].DisplayIndex = 0;
                    dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[1].DisplayIndex = 1;
                    dgvMain.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvMain.Columns[2].DisplayIndex = 2;
                    dgvMain.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[3].DisplayIndex = 3;
                    dgvMain.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[4].DisplayIndex = 4;
                    dgvMain.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[5].DisplayIndex = 5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Сортировка от большего к меньшему
        /// </summary>
        private void btnUpDown_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.CourierConnectionString))
            {
                try
                {
                    string query = @"SELECT 
			                            `del_id` AS `№ заказа`,
			                            `del_date` AS `Дата`,
			                            `cour_name` AS `Курьер`,
			                            `del_list` AS `Заказ`,
			                            `del_comm` AS `Комментарий`,
			                            `status_name` AS `Статус`
		                            FROM `Courier`.`delivery`
			                            JOIN `Courier`.`courier` ON `Courier`.`delivery`.`del_courier` = `Courier`.`courier`.`cour_id`
			                            JOIN `Courier`.`statuses` ON `Courier`.`delivery`.`del_status` = `Courier`.`statuses`.`status_id`
		                            WHERE `del_recive` =@u_id ORDER BY `del_date` DESC";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                    da.SelectCommand.Parameters.AddWithValue("@u_id", User.UserId);
                    da.Fill(dt);
                    dgvMain.DataSource = dt;
                    dgvMain.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[0].DisplayIndex = 0;
                    dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[1].DisplayIndex = 1;
                    dgvMain.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvMain.Columns[2].DisplayIndex = 2;
                    dgvMain.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[3].DisplayIndex = 3;
                    dgvMain.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[4].DisplayIndex = 4;
                    dgvMain.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[5].DisplayIndex = 5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Поиск по диапозону
        /// </summary>
        private void btnRange_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.CourierConnectionString))
            {
                try
                {
                    string query = @"SELECT 
		                                `del_id` AS `№ заказа`,
		                                `del_date` AS `Дата`,
		                                `cour_name` AS `Курьер`,
		                                `del_list` AS `Заказ`,
		                                `del_comm` AS `Комментарий`,
		                                `status_name` AS `Статус`
	                                FROM 
		                                `Courier`.`delivery`
	                                JOIN `Courier`.`courier` ON `Courier`.`delivery`.`del_courier` = `Courier`.`courier`.`cour_id`
	                                JOIN `Courier`.`statuses` ON `Courier`.`delivery`.`del_status` = `Courier`.`statuses`.`status_id`
	                                WHERE 
		                                ((`del_recive` = @u_id) AND (`del_date` >= @firstDate) AND (`del_date` <= @secondDate))";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                    da.SelectCommand.Parameters.AddWithValue("@u_id", User.UserId);
                    da.SelectCommand.Parameters.AddWithValue("@firstDate", dtpFirst.Value.Date.ToString("yyyy-MM-dd"));
                    da.SelectCommand.Parameters.AddWithValue("@secondDate", dtpSecond.Value.Date.ToString("yyyy-MM-dd"));
                    da.Fill(dt);
                    dgvMain.DataSource = dt;
                    dgvMain.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[0].DisplayIndex = 0;
                    dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[1].DisplayIndex = 1;
                    dgvMain.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvMain.Columns[2].DisplayIndex = 2;
                    dgvMain.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[3].DisplayIndex = 3;
                    dgvMain.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[4].DisplayIndex = 4;
                    dgvMain.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[5].DisplayIndex = 5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Поиск по дате
        /// </summary>
        private void btnDate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.CourierConnectionString))
            {
                try
                {
                    string query = @"SELECT 
		                                `del_id` AS `№ заказа`,
		                                `del_date` AS `Дата`,
		                                `cour_name` AS `Курьер`,
		                                `del_list` AS `Заказ`,
		                                `del_comm` AS `Комментарий`,
		                                `status_name` AS `Статус`
	                                FROM 
		                                `Courier`.`delivery`
	                                JOIN `Courier`.`courier` ON `Courier`.`delivery`.`del_courier` = `Courier`.`courier`.`cour_id`
	                                JOIN `Courier`.`statuses` ON `Courier`.`delivery`.`del_status` = `Courier`.`statuses`.`status_id`
	                                WHERE 
		                                ((`del_recive` = @u_id) AND (`del_date` = @firstDate))";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                    da.SelectCommand.Parameters.AddWithValue("@u_id", User.UserId);
                    da.SelectCommand.Parameters.AddWithValue("@firstDate", dtpFirst.Value.Date.ToString("yyyy-MM-dd"));

                    da.Fill(dt);
                    dgvMain.DataSource = dt;
                    dgvMain.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[0].DisplayIndex = 0;
                    dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[1].DisplayIndex = 1;
                    dgvMain.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvMain.Columns[2].DisplayIndex = 2;
                    dgvMain.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[3].DisplayIndex = 3;
                    dgvMain.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[4].DisplayIndex = 4;
                    dgvMain.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[5].DisplayIndex = 5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Получение ID заказа
        /// </summary>
        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMain.Rows[e.RowIndex];
                DelID = (int)row.Cells[0].Value;
            }
        }

        /// <summary>
        /// Загрузка деталей заказа
        /// </summary>
        private void dgvMain_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMain.Rows[e.RowIndex];
                DelID = (int)row.Cells[0].Value;
            }

            if (DelID == null)
            {
                MessageBox.Show("Пожалуйста, выберите данные в таблице.", "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                Module od = new Module(this);
                od.ShowDialog();
            }
        }

        /// <summary>
        /// Загрузка данных из БД
        /// </summary>
        public void Reset()
        {
            using (MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.CourierConnectionString))
            {
                try
                {
                    string query = @"SELECT 
		                                `del_id` AS `№ заказа`,
		                                `del_date` AS `Дата`,
		                                `cour_name` AS `Курьер`,
		                                `del_list` AS `Заказ`,
		                                `del_comm` AS `Комментарий`,
		                                `status_name` AS `Статус`
	                                FROM `Courier`.`delivery`
                                        JOIN `Courier`.`courier` ON `Courier`.`delivery`.`del_courier` = `Courier`.`courier`.`cour_id`
		                                JOIN `Courier`.`statuses` ON `Courier`.`delivery`.`del_status` = `Courier`.`statuses`.`status_id`
	                                WHERE `del_recive` = @u_id; ";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                    da.SelectCommand.Parameters.AddWithValue("@u_id", User.UserId);
                    da.Fill(dt);
                    dgvMain.DataSource = dt;
                    dgvMain.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[0].DisplayIndex = 0;
                    dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[1].DisplayIndex = 1;
                    dgvMain.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvMain.Columns[2].DisplayIndex = 2;
                    dgvMain.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[3].DisplayIndex = 3;
                    dgvMain.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[4].DisplayIndex = 4;
                    dgvMain.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgvMain.Columns[5].DisplayIndex = 5;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
