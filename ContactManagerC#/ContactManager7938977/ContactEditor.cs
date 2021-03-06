﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager7938977
{
    public partial class ContactEditor : Form
    {
        //Database connection
        DbConn dbConn = new DbConn();

        public string formView = "Personal";
        public int contactId = 0;

        ///// METHODS START ////////////////////////////////////////////////////////
        //Changes the form view between personal and business
        public void ChangeFormView()
        {
            TextboxEnabled(false);
            btn_ChangeContact.Text = formView + " Contact"; //changes the text of the buttom
            switch(formView)//changes form view so the app knows which type of class to use
            {
                case "Personal":
                    formView = "Business";
                    lbl_OtherTel.Text = "Work Telephone";
                    break;
                case "Business":
                    formView = "Personal";
                    lbl_OtherTel.Text = "Home Telephone";
                    break;
            }
            Text = "Harris Contact Manager - " + formView; //changes the form header to the current view
            RefreshRecords();
        }
        //shortens the code to get data grid view data
        public string DataGrid (int column)
        {
            return dgv_ContactRecords.SelectedCells[column].Value.ToString();
        } 
        //refreshes the data in the grid view depending on the view
        public void RefreshRecords()
        {
            switch(formView)
            {
                case "Personal":
                    dgv_ContactRecords.DataSource = dbConn.GetAllPersonal();
                    break;
                case "Business":
                    dgv_ContactRecords.DataSource = dbConn.GetAllBusiness();
                    break;
            }
        }
        //sets all the text boxes to be enabled or disabled all at once
        public void TextboxEnabled(bool enabled)
        {
            tb_Fname.Enabled = tb_Lname.Enabled = tb_Tel.Enabled = tb_HomeTel.Enabled = tb_Email.Enabled =
                tb_Addr1.Enabled = tb_Addr2.Enabled = tb_City.Enabled = tb_Postcode.Enabled = enabled;

            btn_SaveSelected.Enabled = btn_SaveNew.Enabled = false;
            tb_Fname.Text = tb_Lname.Text = tb_Tel.Text = tb_HomeTel.Text = tb_Email.Text =
                tb_Addr1.Text = tb_Addr2.Text = tb_City.Text = tb_Postcode.Text = String.Empty; //empties the textboxes for new text or for adding record
        }
        //sets all the textboxes text to the selected index and gets the id
        public void SetTextboxText ()
        {
            contactId = Int32.Parse(dgv_ContactRecords.SelectedCells[0].Value.ToString());
            tb_Fname.Text = DataGrid(1);
            tb_Lname.Text = DataGrid(2);
            tb_Tel.Text = DataGrid(3);
            tb_HomeTel.Text = DataGrid(4);
            tb_Email.Text = DataGrid(5);
            tb_Addr1.Text = DataGrid(6);
            tb_Addr2.Text = DataGrid(7);
            tb_City.Text = DataGrid(8);
            tb_Postcode.Text = DataGrid(9);
        }
        //Creates a Personal Contact Object with the current form text
        public PersonalContact CreatePersonalContactFromForm()
        {
            PersonalContact contact = new PersonalContact()
            {
                ContactID = contactId,
                ContactFname = tb_Fname.Text,
                ContactLname = tb_Lname.Text,
                ContactTel = tb_Tel.Text,
                PersonalTel = tb_HomeTel.Text,
                ContactEmail = tb_Email.Text,
                ContactAddr1 = tb_Addr1.Text,
                ContactAddr2 = tb_Addr2.Text,
                ContactCity = tb_City.Text,
                ContactPostcode = tb_Postcode.Text
            };
            return contact;
        }
        //Creates a Business Contact Object with the current form text
        public BusinessContact CreateBusinessContactFromForm()
        {
            BusinessContact contact = new BusinessContact()
            {
                ContactID = contactId,
                ContactFname = tb_Fname.Text,
                ContactLname = tb_Lname.Text,
                ContactTel = tb_Tel.Text,
                BusinessTel = tb_HomeTel.Text,
                ContactEmail = tb_Email.Text,
                ContactAddr1 = tb_Addr1.Text,
                ContactAddr2 = tb_Addr2.Text,
                ContactCity = tb_City.Text,
                ContactPostcode = tb_Postcode.Text
            };
            return contact;
        }
        ///// METHODS END //////////////////////////////////////////////////////////

        public ContactEditor()
        {
            InitializeComponent();
        }

        ///// EVENTS START //////////////////////////////////////////////////////////
        //On Form load
        private void PersonalEditor_Load(object sender, EventArgs e) => RefreshRecords();

        //Buttons
        //Add new
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            TextboxEnabled(true);
            btn_SaveNew.Enabled = true;//enables the button to save record
        }

        private void btn_SaveNew_Click(object sender, EventArgs e)
        {
            switch (formView)//Calls the function to insert the record depending on view
            {
                case "Personal":
                    dbConn.InsertPersonal(CreatePersonalContactFromForm());
                    break;
                case "Business":
                    dbConn.InsertBusiness(CreateBusinessContactFromForm());
                    break;
            }
            RefreshRecords();
            TextboxEnabled(false);
        }

        //Update
        private void btn_UpdateSelected_Click(object sender, EventArgs e)
        {
            TextboxEnabled(true);
            SetTextboxText();
            btn_SaveSelected.Enabled = true;//enables the button to update 
        }
        private void btn_SaveSelected_Click(object sender, EventArgs e)
        {
            switch (formView)//Calls the function to Update record depending on view
            {
                case "Personal":
                    dbConn.UpdatePersonal(CreatePersonalContactFromForm());
                    break;
                case "Business":
                    dbConn.UpdateBusiness(CreateBusinessContactFromForm());
                    break;
            }

            RefreshRecords();
            TextboxEnabled(false);
        }

        //delete
        private void btn_DeleteSelected_Click(object sender, EventArgs e)
        {
            string contactName = DataGrid(1)+" "+ DataGrid(2);//get full name of selected record
            string message = "Are you sure you want to delete?";// set the text of the message box
            string caption = "Do you want to delete the contact " + contactName + "?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(caption, message, buttons);  //creates a Message Box object
            if (result == DialogResult.Yes)
            {
                switch(formView)//Calls the function to Delete record depending on view
                {
                    case "Personal":
                        dbConn.DeletePersonal(Int32.Parse(DataGrid(0)));
                        break;
                    case "Business":
                        dbConn.DeleteBusiness(Int32.Parse(DataGrid(0)));
                        break;
                }

                RefreshRecords();
            }

        }


        //Refresh
        private void btn_Refresh_Click(object sender, EventArgs e) => RefreshRecords();

        //data grid view
        private void dgv_PersonalRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Change the contact view
        private void btn_ChangeContact_Click(object sender, EventArgs e) => ChangeFormView();




        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
