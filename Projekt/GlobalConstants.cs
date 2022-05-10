using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projekt
{
    class GlobalConstants
    {
        public const string DATA_CONNECTION_STRING = @"Data Source=AKOS-PC;Initial Catalog=PG_Elektron;Integrated Security=True";
        public const string INSERT_PERSON_STRING = "insert into person (first_name, last_name, address_line, email, join_date, phone_fix, phone_mobile) values";
        public const string SELECT_EVERYTHING_FRON_TV_STRING= "select * from tv where id =";
        public const string INSERT_TO_CUSTOMER_STRING = "insert into customer (customer_person_id, customers_tv_id) values";
        public const string INSERT_TO_TV_STRING = "insert into tv (person_id, tv_category_id, error_seen_by_customer, is_it_still_in_progress, reserved_date_to_repair, has_any_missing_parts, missing_parts) values ";
        public const string SELECT_FROM_TV_CATEGORY_STRING = "select id, category_name from tv_category";

        public static string firstLetterCapital(string str)
        {
            string returnStr = "";
            try
            {
                returnStr = Char.ToUpper(str[0]) + str.Remove(0, 1);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Futtasd az adatbázist", "Nem található adatbázis", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return returnStr;


        }
    }
}
