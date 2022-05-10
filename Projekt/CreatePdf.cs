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

        string tvId;
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
                 
                sda2.SelectCommand.Parameters.AddWithValue("@personId", Convert.ToInt32(comboPersonId.SelectedIndex + 1));
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                dataGridView1.DataSource = dt;


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
            createPdfBtn.Enabled = false;
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            SqlConnection sqlConnection = new SqlConnection(GlobalConstants.DATA_CONNECTION_STRING);
            try
            {
                DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];
                
                string sqlFillTextBoxes = "SELECT person.first_name, person.last_name, person.email, person.address_line, person.phone_fix, person.phone_mobile, tv_category.category_name, tv.date_of_correction, tv.error_seen_by_customer, tv.repaired_error, tv.reserved_date_to_repair, tv.has_any_missing_parts, tv.missing_parts, tv.price FROM customer INNER JOIN person ON customer.customer_person_id = person.id INNER JOIN tv ON customer.customers_tv_id = tv.id AND person.id = tv.person_id INNER JOIN tv_category ON tv.tv_category_id = tv_category.id where person.id = @personId and tv.id = @tvId; ";
                SqlCommand selectSqlCommand = new SqlCommand(sqlFillTextBoxes, sqlConnection);

                selectSqlCommand.Parameters.AddWithValue("@personId", Convert.ToInt32(comboPersonId.SelectedIndex + 1));

                selectSqlCommand.Parameters.AddWithValue("@tvId", Convert.ToInt32(rows.Cells[0].Value));
                tvId = Convert.ToInt32(rows.Cells[0].Value).ToString();
                sqlConnection.Open();
                SqlDataReader reader = selectSqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtFirstName.Text = reader["first_name"].ToString();
                    txtLastName.Text = reader["last_name"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtAddress.Text = reader["address_line"].ToString();
                    txtPhoneFix.Text = reader["phone_fix"].ToString();
                    txtPhoneMobile.Text = reader["phone_mobile"].ToString();


                    txtTvCategory.Text = reader["category_name"].ToString();
                    txtDateOfReceipt.Text = reader["reserved_date_to_repair"].ToString();
                    txtErrorSeenByCustomer.Text = reader["error_seen_by_customer"].ToString();
                    if(reader["has_any_missing_parts"].ToString().Equals("1"))
                    {
                        txtHasAnyMissingPart.Text = "Igen";
                    }
                    else
                    {
                        txtHasAnyMissingPart.Text = "Nincs";
                    }
                    txtMissingParts.Text = reader["missing_parts"].ToString();
                    txtDateOfCorrection.Text = reader["date_of_correction"].ToString();
                    txtCorrectedError.Text = reader["repaired_error"].ToString();
                    txtPriceOfCorrection.Text = reader["price"].ToString();
                    

                }

                else
                {

                }
            }
            catch(System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Csak a számokat tartalmazó mezőre kattintson", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Olyan mezőt válasszon, amiben van érték!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            createPdfBtn.Enabled = true;
            
        }

        private void createPdfBtn_Click(object sender, EventArgs e)
        {
            Document doc = new Document(iTextSharp.text.PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(GlobalConstants.DEFAULT_FILE_OUTPUT_DIRECTORY + txtFirstName.Text + "_" + DateTime.Now.Day.ToString() + "_" + tvId +  ".pdf", FileMode.Create));
            
            doc.Open();
            doc.AddAuthor("Süge Ákos"); 
            doc.AddCreator("PG Elektron - Adminisztrációs alkalmazás");
            doc.AddSubject("Számla amivel az ügyfél átveheti a TV-t");
            iTextSharp.text.Image png = iTextSharp.text.Image.GetInstance(@"C:\Users\sugea\Desktop\VTS 3 - 2\SoftwareEngineering\Projekt\logo.png");
            png.ScalePercent(33);
            png.SetAbsolutePosition(-50, 640);
            doc.Add(png);
            
            Paragraph creationTime = new Paragraph(DateTime.Now.ToString());
            creationTime.Alignment = Element.ALIGN_RIGHT;
            doc.Add(creationTime);

            Paragraph topText1 = new Paragraph(GlobalConstants.EMAIL);
            topText1.Alignment = Element.ALIGN_CENTER;
            topText1.SpacingBefore = -20;
            doc.Add(topText1);

            Paragraph topText2 = new Paragraph(GlobalConstants.PHONE);
            topText2.Alignment = Element.ALIGN_CENTER;
            
            doc.Add(topText2);

            Paragraph splitter = new Paragraph("=============================================================================");
            splitter.SpacingBefore = 100;
            doc.Add(splitter);

            Paragraph parag = new Paragraph("Az ügyfél adatai:");
            parag.SpacingBefore = 10;
            parag.SpacingAfter = 30;
            doc.Add(parag);

            Paragraph lastName = new Paragraph(txtLastName.Text + " " + txtFirstName.Text);
            lastName.Alignment = Element.ALIGN_LEFT;
            doc.Add(lastName);

            Paragraph email = new Paragraph(txtEmail.Text);
            email.SpacingBefore = -17;
            email.Alignment = Element.ALIGN_CENTER;
            doc.Add(email);

            Paragraph address = new Paragraph(txtAddress.Text);
            address.SpacingBefore = -17;
            address.Alignment = Element.ALIGN_RIGHT;
            doc.Add(address);

            Paragraph phoneFix = new Paragraph("Vonalas telefonszám: \t" +  txtPhoneFix.Text);
            phoneFix.SpacingBefore = 10;
            phoneFix.Alignment = Element.ALIGN_LEFT;
            doc.Add(phoneFix);

            Paragraph phoneMobile = new Paragraph("Mobil telefonszám: \t" + txtPhoneMobile.Text);
            phoneMobile.SpacingBefore = 10;
            phoneMobile.Alignment = Element.ALIGN_LEFT;
            doc.Add(phoneMobile);

            Paragraph splitter2 = new Paragraph("=============================================================================");
            splitter2.SpacingBefore = 10;
            splitter2.SpacingAfter = 10;
            doc.Add(splitter2);

            Paragraph tvAdatai = new Paragraph("A TV adatai:");
            tvAdatai.SpacingBefore = 10;
            tvAdatai.SpacingAfter = 30;
            doc.Add(tvAdatai);

            Paragraph tvCategory = new Paragraph("Márka: "+ "\t" + txtTvCategory.Text);
            tvCategory.Alignment = Element.ALIGN_LEFT;
            tvCategory.SpacingAfter = 20;
            doc.Add(tvCategory);

            Paragraph receiptTime = new Paragraph("Átvétel időpontja: " + "\t" + txtDateOfReceipt.Text);
            receiptTime.Alignment = Element.ALIGN_LEFT;
            doc.Add(receiptTime);

            Paragraph errorByCustomer = new Paragraph("Ügyfél által észlelt hiba: " + "\t" + txtErrorSeenByCustomer.Text);
            errorByCustomer.Alignment = Element.ALIGN_MIDDLE;
            errorByCustomer.SpacingAfter = 20;
            doc.Add(errorByCustomer);

            Paragraph dateOfCorrection = new Paragraph("Javítás időpontja: " + "\t" + txtDateOfCorrection.Text);
            dateOfCorrection.Alignment = Element.ALIGN_LEFT;
            doc.Add(dateOfCorrection);

            Paragraph correctedError = new Paragraph("Javított hiba: " + "\t" + txtCorrectedError.Text);
            correctedError.Alignment = Element.ALIGN_MIDDLE;
            correctedError.SpacingAfter = 20;
            doc.Add(correctedError);

            Paragraph hasAnyMissingPart = new Paragraph("Van hiányzó elem az átvétel pillanatában: " + "\t" + txtHasAnyMissingPart.Text);
            hasAnyMissingPart.Alignment = Element.ALIGN_LEFT;
            hasAnyMissingPart.SpacingAfter = 20;
            doc.Add(hasAnyMissingPart);

            Paragraph missingParts = new Paragraph("Hiányzó elem(ek) az átvétel pillanatában: " + "\t" + txtMissingParts.Text);
            missingParts.Alignment = Element.ALIGN_LEFT;
            missingParts.SpacingAfter = 20;
            doc.Add(missingParts);

            Paragraph price = new Paragraph("Javítás ára: " + "\t" + txtPriceOfCorrection.Text + " (din)");
            price.Alignment = Element.ALIGN_LEFT;
            price.SpacingAfter = 20;
            doc.Add(price);

            Paragraph splitter3 = new Paragraph("=============================================================================");
            splitter3.SpacingBefore = 10;
            splitter3.SpacingAfter = 10;
            doc.Add(splitter3);

            doc.Close();
        }
    }
}
