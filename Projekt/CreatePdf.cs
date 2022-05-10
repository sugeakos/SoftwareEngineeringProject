using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Data.SqlClient;

namespace Projekt
{
    public partial class CreatePdf : Form
    {
        public CreatePdf()
        {
            InitializeComponent();
            txtAddress.ReadOnly = true;
            txtCorrectedError.ReadOnly = true;
            txtDateOfCorrection.ReadOnly = true;
            txtDateOfReceipt.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtErrorSeenByCustomer.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtHasAnyMissingPart.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtMissingParts.ReadOnly = true;
            txtPhoneFix.ReadOnly = true;
            txtPhoneMobile.ReadOnly = true;
            txtPriceOfCorrection.ReadOnly = true;
            txtTvCategory.ReadOnly = true;
           
        }

        private void CreatePdf_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
        }

        private void backToStartBtn_Click(object sender, EventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
            Close();
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
                //row[0] = 0;
                //row[1] = "Válassz személyt";
                //dt.Rows.InsertAt(row, 0);

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
        private void comboPersonId_SelectedValueChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            string selectPersonString = "SELECT tv.id FROM customer INNER JOIN person ON customer.customer_person_id = person.id INNER JOIN tv ON customer.customers_tv_id = tv.id AND person.id = tv.person_id INNER JOIN tv_category ON tv.tv_category_id = tv_category.id WHERE(person.id = @personId)";
            try
            {
                sqlConnection.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2.SelectCommand = new SqlCommand(selectPersonString, sqlConnection);
                sda2.SelectCommand.Parameters.AddWithValue("@personId", Convert.ToInt32(comboPersonId.SelectedIndex.ToString()));
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                DataRow row2 = dt2.NewRow();
                row2[0] = 0;
                row2[1] = 0;
                dt2.Rows.InsertAt(row2, 0);

                comboTv.DataSource = dt2;
                comboTv.DisplayMember = "tv.id";
                comboTv.ValueMember = "tv.id";
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

        private void CreatePdf_Load(object sender, EventArgs e)
        {
            fillPersonCombo();
        }

        private void comboTv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            //string fillTextBoxes = GlobalConstants.SELECT_EVERYTHING_FRON_TV_STRING + " @id";
            //SqlCommand selectSqlCommand = new SqlCommand(fillTextBoxes, sqlConnection);

            //selectSqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(comboPersonId.SelectedIndex.ToString()));

            //try
            //{
            //    sqlConnection.Open();
            //    SqlDataReader reader = selectSqlCommand.ExecuteReader();
            //    if (reader.Read())
            //    {
            //        comboPersonId.SelectedValue = Convert.ToInt32(reader["person_id"].ToString());
            //        comboCategoryId.SelectedValue = Convert.ToInt32(reader["tv_category_id"].ToString());
            //        txtDateOfCorrection.Text = reader["date_of_correction"].ToString();
            //        txtErrorByCustomer.Text = reader["error_seen_by_customer"].ToString();
            //        isStillInProgress = Convert.ToInt32(reader["is_it_still_in_progress"]);
            //        if (isStillInProgress == 1)
            //        {
            //            stillInProgressRadio.Focus();
            //        }
            //        else
            //        {
            //            notInProgressRadio.Focus();
            //        }

            //        txtCorrectedError.Text = reader["repaired_error"].ToString();
            //        txtDateOfReceip.Text = reader["reserved_date_to_repair"].ToString();
            //        missingPart = Convert.ToInt32(reader["has_any_missing_parts"]);
            //        if (missingPart == 1)
            //        {
            //            hasAnyMissingPart.Focus();
            //        }
            //        else
            //        {
            //            hasNoMissingParts.Focus();
            //        }
            //        txtMissingParts.Text = reader["missing_parts"].ToString();
            //        txtPrice.Text = reader["price"].ToString();

            //    }

            //    else
            //    {

            //    }
            //}


            //finally
            //{
            //    sqlConnection.Close();
            //}
        }
    }
}
