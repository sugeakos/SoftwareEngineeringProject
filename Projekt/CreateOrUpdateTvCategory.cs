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
            
            SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string selectCategoryByNameCmd = @"select * from tv_category where category_name like '%' + @catName + '%'";
            SqlCommand selectSqlCommand = new SqlCommand(selectCategoryByNameCmd, sqlConnection);
            //selectSqlCommand.Parameters.Clear();
            selectSqlCommand.Parameters.AddWithValue("@catName",GlobalConstants. firstLetterCapital( txtCategoryName.Text));

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
                    MessageBox.Show("A keresett márka nem található: " + txtCategoryName.Text, "Nem található", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string createNewCategoryCmd = @"insert into tv_category (category_name) values (@catName)";
            SqlCommand selectSqlCommand = new SqlCommand(createNewCategoryCmd, sqlConnection);
            
            selectSqlCommand.Parameters.AddWithValue("@catName",GlobalConstants. firstLetterCapital( txtCategoryName.Text));

            try
            {


                sqlConnection.Open();
                int result = selectSqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sikeres bevitel", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Hiba ", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
      

        private void updateCategoryBtn_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string createNewCategoryCmd = @"update tv_category set category_name = @catName where id = @id";
            SqlCommand selectSqlCommand = new SqlCommand(createNewCategoryCmd, sqlConnection);
            //selectSqlCommand.Parameters.Clear();
            selectSqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(txtCategoryId.Text));
            selectSqlCommand.Parameters.AddWithValue("@catName",GlobalConstants. firstLetterCapital(txtCategoryName.Text));

            try
            {


                sqlConnection.Open();
                int result = selectSqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                   
                    
                }

                else
                {
                    MessageBox.Show("Hiba történt ","Hiba", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
