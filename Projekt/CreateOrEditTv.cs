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
        int isStillInProgress;
        int missingPart;
        public CreateOrEditTv()
        {
            InitializeComponent();
            comboTvId.Enabled = false;
            comboPersonId.Enabled = false;
            comboCategoryId.Enabled = false;
            txtErrorByCustomer.Enabled = false;
            txtDateOfCorrection.Enabled = false;
            txtDateOfReceip.Enabled = false;
            txtPrice.Enabled = false;
            txtMissingParts.Enabled = false;
            txtCorrectedError.Enabled = false;
            

            stillInProgressRadio.Enabled = false;
            notInProgressRadio.Enabled = false;


            hasAnyMissingPart.Enabled = false;
            hasNoMissingParts.Enabled = false;

            updateBtn.Enabled = false;
            createNewBtn.Enabled = false;
            
        }

        private void backToStartBtn_Click(object sender, EventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
            Close();
        }

        private void CreateOrEditTv_Load(object sender, EventArgs e)
        {
            fillTvCombo();
            fillPersonCombo();
            fillTvCategoryCombo();
            
        }

        private void fillPersonCombo()
        {
            SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string selectPersonString = "select id, last_name + ' ' + first_name as Name from person";
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selectPersonString, GlobalConstants.DATA_CONNECTION_STRING);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Válassz személyt";
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
        private void fillTvCombo()
        {
            
            SqlConnection sqlConnection3 = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string selectTvString = "select id from tv";
            try
            {
                sqlConnection3.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selectTvString, GlobalConstants.DATA_CONNECTION_STRING);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);

                comboTvId.DataSource = dt;
                comboTvId.DisplayMember = "id";
                comboTvId.ValueMember = "id";
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
                sqlConnection3.Close();
            }
        }
        private void fillTvCategoryCombo()
        {
            
            SqlConnection sqlConnection2 = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string selectTvCategoryString = GlobalConstants.SELECT_FROM_TV_CATEGORY_STRING;
            try
            {
                sqlConnection2.Open();
                SqlDataAdapter sda = new SqlDataAdapter(selectTvCategoryString, GlobalConstants.DATA_CONNECTION_STRING);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                row[0] = 0;
                row[1] = "Válassz márkát";
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

        private void selectRadio_CheckedChanged(object sender, EventArgs e)
        {
            if(selectRadio.Checked)
            {
                comboTvId.Enabled = true;
                comboPersonId.Enabled = false;
                comboCategoryId.Enabled = false;

                txtErrorByCustomer.Enabled = true;
                txtErrorByCustomer.ReadOnly = true;

                txtDateOfCorrection.Enabled = true;
                txtDateOfCorrection.ReadOnly = true;

                txtDateOfReceip.Enabled = true;
                txtDateOfReceip.ReadOnly = true;
                
                txtPrice.Enabled = true;
                txtPrice.ReadOnly = true;
                
                txtMissingParts.Enabled = true;
                txtMissingParts.ReadOnly = true;
                
                txtCorrectedError.Enabled = true;
                txtCorrectedError.ReadOnly = true;

                stillInProgressRadio.Enabled = false;

                notInProgressRadio.Enabled = false;


                hasAnyMissingPart.Enabled = false;
                hasNoMissingParts.Enabled = false;

       
                updateBtn.Enabled = false;
                createNewBtn.Enabled = false;
            }
        }
        private void clearTextBoxes()
        {
            
            txtErrorByCustomer.Text = "";
            txtDateOfCorrection.Text = "";
            txtDateOfReceip.Text = "";
            txtPrice.Text = "";
            txtMissingParts.Text = "";
            txtCorrectedError.Text = "";
        }

        private void updateRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadio.Checked)
            {
                comboTvId.Enabled = true;
               
                comboPersonId.Enabled = false;
                comboCategoryId.Enabled = false;
                txtErrorByCustomer.Enabled = true;
                txtErrorByCustomer.ReadOnly = true;

                txtDateOfCorrection.Enabled = true;
                txtDateOfCorrection.ReadOnly = true;

                txtDateOfReceip.Enabled = true;
                txtDateOfReceip.ReadOnly = true;

                txtPrice.Enabled = true;
                txtPrice.ReadOnly = false;

                txtMissingParts.Enabled = true;
                txtMissingParts.ReadOnly = false;

                txtCorrectedError.Enabled = true;
                txtCorrectedError.ReadOnly = false;

                stillInProgressRadio.Enabled = true;

                notInProgressRadio.Enabled = true;


                hasAnyMissingPart.Enabled = true;
                hasNoMissingParts.Enabled = true;

                txtMissingParts.Enabled = true;
                txtMissingParts.ReadOnly = true;

          
                updateBtn.Enabled = true;
                createNewBtn.Enabled = false;
            }
        }

        private void createRadio_CheckedChanged(object sender, EventArgs e)
        {
            comboTvId.Enabled = false;
            comboPersonId.Enabled = true;
            comboCategoryId.Enabled = true;

            txtErrorByCustomer.Enabled = true;
            txtErrorByCustomer.ReadOnly = false;

            txtDateOfCorrection.Enabled = true;
            txtDateOfCorrection.ReadOnly = true;

            txtDateOfReceip.Enabled = true;
            txtDateOfReceip.ReadOnly = true;

            txtPrice.Enabled = true;
            txtPrice.ReadOnly = true;

            txtMissingParts.Enabled = true;
            txtMissingParts.ReadOnly = false;

            txtCorrectedError.Enabled = true;
            txtCorrectedError.ReadOnly = true;

            stillInProgressRadio.Enabled = true;

            notInProgressRadio.Enabled = true;


            hasAnyMissingPart.Enabled = true;
            hasNoMissingParts.Enabled = true;

            
            updateBtn.Enabled = false;
            createNewBtn.Enabled = true;
        }

        private void createNewBtn_Click(object sender, EventArgs e)
        {
            
            if (stillInProgressRadio.Checked)
            {
                isStillInProgress = 1;
            }
            else if (notInProgressRadio.Checked)
            {
                isStillInProgress = 0;
            }
            if (hasNoMissingParts.Checked)
            {
                missingPart = 1;
            }
            else if (hasNoMissingParts.Checked)
            {
                missingPart = 0;
            }

            if (createRadio.Checked)
            {


                SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
                string createNewTv = GlobalConstants.INSERT_TO_TV_STRING +" (@personID, @categoryID,@errorByCustomer,@isStillInProgress , @reservedDate, @hasAnyMissingParts, @missingParts) ";
                
                SqlCommand selectSqlCommand = new SqlCommand(createNewTv, sqlConnection);
                //selectSqlCommand.Parameters.Clear();
                selectSqlCommand.Parameters.AddWithValue("@personID", Convert.ToInt32(comboPersonId.SelectedValue));
                selectSqlCommand.Parameters.AddWithValue("@categoryID", Convert.ToInt32(comboCategoryId.SelectedValue));
                selectSqlCommand.Parameters.AddWithValue("@errorByCustomer",GlobalConstants.firstLetterCapital( txtErrorByCustomer.Text));
                selectSqlCommand.Parameters.AddWithValue("@isStillInProgress", isStillInProgress);
                selectSqlCommand.Parameters.AddWithValue("@reservedDate", DateTime.Now);
                selectSqlCommand.Parameters.AddWithValue("@hasAnyMissingParts", missingPart);
                selectSqlCommand.Parameters.AddWithValue("@missingParts",GlobalConstants.firstLetterCapital( txtMissingParts.Text));


                try
                {


                    sqlConnection.Open();
                    int result = selectSqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                       
                    }

                    else
                    {
                        MessageBox.Show("Hiba történt", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                    clearTextBoxes();
                }

                string insertIntoCustomer = GlobalConstants.INSERT_TO_CUSTOMER_STRING + " (@personId, @tvId)";
                SqlCommand insertToCustomer = new SqlCommand(insertIntoCustomer, sqlConnection);
                //selectSqlCommand.Parameters.Clear();
                insertToCustomer.Parameters.AddWithValue("@personId", comboPersonId.SelectedValue);
                insertToCustomer.Parameters.AddWithValue("@tvId", comboTvId.SelectedValue);

                try
                {


                    sqlConnection.Open();
                    int result = insertToCustomer.ExecuteNonQuery();
                    if (result > 0)
                    {
                        
                    }

                    else
                    {
                        MessageBox.Show("Hiba történt", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
        }

        private void hasAnyMissingPart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hasNoMissingParts_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboTvId_SelectedValueChanged(object sender, EventArgs e)
        {
            
            SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string fillTextBoxes = GlobalConstants.SELECT_EVERYTHING_FRON_TV_STRING + " @id";
            SqlCommand selectSqlCommand = new SqlCommand(fillTextBoxes, sqlConnection);
          
            selectSqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(comboTvId.SelectedIndex.ToString()));

            try
            {
                sqlConnection.Open();
                SqlDataReader reader = selectSqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    comboPersonId.SelectedValue = Convert.ToInt32( reader["person_id"].ToString());
                    comboCategoryId.SelectedValue = Convert.ToInt32(reader["tv_category_id"].ToString());
                    txtDateOfCorrection.Text = reader["date_of_correction"].ToString();
                    txtErrorByCustomer.Text = reader["error_seen_by_customer"].ToString();
                    isStillInProgress = Convert.ToInt32(reader["is_it_still_in_progress"]);
                    if (isStillInProgress == 1)
                    {
                        stillInProgressRadio.Focus();
                    }
                    else
                    {
                        notInProgressRadio.Focus();
                    }

                    txtCorrectedError.Text = reader["repaired_error"].ToString();
                    txtDateOfReceip.Text = reader["reserved_date_to_repair"].ToString();
                    missingPart = Convert.ToInt32(reader["has_any_missing_parts"]);
                    if (missingPart == 1)
                    {
                        hasAnyMissingPart.Focus();
                    }
                    else
                    {
                        hasNoMissingParts.Focus();
                    }
                    txtMissingParts.Text = reader["missing_parts"].ToString();
                    txtPrice.Text = reader["price"].ToString();

                }

                else
                {
                   
                }
            }
            
           
            finally
            {
                sqlConnection.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (stillInProgressRadio.Checked)
            {
                isStillInProgress = 1;
            }
            else if (notInProgressRadio.Checked)
            {
                isStillInProgress = 0;
            }
            
            SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string updateTvTable = "update tv set date_of_correction = @dateOfCorrection, is_it_still_in_progress = @isInProgress, repaired_error = @correctedError, price = @price where id = @id";
            SqlCommand updateTv = new SqlCommand(updateTvTable, sqlConnection);
            updateTv.Parameters.AddWithValue("@id", Convert.ToInt32(comboTvId.SelectedValue));
            updateTv.Parameters.AddWithValue("@dateOfCorrection",DateTime.Now);
            updateTv.Parameters.AddWithValue("@isInProgress", Convert.ToInt32(isStillInProgress));
            updateTv.Parameters.AddWithValue("@correctedError",GlobalConstants.firstLetterCapital( txtCorrectedError.Text));
            updateTv.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));

            try
            {


                sqlConnection.Open();
                int result = updateTv.ExecuteNonQuery();
                if (result > 0)
                {
                    
                }

                else
                {
                    MessageBox.Show("Hiba történt", "Hiba", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("A 'Javítás ára' mező csak számokat tartalmazhat", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            clearTextBoxes();
        }
    }
    
}
