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

namespace Projekt
{
    public partial class CreateOrEditTv : Form
    {
        public CreateOrEditTv()
        {
            InitializeComponent();
        }

        private void backToStartBtn_Click(object sender, EventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
            Close();
        }

        private void CreateOrEditTv_Load(object sender, EventArgs e)
        {
            fillPersonCombo();
            fillTvCategoryCombo();
        }

        private void fillPersonCombo()
        {
            String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            string selectPersonString = "select id, last_name + ' ' + first_name as Name from person";
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selectPersonString, connString);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);

                comboPersonId.DataSource = dt;
                comboPersonId.DisplayMember = "Name";
                comboPersonId.ValueMember = "id";
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void fillTvCategoryCombo()
        {
            String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
            SqlConnection sqlConnection2 = new SqlConnection(connString);
            string selectPersonString = "select id, category_name from tv_category";
            try
            {
                sqlConnection2.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selectPersonString, connString);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Please select";
                dt.Rows.InsertAt(row, 0);

                comboCategoryId.DataSource = dt;
                comboCategoryId.DisplayMember = "category_name";
                comboCategoryId.ValueMember = "id";
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection2.Close();
            }
        }

        private void CreateOrEditTv_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
            
        }
    }
}
