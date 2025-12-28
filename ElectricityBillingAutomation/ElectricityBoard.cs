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

        public void AddBill(ElectricityBill ebill)
        {
            DBHandler dbHandler = new DBHandler();

            using (SqlConnection connection = dbHandler.GetConnection())
            {
                string insertQuery =
                    "INSERT INTO ElectricityBill " +
                    "(consumer_number, consumer_name, units_consumed, bill_amount) " +
                    "VALUES (@consumerNumber, @consumerName, @unitsConsumed, @billAmount)";

                SqlCommand command = new SqlCommand(insertQuery, connection);

                command.Parameters.AddWithValue("@consumerNumber", ebill.ConsumerNumber);
                command.Parameters.AddWithValue("@consumerName", ebill.ConsumerName);
                command.Parameters.AddWithValue("@unitsConsumed", ebill.UnitsConsumed);
                command.Parameters.AddWithValue("@billAmount", ebill.BillAmount);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public List<ElectricityBill> Generate_N_BillDetails(int num)
        {
            List<ElectricityBill> billList = new List<ElectricityBill>();
            DBHandler dbHandler = new DBHandler();

            using (SqlConnection connection = dbHandler.GetConnection())
            {
                string selectQuery =
                    "SELECT TOP (@count) consumer_number, consumer_name, units_consumed, bill_amount " +
                    "FROM ElectricityBill ORDER BY consumer_number DESC";

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


    }
}
