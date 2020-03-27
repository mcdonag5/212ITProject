using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager7938977
{
    public class DbConn
    {
        //Database Credentials//
        private string conString = "Server=db212it.czz7ucpwdopn.us-east-1.rds.amazonaws.com;User ID=admin;Password=mastersword;Database=HarrisContactDb";


        //Personal Contacts//
        //Selects all personal contacts from the database
        public DataTable GetAllPersonal()
        {
            using (var conn = new MySqlConnection(conString))
            {
                conn.Open();//opens the connection to the database
                DataTable PersonalContactDt = new DataTable(); //creates a datatable to store the contacts in
                List<PersonalContact> personalContacts = new List<PersonalContact>(); //creates a list
                using (var cmd = new MySqlCommand("CALL SelectAllPersonal();", conn)) //uses the stored procedure in the database to get all personal contacts
                    using (var reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            personalContacts.Add(new PersonalContact{//creates a personal contact object and adds it to the list
                                   ContactID = reader.GetInt32(0),//number is column of the table
                                   ContactFname = reader.GetString(1),
                                   ContactLname = reader.GetString(2),
                                   ContactTel = reader.GetString(3),
                                   PersonalTel = reader.GetString(4),
                                   ContactEmail = reader.GetString(5),
                                   ContactAddr1 = reader.GetString(6),
                                   ContactAddr2 = reader.GetString(7),
                                   ContactCity = reader.GetString(8),
                                   ContactPostcode = reader.GetString(9)
                            });
                        }
                //Sets the colum names so they are user friendly
                PersonalContactDt.Columns.Add("ID");
                PersonalContactDt.Columns.Add("First Name");
                PersonalContactDt.Columns.Add("Last Name");
                PersonalContactDt.Columns.Add("Telephone");
                PersonalContactDt.Columns.Add("Home Telephone");
                PersonalContactDt.Columns.Add("Email");
                PersonalContactDt.Columns.Add("Address Line 1");
                PersonalContactDt.Columns.Add("Address Line 2");
                PersonalContactDt.Columns.Add("City");
                PersonalContactDt.Columns.Add("Postcode");

                foreach(var item in personalContacts)//for each personal contact the data is added the right column
                {
                    var row = PersonalContactDt.NewRow(); //shortens the code to save space and make it more readable

                    row["ID"] = item.ContactID;
                    row["First Name"] = item.ContactFname;
                    row["Last Name"] = item.ContactLname;
                    row["Telephone"] = item.ContactTel;
                    row["Home Telephone"] = item.PersonalTel;
                    row["Email"] = item.ContactEmail;
                    row["Address Line 1"] = item.ContactAddr1;
                    row["Address Line 2"] = item.ContactAddr2;
                    row["City"] = item.ContactCity;
                    row["Postcode"] = item.ContactPostcode;

                    PersonalContactDt.Rows.Add(row); //adds the row to the datatable
                }
                return PersonalContactDt; //returns the full list of personal contacts from the table 
            }
        }

        //Insert a personal contact to the database
        public async void InsertPersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();//opens the connection to the database
                using (var cmd = new MySqlCommand())
                {//created a command to execute
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL InsertPersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";//Calling the insert and setting the parameters locations
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactFname); //setting the values of the parameters
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactTel);
                    cmd.Parameters.AddWithValue("p4", personalContact.PersonalTel);
                    cmd.Parameters.AddWithValue("p5", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync(); //executing the command after creating it
                }
            }
        }

        //Updates personal contact in the database
        public async void UpdatePersonal(PersonalContact personalContact)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();//opens the connection to the database
                using (var cmd = new MySqlCommand())
                {//created a command to execute
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL UpdatePersonal(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";//Calling the insert and setting the parameters locations
                    cmd.Parameters.AddWithValue("p1", personalContact.ContactID); //id of the contact to know which one to change
                    cmd.Parameters.AddWithValue("p2", personalContact.ContactFname);//setting the values of the parameters
                    cmd.Parameters.AddWithValue("p3", personalContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", personalContact.ContactTel);
                    cmd.Parameters.AddWithValue("p5", personalContact.PersonalTel);
                    cmd.Parameters.AddWithValue("p6", personalContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p7", personalContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p8", personalContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p9", personalContact.ContactCity);
                    cmd.Parameters.AddWithValue("p10", personalContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();//executing the command after creating it
                }
            }
        }

        //Deletes a personal contact in the database
        public async void DeletePersonal(int id)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();//opens the connection to the database
                using (var cmd = new MySqlCommand())
                {//created a command to execute
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL DeletePersonal(@p1)";//Calling the insert and setting the parameters location
                    cmd.Parameters.AddWithValue("p1", id);//id of the contact to delete
                    await cmd.ExecuteNonQueryAsync();//executing the command after creating it
                }
            }
        }


        //Business Contacts//
        //Selects all business contacts from the database
        public DataTable GetAllBusiness()
        {
            using (var conn = new MySqlConnection(conString))
            {
                conn.Open();
                DataTable BusinessContactDt = new DataTable();
                List<BusinessContact> businessContacts = new List<BusinessContact>();
                using (var cmd = new MySqlCommand("CALL SelectAllBusiness();", conn))
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        businessContacts.Add(new BusinessContact
                        {
                            ContactID = reader.GetInt32(0),
                            ContactFname = reader.GetString(1),
                            ContactLname = reader.GetString(2),
                            ContactTel = reader.GetString(3),
                            BusinessTel = reader.GetString(4),
                            ContactEmail = reader.GetString(5),
                            ContactAddr1 = reader.GetString(6),
                            ContactAddr2 = reader.GetString(7),
                            ContactCity = reader.GetString(8),
                            ContactPostcode = reader.GetString(9)
                        });
                    }
                BusinessContactDt.Columns.Add("ID");
                BusinessContactDt.Columns.Add("First Name");
                BusinessContactDt.Columns.Add("Last Name");
                BusinessContactDt.Columns.Add("Telephone");
                BusinessContactDt.Columns.Add("Work Telephone");
                BusinessContactDt.Columns.Add("Email");
                BusinessContactDt.Columns.Add("Address Line 1");
                BusinessContactDt.Columns.Add("Address Line 2");
                BusinessContactDt.Columns.Add("City");
                BusinessContactDt.Columns.Add("Postcode");

                foreach (var item in businessContacts)
                {
                    var row = BusinessContactDt.NewRow();

                    row["ID"] = item.ContactID;
                    row["First Name"] = item.ContactFname;
                    row["Last Name"] = item.ContactLname;
                    row["Telephone"] = item.ContactTel;
                    row["Work Telephone"] = item.BusinessTel;
                    row["Email"] = item.ContactEmail;
                    row["Address Line 1"] = item.ContactAddr1;
                    row["Address Line 2"] = item.ContactAddr2;
                    row["City"] = item.ContactCity;
                    row["Postcode"] = item.ContactPostcode;

                    BusinessContactDt.Rows.Add(row);
                }
                return BusinessContactDt;
            }
        }

        //Insert a business contact to the database
        public async void InsertBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL InsertBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactFname);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactLname);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactTel);
                    cmd.Parameters.AddWithValue("p4", businessContact.BusinessTel);
                    cmd.Parameters.AddWithValue("p5", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //Updates business contact in the database
        public async void UpdateBusiness(BusinessContact businessContact)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL UpdateBusiness(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
                    cmd.Parameters.AddWithValue("p1", businessContact.ContactID);
                    cmd.Parameters.AddWithValue("p2", businessContact.ContactFname);
                    cmd.Parameters.AddWithValue("p3", businessContact.ContactLname);
                    cmd.Parameters.AddWithValue("p4", businessContact.ContactTel);
                    cmd.Parameters.AddWithValue("p5", businessContact.BusinessTel);
                    cmd.Parameters.AddWithValue("p6", businessContact.ContactEmail);
                    cmd.Parameters.AddWithValue("p7", businessContact.ContactAddr1);
                    cmd.Parameters.AddWithValue("p8", businessContact.ContactAddr2);
                    cmd.Parameters.AddWithValue("p9", businessContact.ContactCity);
                    cmd.Parameters.AddWithValue("p10", businessContact.ContactPostcode);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        //Deletes a business contact in the database
        public async void DeleteBusiness(int id)
        {
            using (var conn = new MySqlConnection(conString))
            {
                await conn.OpenAsync();
                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CALL DeleteBusiness(@p1)";
                    cmd.Parameters.AddWithValue("p1", id);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
