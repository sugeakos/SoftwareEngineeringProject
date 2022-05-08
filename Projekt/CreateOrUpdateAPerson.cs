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
    public partial class CreateOrUpdateAPerson : Form
    {
        public CreateOrUpdateAPerson()
        {
            InitializeComponent();
            txtPersonId.ReadOnly = true;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtFirstName.Enabled = false;
            txtJoinDate.Enabled = false;
            txtLastName.Enabled = false;
            txtPhoneMobile.Enabled = false;
            txtPhonFix.Enabled = false;

            createNewPersonBtn.Enabled = false;
            searchBtn.Enabled = false;
            updatePersonBtn.Enabled = false;

            searchByEmailRadio.Enabled = false;
            searchByFirstNameRadio.Enabled = false;
            searchByFixRadio.Enabled = false;
            searchByLastNameRadio.Enabled = false;
            searchByMobileRadio.Enabled = false;
        }

        private void backToStartBtn_Click(object sender, EventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
            Close();
        }

        private void searchRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (searchRadioBtn.Checked)
            {
                txtPersonId.ReadOnly = true;
                
                txtAddress.ReadOnly = true;
                txtAddress.Enabled = true;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = true;

                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = true;

                txtJoinDate.ReadOnly = true;
                txtJoinDate.Enabled = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = true;

                txtPhoneMobile.Enabled = true;
                txtPhoneMobile.ReadOnly = true;

                txtPhonFix.Enabled = true;
                txtPhonFix.ReadOnly = true;
                
                searchBtn.Enabled = true;
                createNewPersonBtn.Enabled = false;
                updatePersonBtn.Enabled = false;

                searchByEmailRadio.Enabled = true;
                searchByFirstNameRadio.Enabled = true;
                searchByFixRadio.Enabled = true;
                searchByLastNameRadio.Enabled = true;
                searchByMobileRadio.Enabled = true;

                clearTextBoxes();
            }
        }

        private void updateRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadioBtn.Checked)
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = false;
                txtAddress.Enabled = true;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = false;

                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = false;

                txtJoinDate.ReadOnly = true;
                txtJoinDate.Enabled = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = false;

                txtPhoneMobile.Enabled = true;
                txtPhoneMobile.ReadOnly = false;

                txtPhonFix.Enabled = true;
                txtPhonFix.ReadOnly = false;

                searchBtn.Enabled = true;
                createNewPersonBtn.Enabled = false;
                updatePersonBtn.Enabled = true;

                searchByEmailRadio.Enabled = true;
                searchByFirstNameRadio.Enabled = true;
                searchByFixRadio.Enabled = true;
                searchByLastNameRadio.Enabled = true;
                searchByMobileRadio.Enabled = true;
            }
        }

        private void createNewRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (createNewRadioBtn.Checked)
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = false;
                txtAddress.Enabled = true;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = false;

                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = false;

                txtJoinDate.ReadOnly = true;
                txtJoinDate.Enabled = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = false;

                txtPhoneMobile.Enabled = true;
                txtPhoneMobile.ReadOnly = false;

                txtPhonFix.Enabled = true;
                txtPhonFix.ReadOnly = false;

                searchBtn.Enabled = false;
                createNewPersonBtn.Enabled = true;
                updatePersonBtn.Enabled = false;

                searchByEmailRadio.Enabled = false;
                searchByFirstNameRadio.Enabled = false;
                searchByFixRadio.Enabled = false;
                searchByLastNameRadio.Enabled = false;
                searchByMobileRadio.Enabled = false;
                clearTextBoxes();

            }
        }

        private void clearTextBoxes()
        {
            txtPersonId.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtFirstName.Text = "";
            txtJoinDate.Text = "";
            txtLastName.Text = "";
            txtPhoneMobile.Text = "";
            txtPhonFix.Text = "";
        }
        private string firstLetterCapital(string str)
        {
            return Char.ToUpper(str[0]) + str.Remove(0, 1);
        }

        private string selectCommandString(string searchBy, string param)
        {
            return @"select * from person where " + searchBy + " like   "+ param ;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchByFirstNameRadio.Checked)
            {
                

                String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connString);
                string selectPersonByFirstNameCmdString = selectCommandString("first_name", "'%' + @firstName + '%'");
                MessageBox.Show(selectPersonByFirstNameCmdString);
                SqlCommand selectSqlCommand = new SqlCommand(selectPersonByFirstNameCmdString, sqlConnection);
                //selectSqlCommand.Parameters.Clear();
                selectSqlCommand.Parameters.AddWithValue("@firstName", firstLetterCapital(txtFirstName.Text));

                try
                {

                    
                    sqlConnection.Open();
                    SqlDataReader reader = selectSqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read())
                    {
                        txtPersonId.Text = reader[0].ToString();
                        txtFirstName.Text = reader[1].ToString();
                        txtLastName.Text = reader[2].ToString();
                        txtAddress.Text = reader[3].ToString();
                        txtEmail.Text = reader[4].ToString();
                        txtJoinDate.Text = reader[5].ToString();
                        txtPhonFix.Text = reader[6].ToString();
                        txtPhoneMobile.Text = reader[7].ToString();
                    }

                    else
                    {
                        MessageBox.Show("Can't find person with this first name: " + txtFirstName.Text);
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
            if(searchByLastNameRadio.Checked)
            {
                
                String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
                SqlConnection sqlConnection2 = new SqlConnection(connString);
                string selectPersonByLastNameCmdString = selectCommandString("last_name", "'%' + @lastName + '%'");
                MessageBox.Show(selectPersonByLastNameCmdString);
                SqlCommand selectSqlCommand = new SqlCommand(selectPersonByLastNameCmdString, sqlConnection2);
                //selectSqlCommand.Parameters.Clear();
                selectSqlCommand.Parameters.AddWithValue("@lastName", firstLetterCapital(txtLastName.Text));
                try
                {


                    sqlConnection2.Open();
                    SqlDataReader reader = selectSqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read())
                    {
                        txtPersonId.Text = reader[0].ToString();
                        txtFirstName.Text = reader[1].ToString();
                        txtLastName.Text = reader[2].ToString();
                        txtAddress.Text = reader[3].ToString();
                        txtEmail.Text = reader[4].ToString();
                        txtJoinDate.Text = reader[5].ToString();
                        txtPhonFix.Text = reader[6].ToString();
                        txtPhoneMobile.Text = reader[7].ToString();
                    }

                    else
                    {
                        MessageBox.Show("Can't find person with this last name: " + txtLastName.Text);
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
                    sqlConnection2.Close();
                }
            }

            if(searchByEmailRadio.Checked)
            {
                
                String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
                SqlConnection sqlConnection3 = new SqlConnection(connString);
                string selectPersonByLastNameCmdString = selectCommandString("email", "'%' + @email + '%'");
                MessageBox.Show(selectPersonByLastNameCmdString);
                SqlCommand selectSqlCommand = new SqlCommand(selectPersonByLastNameCmdString, sqlConnection3);
                //selectSqlCommand.Parameters.Clear();
                selectSqlCommand.Parameters.AddWithValue("@email", firstLetterCapital(txtEmail.Text));
                try
                {


                    sqlConnection3.Open();
                    SqlDataReader reader = selectSqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read())
                    {
                        txtPersonId.Text = reader[0].ToString();
                        txtFirstName.Text = reader[1].ToString();
                        txtLastName.Text = reader[2].ToString();
                        txtAddress.Text = reader[3].ToString();
                        txtEmail.Text = reader[4].ToString();
                        txtJoinDate.Text = reader[5].ToString();
                        txtPhonFix.Text = reader[6].ToString();
                        txtPhoneMobile.Text = reader[7].ToString();
                    }

                    else
                    {
                        MessageBox.Show("Can't find person with this email: " + txtEmail.Text);
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
                    sqlConnection3.Close();
                }
            }

            if (searchByMobileRadio.Checked)
            {
                if (txtPhoneMobile.Text.Length > 13)
                {
                    MessageBox.Show("A telefonszam max 12 karakter lehet");
                }
                else
                {
                    String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
                    SqlConnection sqlConnection4 = new SqlConnection(connString);
                    string selectPersonByLastNameCmdString = selectCommandString("phone_mobile", "'%' + @mobile + '%'");
                    MessageBox.Show(selectPersonByLastNameCmdString);
                    SqlCommand selectSqlCommand = new SqlCommand(selectPersonByLastNameCmdString, sqlConnection4);
                    //selectSqlCommand.Parameters.Clear();
                    selectSqlCommand.Parameters.AddWithValue("@mobile", txtPhoneMobile.Text);
                    try
                    {


                        sqlConnection4.Open();
                        SqlDataReader reader = selectSqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                        if (reader.Read())
                        {
                            txtPersonId.Text = reader[0].ToString();
                            txtFirstName.Text = reader[1].ToString();
                            txtLastName.Text = reader[2].ToString();
                            txtAddress.Text = reader[3].ToString();
                            txtEmail.Text = reader[4].ToString();
                            txtJoinDate.Text = reader[5].ToString();
                            txtPhonFix.Text = reader[6].ToString();
                            txtPhoneMobile.Text = reader[7].ToString();
                        }

                        else
                        {
                            MessageBox.Show("Can't find person with this mobile: " + txtPhoneMobile.Text);
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
                        sqlConnection4.Close();
                    }
                }
            }

            if(searchByFixRadio.Checked)
            {
                if (txtPhonFix.Text.Length > 13)
                {
                    MessageBox.Show("A telefonszam max 12 karakter lehet");
                }
                else
                {
                    String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
                    SqlConnection sqlConnection5 = new SqlConnection(connString);
                    string selectPersonByLastNameCmdString = selectCommandString("phone_fix", "'%' + @fix + '%'");
                    MessageBox.Show(selectPersonByLastNameCmdString);
                    SqlCommand selectSqlCommand = new SqlCommand(selectPersonByLastNameCmdString, sqlConnection5);
                    //selectSqlCommand.Parameters.Clear();
                    selectSqlCommand.Parameters.AddWithValue("@fix", txtPhoneMobile.Text);
                    try
                    {


                        sqlConnection5.Open();
                        SqlDataReader reader = selectSqlCommand.ExecuteReader(CommandBehavior.SingleRow);
                        if (reader.Read())
                        {
                            txtPersonId.Text = reader[0].ToString();
                            txtFirstName.Text = reader[1].ToString();
                            txtLastName.Text = reader[2].ToString();
                            txtAddress.Text = reader[3].ToString();
                            txtEmail.Text = reader[4].ToString();
                            txtJoinDate.Text = reader[5].ToString();
                            txtPhonFix.Text = reader[6].ToString();
                            txtPhoneMobile.Text = reader[7].ToString();
                        }

                        else
                        {
                            MessageBox.Show("Can't find person with this mobile: " + txtPhonFix.Text);
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
                        sqlConnection5.Close();
                    }
                }
            }
        }

        private void searchByFirstNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadioBtn.Checked)
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = false;
                txtAddress.Enabled = true;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = false;

                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = false;

                txtJoinDate.ReadOnly = true;
                txtJoinDate.Enabled = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = false;

                txtPhoneMobile.Enabled = true;
                txtPhoneMobile.ReadOnly = false;

                txtPhonFix.Enabled = true;
                txtPhonFix.ReadOnly = false;
            }
            else
            {

                txtPersonId.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = false;

                txtJoinDate.ReadOnly = true;
                txtLastName.ReadOnly = true;
                txtPhoneMobile.ReadOnly = true;
                txtPhonFix.ReadOnly = true;

                clearTextBoxes();
            }
        }

        private void searchByLastNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadioBtn.Checked)
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = false;
                txtAddress.Enabled = true;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = false;

                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = false;

                txtJoinDate.ReadOnly = true;
                txtJoinDate.Enabled = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = false;

                txtPhoneMobile.Enabled = true;
                txtPhoneMobile.ReadOnly = false;

                txtPhonFix.Enabled = true;
                txtPhonFix.ReadOnly = false;
            }
            else
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = true;

                txtEmail.ReadOnly = true;

                txtFirstName.ReadOnly = true;

                txtJoinDate.ReadOnly = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = false;

                txtPhoneMobile.ReadOnly = true;

                txtPhonFix.ReadOnly = true;
                clearTextBoxes();
            }
        }

        private void searchByEmailRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadioBtn.Checked)
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = false;
                txtAddress.Enabled = true;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = false;

                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = false;

                txtJoinDate.ReadOnly = true;
                txtJoinDate.Enabled = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = false;

                txtPhoneMobile.Enabled = true;
                txtPhoneMobile.ReadOnly = false;

                txtPhonFix.Enabled = true;
                txtPhonFix.ReadOnly = false;
            }
            else
            {


                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = true;

                txtEmail.ReadOnly = false;
                txtEmail.Enabled = true;

                txtFirstName.ReadOnly = true;

                txtJoinDate.ReadOnly = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = true;

                txtPhoneMobile.ReadOnly = true;

                txtPhonFix.ReadOnly = true;

                clearTextBoxes();
            }
        }

        private void searchByMobileRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadioBtn.Checked)
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = false;
                txtAddress.Enabled = true;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = false;

                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = false;

                txtJoinDate.ReadOnly = true;
                txtJoinDate.Enabled = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = false;

                txtPhoneMobile.Enabled = true;
                txtPhoneMobile.ReadOnly = false;

                txtPhonFix.Enabled = true;
                txtPhonFix.ReadOnly = false;
            }
            else
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = true;

                txtEmail.ReadOnly = true;

                txtFirstName.ReadOnly = true;

                txtJoinDate.ReadOnly = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = true;

                txtPhoneMobile.ReadOnly = false;
                txtPhoneMobile.Enabled = true;

                txtPhonFix.ReadOnly = true;
                clearTextBoxes();
            }
        }

        private void searchByFixRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (updateRadioBtn.Checked)
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = false;
                txtAddress.Enabled = true;

                txtEmail.Enabled = true;
                txtEmail.ReadOnly = false;

                txtFirstName.Enabled = true;
                txtFirstName.ReadOnly = false;

                txtJoinDate.ReadOnly = true;
                txtJoinDate.Enabled = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = false;

                txtPhoneMobile.Enabled = true;
                txtPhoneMobile.ReadOnly = false;

                txtPhonFix.Enabled = true;
                txtPhonFix.ReadOnly = false;
            }
            else
            {
                txtPersonId.ReadOnly = true;

                txtAddress.ReadOnly = true;

                txtEmail.ReadOnly = true;

                txtFirstName.ReadOnly = true;

                txtJoinDate.ReadOnly = true;

                txtLastName.Enabled = true;
                txtLastName.ReadOnly = true;

                txtPhoneMobile.ReadOnly = true;

                txtPhonFix.ReadOnly = false;
                txtPhonFix.Enabled = true;
                clearTextBoxes();
            }
        }

        private void createNewPersonBtn_Click(object sender, EventArgs e)
        {
            String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            string createNewPErson = "insert into person (first_name, last_name, address_line, email, join_date, phone_fix, phone_mobile) values (@firstName, @lastName, @address, @email, @joinDate, @phoneFix, @phoneMobile)";
            
            SqlCommand selectSqlCommand = new SqlCommand(createNewPErson, sqlConnection);
            //selectSqlCommand.Parameters.Clear();
            selectSqlCommand.Parameters.AddWithValue("@firstName", firstLetterCapital(txtFirstName.Text));
            selectSqlCommand.Parameters.AddWithValue("@lastName", firstLetterCapital(txtLastName.Text));
            selectSqlCommand.Parameters.AddWithValue("@address", firstLetterCapital(txtAddress.Text));
            selectSqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            selectSqlCommand.Parameters.AddWithValue("@joinDate", DateTime.Now);
            selectSqlCommand.Parameters.AddWithValue("@phoneFix", txtPhonFix.Text);
            selectSqlCommand.Parameters.AddWithValue("@phoneMobile", txtPhoneMobile.Text);

            if (txtPhoneMobile.Text.Length > 13 && txtPhonFix.Text.Length > 13 && txtPhoneMobile.Text.Contains(@"^\\\\d{12}$") && txtPhonFix.Text.Contains(@"^\\\\d{12}$"))
            {
                MessageBox.Show("Max 12 karakter!!!");
            }
            else
            {
                try
                {


                    sqlConnection.Open();
                    int result = selectSqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("YEEEEE");
                    }

                    else
                    {
                        MessageBox.Show("Shit happens " );
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

        private void updatePersonBtn_Click(object sender, EventArgs e)
        {
            String connString = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connString);
            string createNewPErson = "update person set first_name = @firstName , last_name = @lastName, address_line = @address, email = @email, phone_fix = @phoneFix, phone_mobile = @phoneMobile where id = @id";

            SqlCommand selectSqlCommand = new SqlCommand(createNewPErson, sqlConnection);
            //selectSqlCommand.Parameters.Clear();
            selectSqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(txtPersonId.Text));
            selectSqlCommand.Parameters.AddWithValue("@firstName", firstLetterCapital(txtFirstName.Text));
            selectSqlCommand.Parameters.AddWithValue("@lastName", firstLetterCapital(txtLastName.Text));
            selectSqlCommand.Parameters.AddWithValue("@address", firstLetterCapital(txtAddress.Text));
            selectSqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            selectSqlCommand.Parameters.AddWithValue("@phoneFix", txtPhonFix.Text);
            selectSqlCommand.Parameters.AddWithValue("@phoneMobile", txtPhoneMobile.Text);

            if (txtPhoneMobile.Text.Length > 13 && txtPhonFix.Text.Length > 13 && txtPhoneMobile.Text.Contains(@"^\\\\d{12}$") && txtPhonFix.Text.Contains(@"^\\\\d{12}$"))
            {
                MessageBox.Show("Max 12 karakter!!!");
            }
            else
            {
                try
                {


                    sqlConnection.Open();
                    int result = selectSqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("YEEEEE");
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
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            txtPersonId.ReadOnly = true;

            txtAddress.ReadOnly = true;

            txtEmail.ReadOnly = true;

            txtFirstName.ReadOnly = true;

            txtJoinDate.ReadOnly = true;

            txtLastName.Enabled = true;
            txtLastName.ReadOnly = true;

            txtPhoneMobile.ReadOnly = true;
            txtPhonFix.ReadOnly = true;
            updatePersonBtn.Enabled = false;
        }

        private void CreateOrUpdateAPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainView = (MainView)Tag;
            mainView.Show();
        }
    }
}
