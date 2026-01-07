using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ElectricityBillingAutomation
{
    public class ElectricityBoard
    {
        public void CalculateBill(ElectricityBill ebill)
        {
            int units = ebill.UnitsConsumed;
            double totalAmount = 0;

            if (units <= 100)
            {
                totalAmount = 0;
            }
            else if (units <= 300)
            {
                totalAmount =
                    (100 * 0) +
                    ((units - 100) * 1.5);
            }
            else if (units <= 600)
            {
                totalAmount =
                    (100 * 0) +
                    (200 * 1.5) +
                    ((units - 300) * 3.5);
            }
            else if (units <= 1000)
            {
                totalAmount =
                    (100 * 0) +
                    (200 * 1.5) +
                    (300 * 3.5) +
                    ((units - 600) * 5.5);
            }
            else
            {
                totalAmount =
                    (100 * 0) +
                    (200 * 1.5) +
                    (300 * 3.5) +
                    (400 * 5.5) +
                    ((units - 1000) * 7.5);
            }

            ebill.BillAmount = totalAmount;
        }

        public void AddBill(ElectricityBill bill)
        {
            DBHandler db = new DBHandler();

            using (SqlConnection con = db.GetConnection())
            {
                con.Open();

                if (!IsConsumerNameValid(con, bill.ConsumerNumber, bill.ConsumerName))
                {
                    throw new Exception("Consumer number already exists with a different name.");
                }

                if (IsDuplicateBill(con, bill.ConsumerNumber, bill.BillMonth, bill.BillYear))
                {
                    throw new Exception("Bill for this consumer already exists for the selected month and year.");
                }

                string query = @"INSERT INTO ElectricityBill
                         (consumer_number, consumer_name, units_consumed, bill_amount, BillMonth, BillYear)
                         VALUES (@cno, @cname, @units, @amount, @month, @year)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cno", bill.ConsumerNumber);
                cmd.Parameters.AddWithValue("@cname", bill.ConsumerName);
                cmd.Parameters.AddWithValue("@units", bill.UnitsConsumed);
                cmd.Parameters.AddWithValue("@amount", bill.BillAmount);
                cmd.Parameters.AddWithValue("@month", bill.BillMonth);
                cmd.Parameters.AddWithValue("@year", bill.BillYear);

                cmd.ExecuteNonQuery();
            }
        }

        public List<ElectricityBill> GetBillsByConsumerAndYear(string consumerNumber, int year)
        {
            List<ElectricityBill> bills = new List<ElectricityBill>();
            DBHandler db = new DBHandler();

            using (SqlConnection con = db.GetConnection())
            {
                string query = @"SELECT * FROM ElectricityBill
                         WHERE consumer_number = @cno AND BillYear = @year";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cno", consumerNumber);
                cmd.Parameters.AddWithValue("@year", year);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ElectricityBill bill = new ElectricityBill();
                    bill.ConsumerNumber = reader["consumer_number"].ToString();
                    bill.ConsumerName = reader["consumer_name"].ToString();
                    bill.UnitsConsumed = Convert.ToInt32(reader["units_consumed"]);
                    bill.BillAmount = Convert.ToDouble(reader["bill_amount"]);
                    bill.BillMonth = reader["BillMonth"].ToString();
                    bill.BillYear = Convert.ToInt32(reader["BillYear"]);

                    bills.Add(bill);
                }
            }
            return bills;
        }



        public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            List<ElectricityBill> billList = new List<ElectricityBill>();
            DBHandler dbHandler = new DBHandler();

            using (SqlConnection connection = dbHandler.GetConnection())
            {
                string selectQuery =
                    "SELECT TOP (@count) consumer_number, consumer_name, units_consumed, bill_amount\r\n " +
                    "FROM ElectricityBill\r\n" +
                    "ORDER BY consumer_number DESC\r\n";

                SqlCommand command = new SqlCommand(selectQuery, connection);
                command.Parameters.AddWithValue("@count", num);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ElectricityBill bill = new ElectricityBill
                    {
                        ConsumerNumber = reader["consumer_number"].ToString(),
                        ConsumerName = reader["consumer_name"].ToString(),
                        UnitsConsumed = Convert.ToInt32(reader["units_consumed"]),
                        BillAmount = Convert.ToDouble(reader["bill_amount"])
                    };

                    billList.Add(bill);
                }

                reader.Close();
                connection.Close();
            }

            return billList;
        }

        private bool IsConsumerNameValid(SqlConnection connection, string consumerNumber, string consumerName)
        {
            string query = "SELECT consumer_name FROM ElectricityBill WHERE consumer_number = @cno";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cno", consumerNumber);

            object result = cmd.ExecuteScalar();

            if (result == null)
                return true;

            return result.ToString().Equals(consumerName, StringComparison.OrdinalIgnoreCase);
        }

        private bool IsDuplicateBill(SqlConnection connection, string consumerNumber, string month, int year)
        {
            string query = @"SELECT COUNT(*) FROM ElectricityBill 
                     WHERE consumer_number = @cno AND BillMonth = @month AND BillYear = @year";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@cno", consumerNumber);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@year", year);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }




    }
}
