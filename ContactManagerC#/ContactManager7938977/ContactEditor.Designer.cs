namespace ContactManager7938977
{
    partial class ContactEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_ContactRecords = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_AddNew = new System.Windows.Forms.Button();
            this.btn_SaveNew = new System.Windows.Forms.Button();
            this.btn_UpdateSelected = new System.Windows.Forms.Button();
            this.btn_DeleteSelected = new System.Windows.Forms.Button();
            this.btn_SaveSelected = new System.Windows.Forms.Button();
            this.tb_Fname = new System.Windows.Forms.TextBox();
            this.tb_Lname = new System.Windows.Forms.TextBox();
            this.tb_Tel = new System.Windows.Forms.TextBox();
            this.tb_HomeTel = new System.Windows.Forms.TextBox();
            this.tb_Postcode = new System.Windows.Forms.TextBox();
            this.tb_City = new System.Windows.Forms.TextBox();
            this.tb_Addr2 = new System.Windows.Forms.TextBox();
            this.tb_Addr1 = new System.Windows.Forms.TextBox();
            this.lbl_Fname = new System.Windows.Forms.Label();
            this.lbl_Lname = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lbl_OtherTel = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.lbl_Addr2 = new System.Windows.Forms.Label();
            this.lbl_Addr1 = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ChangeContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ContactRecords)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ContactRecords
            // 
            this.dgv_ContactRecords.AllowUserToResizeColumns = false;
            this.dgv_ContactRecords.AllowUserToResizeRows = false;
            this.dgv_ContactRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_ContactRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ContactRecords.Location = new System.Drawing.Point(12, 149);
            this.dgv_ContactRecords.Name = "dgv_ContactRecords";
            this.dgv_ContactRecords.ReadOnly = true;
            this.dgv_ContactRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ContactRecords.Size = new System.Drawing.Size(1102, 388);
            this.dgv_ContactRecords.TabIndex = 0;
            this.dgv_ContactRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PersonalRecords_CellClick);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Refresh.Location = new System.Drawing.Point(1039, 106);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_AddNew
            // 
            this.btn_AddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddNew.Location = new System.Drawing.Point(1039, 5);
            this.btn_AddNew.Name = "btn_AddNew";
            this.btn_AddNew.Size = new System.Drawing.Size(75, 23);
            this.btn_AddNew.TabIndex = 2;
            this.btn_AddNew.Text = "Add New";
            this.btn_AddNew.UseVisualStyleBackColor = true;
            this.btn_AddNew.Click += new System.EventHandler(this.btn_AddNew_Click);
            // 
            // btn_SaveNew
            // 
            this.btn_SaveNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveNew.Enabled = false;
            this.btn_SaveNew.Location = new System.Drawing.Point(1039, 34);
            this.btn_SaveNew.Name = "btn_SaveNew";
            this.btn_SaveNew.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveNew.TabIndex = 3;
            this.btn_SaveNew.Text = "Save New";
            this.btn_SaveNew.UseVisualStyleBackColor = true;
            this.btn_SaveNew.Click += new System.EventHandler(this.btn_SaveNew_Click);
            // 
            // btn_UpdateSelected
            // 
            this.btn_UpdateSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateSelected.Location = new System.Drawing.Point(934, 5);
            this.btn_UpdateSelected.Name = "btn_UpdateSelected";
            this.btn_UpdateSelected.Size = new System.Drawing.Size(99, 23);
            this.btn_UpdateSelected.TabIndex = 4;
            this.btn_UpdateSelected.Text = "Update Selected";
            this.btn_UpdateSelected.UseVisualStyleBackColor = true;
            this.btn_UpdateSelected.Click += new System.EventHandler(this.btn_UpdateSelected_Click);
            // 
            // btn_DeleteSelected
            // 
            this.btn_DeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteSelected.Location = new System.Drawing.Point(934, 61);
            this.btn_DeleteSelected.Name = "btn_DeleteSelected";
            this.btn_DeleteSelected.Size = new System.Drawing.Size(99, 23);
            this.btn_DeleteSelected.TabIndex = 5;
            this.btn_DeleteSelected.Text = "Delete Selected";
            this.btn_DeleteSelected.UseVisualStyleBackColor = true;
            this.btn_DeleteSelected.Click += new System.EventHandler(this.btn_DeleteSelected_Click);
            // 
            // btn_SaveSelected
            // 
            this.btn_SaveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveSelected.Enabled = false;
            this.btn_SaveSelected.Location = new System.Drawing.Point(934, 32);
            this.btn_SaveSelected.Name = "btn_SaveSelected";
            this.btn_SaveSelected.Size = new System.Drawing.Size(99, 23);
            this.btn_SaveSelected.TabIndex = 6;
            this.btn_SaveSelected.Text = "Save Selected";
            this.btn_SaveSelected.UseVisualStyleBackColor = true;
            this.btn_SaveSelected.Click += new System.EventHandler(this.btn_SaveSelected_Click);
            // 
            // tb_Fname
            // 
            this.tb_Fname.Enabled = false;
            this.tb_Fname.Location = new System.Drawing.Point(98, 3);
            this.tb_Fname.Name = "tb_Fname";
            this.tb_Fname.Size = new System.Drawing.Size(178, 20);
            this.tb_Fname.TabIndex = 7;
            // 
            // tb_Lname
            // 
            this.tb_Lname.Enabled = false;
            this.tb_Lname.Location = new System.Drawing.Point(98, 29);
            this.tb_Lname.Name = "tb_Lname";
            this.tb_Lname.Size = new System.Drawing.Size(178, 20);
            this.tb_Lname.TabIndex = 8;
            // 
            // tb_Tel
            // 
            this.tb_Tel.Enabled = false;
            this.tb_Tel.Location = new System.Drawing.Point(98, 55);
            this.tb_Tel.Name = "tb_Tel";
            this.tb_Tel.Size = new System.Drawing.Size(178, 20);
            this.tb_Tel.TabIndex = 9;
            // 
            // tb_HomeTel
            // 
            this.tb_HomeTel.Enabled = false;
            this.tb_HomeTel.Location = new System.Drawing.Point(98, 81);
            this.tb_HomeTel.Name = "tb_HomeTel";
            this.tb_HomeTel.Size = new System.Drawing.Size(178, 20);
            this.tb_HomeTel.TabIndex = 10;
            // 
            // tb_Postcode
            // 
            this.tb_Postcode.Enabled = false;
            this.tb_Postcode.Location = new System.Drawing.Point(365, 81);
            this.tb_Postcode.Name = "tb_Postcode";
            this.tb_Postcode.Size = new System.Drawing.Size(178, 20);
            this.tb_Postcode.TabIndex = 14;
            // 
            // tb_City
            // 
            this.tb_City.Enabled = false;
            this.tb_City.Location = new System.Drawing.Point(365, 55);
            this.tb_City.Name = "tb_City";
            this.tb_City.Size = new System.Drawing.Size(178, 20);
            this.tb_City.TabIndex = 13;
            // 
            // tb_Addr2
            // 
            this.tb_Addr2.Enabled = false;
            this.tb_Addr2.Location = new System.Drawing.Point(365, 29);
            this.tb_Addr2.Name = "tb_Addr2";
            this.tb_Addr2.Size = new System.Drawing.Size(178, 20);
            this.tb_Addr2.TabIndex = 12;
            // 
            // tb_Addr1
            // 
            this.tb_Addr1.Enabled = false;
            this.tb_Addr1.Location = new System.Drawing.Point(365, 3);
            this.tb_Addr1.Name = "tb_Addr1";
            this.tb_Addr1.Size = new System.Drawing.Size(178, 20);
            this.tb_Addr1.TabIndex = 11;
            // 
            // lbl_Fname
            // 
            this.lbl_Fname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Fname.AutoSize = true;
            this.lbl_Fname.Location = new System.Drawing.Point(3, 0);
            this.lbl_Fname.Name = "lbl_Fname";
            this.lbl_Fname.Size = new System.Drawing.Size(89, 26);
            this.lbl_Fname.TabIndex = 15;
            this.lbl_Fname.Text = "First Name";
            this.lbl_Fname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Lname
            // 
            this.lbl_Lname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Lname.AutoSize = true;
            this.lbl_Lname.Location = new System.Drawing.Point(3, 26);
            this.lbl_Lname.Name = "lbl_Lname";
            this.lbl_Lname.Size = new System.Drawing.Size(89, 26);
            this.lbl_Lname.TabIndex = 16;
            this.lbl_Lname.Text = "Last Name";
            this.lbl_Lname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Location = new System.Drawing.Point(3, 52);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(89, 26);
            this.lbl_Tel.TabIndex = 17;
            this.lbl_Tel.Text = "Telephone";
            this.lbl_Tel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_OtherTel
            // 
            this.lbl_OtherTel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_OtherTel.AutoSize = true;
            this.lbl_OtherTel.Location = new System.Drawing.Point(3, 78);
            this.lbl_OtherTel.Name = "lbl_OtherTel";
            this.lbl_OtherTel.Size = new System.Drawing.Size(89, 26);
            this.lbl_OtherTel.TabIndex = 18;
            this.lbl_OtherTel.Text = "Home Telephone";
            this.lbl_OtherTel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPostcode
            // 
            this.lblPostcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(282, 78);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(77, 26);
            this.lblPostcode.TabIndex = 22;
            this.lblPostcode.Text = "Postcode";
            this.lblPostcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_City
            // 
            this.lbl_City.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_City.AutoSize = true;
            this.lbl_City.Location = new System.Drawing.Point(282, 52);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(77, 26);
            this.lbl_City.TabIndex = 21;
            this.lbl_City.Text = "City";
            this.lbl_City.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Addr2
            // 
            this.lbl_Addr2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Addr2.AutoSize = true;
            this.lbl_Addr2.Location = new System.Drawing.Point(282, 26);
            this.lbl_Addr2.Name = "lbl_Addr2";
            this.lbl_Addr2.Size = new System.Drawing.Size(77, 26);
            this.lbl_Addr2.TabIndex = 20;
            this.lbl_Addr2.Text = "Address Line 2";
            this.lbl_Addr2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Addr1
            // 
            this.lbl_Addr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Addr1.AutoSize = true;
            this.lbl_Addr1.Location = new System.Drawing.Point(282, 0);
            this.lbl_Addr1.Name = "lbl_Addr1";
            this.lbl_Addr1.Size = new System.Drawing.Size(77, 26);
            this.lbl_Addr1.TabIndex = 19;
            this.lbl_Addr1.Text = "Address Line 1";
            this.lbl_Addr1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Email
            // 
            this.lbl_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(3, 104);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(89, 27);
            this.lbl_Email.TabIndex = 24;
            this.lbl_Email.Text = "Email";
            this.lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Email
            // 
            this.tb_Email.Enabled = false;
            this.tb_Email.Location = new System.Drawing.Point(98, 107);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(178, 20);
            this.tb_Email.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lbl_Fname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Postcode, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Email, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_City, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Email, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Addr2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPostcode, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_Addr1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Fname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_City, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Lname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_HomeTel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Addr2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Tel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Tel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_Lname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Addr1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_OtherTel, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 131);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // btn_ChangeContact
            // 
            this.btn_ChangeContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChangeContact.Location = new System.Drawing.Point(934, 93);
            this.btn_ChangeContact.Name = "btn_ChangeContact";
            this.btn_ChangeContact.Size = new System.Drawing.Size(99, 41);
            this.btn_ChangeContact.TabIndex = 26;
            this.btn_ChangeContact.Text = "Business Contacts";
            this.btn_ChangeContact.UseVisualStyleBackColor = true;
            this.btn_ChangeContact.Click += new System.EventHandler(this.btn_ChangeContact_Click);
            // 
            // ContactEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 549);
            this.Controls.Add(this.btn_ChangeContact);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_SaveSelected);
            this.Controls.Add(this.btn_DeleteSelected);
            this.Controls.Add(this.btn_UpdateSelected);
            this.Controls.Add(this.btn_SaveNew);
            this.Controls.Add(this.btn_AddNew);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_ContactRecords);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ContactEditor";
            this.Text = "Harris Contact Manager - Personal ";
            this.Load += new System.EventHandler(this.PersonalEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ContactRecords)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ContactRecords;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_AddNew;
        private System.Windows.Forms.Button btn_SaveNew;
        private System.Windows.Forms.Button btn_UpdateSelected;
        private System.Windows.Forms.Button btn_DeleteSelected;
        private System.Windows.Forms.Button btn_SaveSelected;
        private System.Windows.Forms.TextBox tb_Fname;
        private System.Windows.Forms.TextBox tb_Lname;
        private System.Windows.Forms.TextBox tb_Tel;
        private System.Windows.Forms.TextBox tb_HomeTel;
        private System.Windows.Forms.TextBox tb_Postcode;
        private System.Windows.Forms.TextBox tb_City;
        private System.Windows.Forms.TextBox tb_Addr2;
        private System.Windows.Forms.TextBox tb_Addr1;
        private System.Windows.Forms.Label lbl_Fname;
        private System.Windows.Forms.Label lbl_Lname;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lbl_OtherTel;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lbl_City;
        private System.Windows.Forms.Label lbl_Addr2;
        private System.Windows.Forms.Label lbl_Addr1;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_ChangeContact;
    }
}