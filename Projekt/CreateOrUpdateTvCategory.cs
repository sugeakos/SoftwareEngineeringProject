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
    public partial class CreateOrUpdateTvCategory : Form
    {

        public CreateOrUpdateTvCategory()
        {
            InitializeComponent();

            txtCategoryId.ReadOnly = true;
            createNewCategoryBtn.Enabled = false;
            updateCategoryBtn.Enabled = false;
            selectCategoryBtn.Enabled = false;
            txtCategoryName.Enabled = false;
        }

        private void backToStartBtn_Click(object sender, EventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
            Close();
        }

        private void selectCategoryBtn_Click(object sender, EventArgs e)
        {
            txtCategoryId.ReadOnly = true;
            String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            string selectCategoryByNameCmd = @"select * from tv_category where category_name like '%' + @catName + '%'";
            SqlCommand selectSqlCommand = new SqlCommand(selectCategoryByNameCmd, sqlConnection);
            //selectSqlCommand.Parameters.Clear();
            selectSqlCommand.Parameters.AddWithValue("@catName", firstLetterCapital( txtCategoryName.Text));

            try
            {


                sqlConnection.Open();
                SqlDataReader reader = selectSqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read())
                {
                    txtCategoryId.Text = reader[0].ToString();
                    txtCategoryName.Text = reader[1].ToString();
                }

                else
                {
                    MessageBox.Show("Can't find category with this name: " + txtCategoryName.Text);
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void searchRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

            if (searchRadioBtn.Checked == true)
            {
                txtCategoryId.ReadOnly = true;
                createNewCategoryBtn.Enabled = false;
                updateCategoryBtn.Enabled = false;
                selectCategoryBtn.Enabled = true;
                txtCategoryName.Enabled = true;
                clearTextBoxes();
            }

        }

        private void updateRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadioBtn.Checked)
            {
                txtCategoryId.ReadOnly = true;
                createNewCategoryBtn.Enabled = false;
                updateCategoryBtn.Enabled = true;
                selectCategoryBtn.Enabled = true;
                txtCategoryName.Enabled = true;
            }
        }

        private void createNewRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (createNewRadioBtn.Checked)
            {
                txtCategoryId.ReadOnly = true;
                createNewCategoryBtn.Enabled = true;
                updateCategoryBtn.Enabled = false;
                selectCategoryBtn.Enabled = false;
                txtCategoryName.Enabled = true;
                clearTextBoxes();

            }
        }

        private void createNewCategoryBtn_Click(object sender, EventArgs e)
        {
            String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            string createNewCategoryCmd = @"insert into tv_category (category_name) values (@catName)";
            SqlCommand selectSqlCommand = new SqlCommand(createNewCategoryCmd, sqlConnection);
            //selectSqlCommand.Parameters.Clear();
            selectSqlCommand.Parameters.AddWithValue("@catName", firstLetterCapital( txtCategoryName.Text));

            try
            {


                sqlConnection.Open();
                int result = selectSqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("YEEEE");
                }

                else
                {
                    MessageBox.Show("Shit happens ");
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private string firstLetterCapital(string str)
        {
            return Char.ToUpper(str[0]) + str.Remove(0, 1);
        }

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            string createNewCategoryCmd = @"update tv_category set category_name = @catName where id = @id";
            SqlCommand selectSqlCommand = new SqlCommand(createNewCategoryCmd, sqlConnection);
            //selectSqlCommand.Parameters.Clear();
            selectSqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(txtCategoryId.Text));
            selectSqlCommand.Parameters.AddWithValue("@catName", firstLetterCapital(txtCategoryName.Text));

            try
            {


                sqlConnection.Open();
                int result = selectSqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("YEEEE");
                    
                }

                else
                {
                    MessageBox.Show("Shit happens ");
                }
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void clearTextBoxes()
        {
            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
        }

        private void CreateOrUpdateTvCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
        }
    }
}
