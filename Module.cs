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
    public partial class Module : Form
    {
        private Main fromForm { get; set; }
        private int? id; 

        public Module(Main form)
        {
            InitializeComponent();
            fromForm = form;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Загрузка деталей
        /// </summary>
        private void Module_Load(object sender, EventArgs e)
        {
            id = fromForm.DelID;
            btn_Exit.Select();
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
		                            WHERE `del_id` = @u_id;";
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, cn);
                    da.SelectCommand.Parameters.AddWithValue("@u_id", id);
                    da.Fill(dt);
                    lblPCode.Text = dt.Rows[0]["№ заказа"].ToString();
                    txtDate.Text = dt.Rows[0]["Дата"].ToString();
                    txtCour.Text = dt.Rows[0]["Курьер"].ToString();
                    txtList.Text = dt.Rows[0]["Заказ"].ToString();
                    txtStatus.Text = dt.Rows[0]["Статус"].ToString();
                    txtComm.Text = dt.Rows[0]["Комментарий"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
