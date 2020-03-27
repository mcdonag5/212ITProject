using System;
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
    public partial class PersonalEditor : Form
    {
        //Database connection
        DbConn dbConn = new DbConn();

        public int contactId = 0;

        ///// METHODS START ////////////////////////////////////////////////////////
        public string DataGrid (int column)
        {
            return dgv_PersonalRecords.SelectedCells[column].Value.ToString();
        } 
        public void RefreshRecords()
        {
            dgv_PersonalRecords.DataSource = dbConn.GetAllPersonal();
        }
        
        public void TextboxEnabled(bool enabled)
        {
            tb_Fname.Enabled = tb_Lname.Enabled = tb_Tel.Enabled = tb_HomeTel.Enabled = tb_Email.Enabled =
                tb_Addr1.Enabled = tb_Addr2.Enabled = tb_City.Enabled = tb_Postcode.Enabled = enabled;

            btn_SaveSelected.Enabled = btn_SaveNew.Enabled = false;
            tb_Fname.Text = tb_Lname.Text = tb_Tel.Text = tb_HomeTel.Text = tb_Email.Text =
                tb_Addr1.Text = tb_Addr2.Text = tb_City.Text = tb_Postcode.Text = String.Empty;
        }

        public void SetTextboxText ()
        {
            contactId = Int32.Parse(dgv_PersonalRecords.SelectedCells[0].Value.ToString());
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

        public PersonalContact CreatePersonalContactFromForm()
        {
            PersonalContact personalContact = new PersonalContact()
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
            return personalContact;
        }
        ///// METHODS END //////////////////////////////////////////////////////////
        
        public PersonalEditor()
        {
            InitializeComponent();
        }

        ///// EVENTS START //////////////////////////////////////////////////////////
        //On Form load
        private void PersonalEditor_Load(object sender, EventArgs e)
        {
            RefreshRecords();
        }

        //Buttons
        //Add new
        private void btn_AddNew_Click(object sender, EventArgs e)
        {
            TextboxEnabled(true);
            btn_SaveNew.Enabled = true;

        }

        private void btn_SaveNew_Click(object sender, EventArgs e)
        {
            dbConn.InsertPersonal(CreatePersonalContactFromForm());
            RefreshRecords();
            TextboxEnabled(false);
        }

        //Update
        private void btn_UpdateSelected_Click(object sender, EventArgs e)
        {
            TextboxEnabled(true);
            SetTextboxText();
            btn_SaveSelected.Enabled = true;
        }
        private void btn_SaveSelected_Click(object sender, EventArgs e)
        {
            dbConn.UpdatePersonal(CreatePersonalContactFromForm());
            RefreshRecords();
            TextboxEnabled(false);
        }

        //delete
        private void btn_DeleteSelected_Click(object sender, EventArgs e)
        {
            string contactName = DataGrid(2)+" "+ DataGrid(3);
            string message = "Are you sure you want to delete?";
            string caption = "Do you want to delete the contact " + contactName + "?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(caption, message, buttons);
            if(result == DialogResult.Yes)
            {
                dbConn.DeletePersonal(Int32.Parse(DataGrid(0)));

                RefreshRecords();
            }

        }


        //Refresh
        private void btn_Refresh_Click(object sender, EventArgs e) => RefreshRecords();

        //data grid view
        private void dgv_PersonalRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
