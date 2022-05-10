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
     
        private string selectCommandString(string searchBy, string param)
        {
            return @"select * from person where " + searchBy + " like   "+ param ;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if(searchByFirstNameRadio.Checked)
            {
                

                
                SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
                string selectPersonByFirstNameCmdString = selectCommandString("first_name", "'%' + @firstName + '%'");
                SqlCommand selectPersonSqlCommand = new SqlCommand(selectPersonByFirstNameCmdString, sqlConnection);
                selectPersonSqlCommand.Parameters.AddWithValue("@firstName",GlobalConstants.firstLetterCapital(txtFirstName.Text));

                try
                {

                    
                    sqlConnection.Open();
                    SqlDataReader reader = selectPersonSqlCommand.ExecuteReader(CommandBehavior.SingleRow);
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
                        MessageBox.Show("Nem található személy ezzel a névvel: " + txtFirstName.Text,"Nem található személy!",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                
                
                SqlConnection sqlConnection2 = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
                string selectPersonByLastNameCmdString = selectCommandString("last_name", "'%' + @lastName + '%'");
                MessageBox.Show(selectPersonByLastNameCmdString);
                SqlCommand selectSqlCommand = new SqlCommand(selectPersonByLastNameCmdString, sqlConnection2);
                //selectSqlCommand.Parameters.Clear();
                selectSqlCommand.Parameters.AddWithValue("@lastName",GlobalConstants.firstLetterCapital(txtLastName.Text));
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
                        MessageBox.Show("Nem található személy ezzel a vezetéknévvel: " + txtLastName.Text, "Nem található személy",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                SqlConnection sqlConnection3 = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
                string selectPersonByEmailCmdString = selectCommandString("email", "'%' + @email + '%'");
                
                SqlCommand selectSqlCommand = new SqlCommand(selectPersonByEmailCmdString, sqlConnection3);
                //selectSqlCommand.Parameters.Clear();
                selectSqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
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
                        MessageBox.Show("Nem található személy ezzel az email címmel: " + txtEmail.Text, "Nem található személy", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    
                    SqlConnection sqlConnection4 = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
                    string selectPersonByMobileNumberCmdString = selectCommandString("phone_mobile", "'%' + @mobile + '%'");
                  
                    SqlCommand selectSqlCommand = new SqlCommand(selectPersonByMobileNumberCmdString, sqlConnection4);
                  
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
                            MessageBox.Show("Nem található személy ezzel a mobil számmal: " + txtPhoneMobile.Text, "Nem található személy", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    
                    SqlConnection sqlConnection5 = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
                    string selectPersonByFixPhoneNumberCmdString = selectCommandString("phone_fix", "'%' + @fix + '%'");
                   
                    SqlCommand selectSqlCommand = new SqlCommand(selectPersonByFixPhoneNumberCmdString, sqlConnection5);
                   
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
                            MessageBox.Show("Nem található személy ezzel a telefon számmal: " + txtPhonFix.Text, "Nem található személy", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string createNewPerson = GlobalConstants.INSERT_PERSON_STRING + " (@firstName, @lastName, @address, @email, @joinDate, @phoneFix, @phoneMobile)";
            
            SqlCommand createNewSqlCommand = new SqlCommand(createNewPerson, sqlConnection);
            //selectSqlCommand.Parameters.Clear();
            createNewSqlCommand.Parameters.AddWithValue("@firstName",GlobalConstants. firstLetterCapital(txtFirstName.Text));
            createNewSqlCommand.Parameters.AddWithValue("@lastName",GlobalConstants. firstLetterCapital(txtLastName.Text));
            createNewSqlCommand.Parameters.AddWithValue("@address",GlobalConstants. firstLetterCapital(txtAddress.Text));
            createNewSqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            createNewSqlCommand.Parameters.AddWithValue("@joinDate", DateTime.Now);
            createNewSqlCommand.Parameters.AddWithValue("@phoneFix", txtPhonFix.Text);
            createNewSqlCommand.Parameters.AddWithValue("@phoneMobile", txtPhoneMobile.Text);

            if (txtPhoneMobile.Text.Length > 13 && txtPhonFix.Text.Length > 13 && txtPhoneMobile.Text.Contains(@"^\\\\d{12}$") && txtPhonFix.Text.Contains(@"^\\\\d{12}$"))
            {
                MessageBox.Show("Max 12 karakter!!!");
            }
            else
            {
                try
                {


                    sqlConnection.Open();
                    int result = createNewSqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sikeres bevitel", "Siker", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Sikertelen bevitel ","Hiba", MessageBoxButtons.OK,MessageBoxIcon.Error );
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
            String connString = GlobalConstants.DATA_CONNECTION_STRING;
            SqlConnection sqlConnection = new SqlConnection(connString);
            string updatePerson = "update person set first_name = @firstName , last_name = @lastName, address_line = @address, email = @email, phone_fix = @phoneFix, phone_mobile = @phoneMobile where id = @id";

            SqlCommand updateSqlCommand = new SqlCommand(updatePerson, sqlConnection);
            
            updateSqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(txtPersonId.Text));
            updateSqlCommand.Parameters.AddWithValue("@firstName",GlobalConstants. firstLetterCapital(txtFirstName.Text));
            updateSqlCommand.Parameters.AddWithValue("@lastName",GlobalConstants. firstLetterCapital(txtLastName.Text));
            updateSqlCommand.Parameters.AddWithValue("@address",GlobalConstants. firstLetterCapital(txtAddress.Text));
            updateSqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            updateSqlCommand.Parameters.AddWithValue("@phoneFix", txtPhonFix.Text);
            updateSqlCommand.Parameters.AddWithValue("@phoneMobile", txtPhoneMobile.Text);

            if (txtPhoneMobile.Text.Length > 13 && txtPhonFix.Text.Length > 13 && txtPhoneMobile.Text.Contains(@"^\\\\d{12}$") && txtPhonFix.Text.Contains(@"^\\\\d{12}$"))
            {
                MessageBox.Show("Max 12 karakter!!!");
            }
            else
            {
                try
                {


                    sqlConnection.Open();
                    int result = updateSqlCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Sikeres frissítés", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Sikertelen frissítés ", "Nem sikerült", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
