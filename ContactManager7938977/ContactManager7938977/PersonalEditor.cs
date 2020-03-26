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
            tb_Fname.Text = dgv_PersonalRecords.SelectedCells[1].Value.ToString();
            tb_Lname.Text = dgv_PersonalRecords.SelectedCells[2].Value.ToString(); 
            tb_Tel.Text = dgv_PersonalRecords.SelectedCells[3].Value.ToString();
            tb_HomeTel.Text = dgv_PersonalRecords.SelectedCells[4].Value.ToString();
            tb_Email.Text = dgv_PersonalRecords.SelectedCells[5].Value.ToString();
            tb_Addr1.Text = dgv_PersonalRecords.SelectedCells[6].Value.ToString();
            tb_Addr2.Text = dgv_PersonalRecords.SelectedCells[7].Value.ToString();
            tb_City.Text = dgv_PersonalRecords.SelectedCells[8].Value.ToString();
            tb_Postcode.Text = dgv_PersonalRecords.SelectedCells[9].Value.ToString();
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

        //Refresh
        private void btn_Refresh_Click(object sender, EventArgs e) => RefreshRecords();

        //data grid view
        private void dgv_PersonalRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        ///// EVENTS END ////////////////////////////////////////////////////////////
    }
}
