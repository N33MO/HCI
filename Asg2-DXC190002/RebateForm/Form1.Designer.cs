namespace RebateForm
{
    partial class RebateForm
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
            this.lstItems = new System.Windows.Forms.ListView();
            this.Col_FN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_LN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Col_Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.received_date = new System.Windows.Forms.DateTimePicker();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.CB_PoP = new System.Windows.Forms.ComboBox();
            this.CB_Gender = new System.Windows.Forms.ComboBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Tel = new System.Windows.Forms.TextBox();
            this.TB_Zip = new System.Windows.Forms.TextBox();
            this.TB_State = new System.Windows.Forms.TextBox();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.TB_Addr2 = new System.Windows.Forms.TextBox();
            this.TB_Addr1 = new System.Windows.Forms.TextBox();
            this.FieldsLabel_date = new System.Windows.Forms.Label();
            this.FieldsLabel_PoP = new System.Windows.Forms.Label();
            this.FieldsLabel_email = new System.Windows.Forms.Label();
            this.FieldsLabel_tel = new System.Windows.Forms.Label();
            this.FieldsLabel_gn = new System.Windows.Forms.Label();
            this.FieldsLabel_zip = new System.Windows.Forms.Label();
            this.FieldsLabel_state = new System.Windows.Forms.Label();
            this.FieldsLabel_city = new System.Windows.Forms.Label();
            this.FieldsLabel_ad2 = new System.Windows.Forms.Label();
            this.FieldsLabel_ad1 = new System.Windows.Forms.Label();
            this.TB_LN = new System.Windows.Forms.TextBox();
            this.TB_MI = new System.Windows.Forms.TextBox();
            this.TB_FN = new System.Windows.Forms.TextBox();
            this.FieldsLabel_ln = new System.Windows.Forms.Label();
            this.FieldsLabel_mi = new System.Windows.Forms.Label();
            this.FieldsLabel_fn = new System.Windows.Forms.Label();
            this.hide_time_start = new System.Windows.Forms.TextBox();
            this.hide_time_save = new System.Windows.Forms.TextBox();
            this.hide_back_num = new System.Windows.Forms.TextBox();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Col_FN,
            this.Col_LN,
            this.Col_Tel});
            this.lstItems.FullRowSelect = true;
            this.lstItems.Location = new System.Drawing.Point(15, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(303, 426);
            this.lstItems.TabIndex = 48;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstItems_ColmnWidthChanging);
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            this.lstItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstItems_MouseDoubleClick);
            // 
            // Col_FN
            // 
            this.Col_FN.Text = "First Name";
            this.Col_FN.Width = 125;
            // 
            // Col_LN
            // 
            this.Col_LN.Text = "Last Name";
            this.Col_LN.Width = 80;
            // 
            // Col_Tel
            // 
            this.Col_Tel.Text = "Phone #";
            this.Col_Tel.Width = 80;
            // 
            // received_date
            // 
            this.received_date.Checked = false;
            this.received_date.Location = new System.Drawing.Point(442, 290);
            this.received_date.Name = "received_date";
            this.received_date.Size = new System.Drawing.Size(192, 20);
            this.received_date.TabIndex = 12;
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Enabled = false;
            this.Btn_Ok.Location = new System.Drawing.Point(688, 349);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(100, 60);
            this.Btn_Ok.TabIndex = 14;
            this.Btn_Ok.Text = "Submit";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(582, 349);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(100, 60);
            this.Btn_Reset.TabIndex = 14;
            this.Btn_Reset.Text = "Reset";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Reset_MouseClick);
            // 
            // CB_PoP
            // 
            this.CB_PoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_PoP.FormattingEnabled = true;
            this.CB_PoP.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CB_PoP.Location = new System.Drawing.Point(468, 260);
            this.CB_PoP.Name = "CB_PoP";
            this.CB_PoP.Size = new System.Drawing.Size(56, 21);
            this.CB_PoP.TabIndex = 11;
            this.CB_PoP.SelectedIndexChanged += new System.EventHandler(this.CB_PoP_SelectedIndexChanged);
            // 
            // CB_Gender
            // 
            this.CB_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Gender.FormattingEnabled = true;
            this.CB_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CB_Gender.Location = new System.Drawing.Point(726, 80);
            this.CB_Gender.Name = "CB_Gender";
            this.CB_Gender.Size = new System.Drawing.Size(59, 21);
            this.CB_Gender.TabIndex = 3;
            this.CB_Gender.SelectedIndexChanged += new System.EventHandler(this.CB_Gender_SelectedIndexChanged);
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(393, 200);
            this.TB_Email.MaxLength = 29;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(246, 20);
            this.TB_Email.TabIndex = 9;
            this.TB_Email.TextChanged += new System.EventHandler(this.TB_Email_TextChanged);
            // 
            // TB_Tel
            // 
            this.TB_Tel.Location = new System.Drawing.Point(395, 230);
            this.TB_Tel.MaxLength = 16;
            this.TB_Tel.Name = "TB_Tel";
            this.TB_Tel.Size = new System.Drawing.Size(129, 20);
            this.TB_Tel.TabIndex = 10;
            this.TB_Tel.TextChanged += new System.EventHandler(this.TB_Tel_TextChanged);
            // 
            // TB_Zip
            // 
            this.TB_Zip.Location = new System.Drawing.Point(718, 170);
            this.TB_Zip.MaxLength = 10;
            this.TB_Zip.Name = "TB_Zip";
            this.TB_Zip.Size = new System.Drawing.Size(67, 20);
            this.TB_Zip.TabIndex = 8;
            this.TB_Zip.TextChanged += new System.EventHandler(this.TB_Zip_TextChanged);
            // 
            // TB_State
            // 
            this.TB_State.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_State.Location = new System.Drawing.Point(595, 169);
            this.TB_State.MaxLength = 2;
            this.TB_State.Name = "TB_State";
            this.TB_State.Size = new System.Drawing.Size(44, 20);
            this.TB_State.TabIndex = 7;
            this.TB_State.TextChanged += new System.EventHandler(this.TB_State_TextChanged);
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(377, 170);
            this.TB_City.MaxLength = 15;
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(161, 20);
            this.TB_City.TabIndex = 6;
            this.TB_City.TextChanged += new System.EventHandler(this.TB_City_TextChanged);
            // 
            // TB_Addr2
            // 
            this.TB_Addr2.Location = new System.Drawing.Point(454, 140);
            this.TB_Addr2.Name = "TB_Addr2";
            this.TB_Addr2.Size = new System.Drawing.Size(331, 20);
            this.TB_Addr2.TabIndex = 5;
            this.TB_Addr2.TextChanged += new System.EventHandler(this.TB_Addr2_TextChanged);
            // 
            // TB_Addr1
            // 
            this.TB_Addr1.Location = new System.Drawing.Point(454, 110);
            this.TB_Addr1.Name = "TB_Addr1";
            this.TB_Addr1.Size = new System.Drawing.Size(331, 20);
            this.TB_Addr1.TabIndex = 4;
            this.TB_Addr1.TextChanged += new System.EventHandler(this.TB_Addr1_TextChanged);
            // 
            // FieldsLabel_date
            // 
            this.FieldsLabel_date.AutoSize = true;
            this.FieldsLabel_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_date.Location = new System.Drawing.Point(336, 290);
            this.FieldsLabel_date.Name = "FieldsLabel_date";
            this.FieldsLabel_date.Size = new System.Drawing.Size(105, 17);
            this.FieldsLabel_date.TabIndex = 44;
            this.FieldsLabel_date.Text = "*Date received:";
            // 
            // FieldsLabel_PoP
            // 
            this.FieldsLabel_PoP.AutoSize = true;
            this.FieldsLabel_PoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_PoP.Location = new System.Drawing.Point(336, 260);
            this.FieldsLabel_PoP.Name = "FieldsLabel_PoP";
            this.FieldsLabel_PoP.Size = new System.Drawing.Size(131, 17);
            this.FieldsLabel_PoP.TabIndex = 43;
            this.FieldsLabel_PoP.Text = "*Proof of Purchase:";
            // 
            // FieldsLabel_email
            // 
            this.FieldsLabel_email.AutoSize = true;
            this.FieldsLabel_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_email.Location = new System.Drawing.Point(336, 200);
            this.FieldsLabel_email.Name = "FieldsLabel_email";
            this.FieldsLabel_email.Size = new System.Drawing.Size(56, 17);
            this.FieldsLabel_email.TabIndex = 42;
            this.FieldsLabel_email.Text = "*E-mail:";
            // 
            // FieldsLabel_tel
            // 
            this.FieldsLabel_tel.AutoSize = true;
            this.FieldsLabel_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_tel.Location = new System.Drawing.Point(336, 230);
            this.FieldsLabel_tel.Name = "FieldsLabel_tel";
            this.FieldsLabel_tel.Size = new System.Drawing.Size(58, 17);
            this.FieldsLabel_tel.TabIndex = 41;
            this.FieldsLabel_tel.Text = "*Phone:";
            // 
            // FieldsLabel_gn
            // 
            this.FieldsLabel_gn.AutoSize = true;
            this.FieldsLabel_gn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_gn.Location = new System.Drawing.Point(645, 80);
            this.FieldsLabel_gn.Name = "FieldsLabel_gn";
            this.FieldsLabel_gn.Size = new System.Drawing.Size(65, 17);
            this.FieldsLabel_gn.TabIndex = 40;
            this.FieldsLabel_gn.Text = "*Gender:";
            // 
            // FieldsLabel_zip
            // 
            this.FieldsLabel_zip.AutoSize = true;
            this.FieldsLabel_zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_zip.Location = new System.Drawing.Point(645, 170);
            this.FieldsLabel_zip.Name = "FieldsLabel_zip";
            this.FieldsLabel_zip.Size = new System.Drawing.Size(72, 17);
            this.FieldsLabel_zip.TabIndex = 38;
            this.FieldsLabel_zip.Text = "*Zip code:";
            // 
            // FieldsLabel_state
            // 
            this.FieldsLabel_state.AutoSize = true;
            this.FieldsLabel_state.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_state.Location = new System.Drawing.Point(544, 170);
            this.FieldsLabel_state.Name = "FieldsLabel_state";
            this.FieldsLabel_state.Size = new System.Drawing.Size(50, 17);
            this.FieldsLabel_state.TabIndex = 36;
            this.FieldsLabel_state.Text = "*State:";
            // 
            // FieldsLabel_city
            // 
            this.FieldsLabel_city.AutoSize = true;
            this.FieldsLabel_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_city.Location = new System.Drawing.Point(336, 170);
            this.FieldsLabel_city.Name = "FieldsLabel_city";
            this.FieldsLabel_city.Size = new System.Drawing.Size(40, 17);
            this.FieldsLabel_city.TabIndex = 33;
            this.FieldsLabel_city.Text = "*City:";
            // 
            // FieldsLabel_ad2
            // 
            this.FieldsLabel_ad2.AutoSize = true;
            this.FieldsLabel_ad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_ad2.Location = new System.Drawing.Point(336, 140);
            this.FieldsLabel_ad2.Name = "FieldsLabel_ad2";
            this.FieldsLabel_ad2.Size = new System.Drawing.Size(107, 17);
            this.FieldsLabel_ad2.TabIndex = 32;
            this.FieldsLabel_ad2.Text = "Address Line 2:";
            // 
            // FieldsLabel_ad1
            // 
            this.FieldsLabel_ad1.AutoSize = true;
            this.FieldsLabel_ad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_ad1.Location = new System.Drawing.Point(336, 110);
            this.FieldsLabel_ad1.Name = "FieldsLabel_ad1";
            this.FieldsLabel_ad1.Size = new System.Drawing.Size(112, 17);
            this.FieldsLabel_ad1.TabIndex = 30;
            this.FieldsLabel_ad1.Text = "*Address Line 1:";
            // 
            // TB_LN
            // 
            this.TB_LN.Location = new System.Drawing.Point(427, 80);
            this.TB_LN.MaxLength = 16;
            this.TB_LN.Name = "TB_LN";
            this.TB_LN.Size = new System.Drawing.Size(212, 20);
            this.TB_LN.TabIndex = 2;
            this.TB_LN.TextChanged += new System.EventHandler(this.TB_LN_TextChanged);
            // 
            // TB_MI
            // 
            this.TB_MI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TB_MI.Location = new System.Drawing.Point(726, 50);
            this.TB_MI.MaxLength = 1;
            this.TB_MI.Name = "TB_MI";
            this.TB_MI.Size = new System.Drawing.Size(59, 20);
            this.TB_MI.TabIndex = 1;
            this.TB_MI.TextChanged += new System.EventHandler(this.TB_MI_TextChanged);
            // 
            // TB_FN
            // 
            this.TB_FN.Location = new System.Drawing.Point(427, 50);
            this.TB_FN.MaxLength = 16;
            this.TB_FN.Name = "TB_FN";
            this.TB_FN.Size = new System.Drawing.Size(212, 20);
            this.TB_FN.TabIndex = 0;
            this.TB_FN.TextChanged += new System.EventHandler(this.TB_FN_TextChanged);
            // 
            // FieldsLabel_ln
            // 
            this.FieldsLabel_ln.AutoSize = true;
            this.FieldsLabel_ln.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_ln.Location = new System.Drawing.Point(336, 80);
            this.FieldsLabel_ln.Name = "FieldsLabel_ln";
            this.FieldsLabel_ln.Size = new System.Drawing.Size(85, 17);
            this.FieldsLabel_ln.TabIndex = 24;
            this.FieldsLabel_ln.Text = "*Last Name:";
            // 
            // FieldsLabel_mi
            // 
            this.FieldsLabel_mi.AutoSize = true;
            this.FieldsLabel_mi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_mi.Location = new System.Drawing.Point(645, 50);
            this.FieldsLabel_mi.Name = "FieldsLabel_mi";
            this.FieldsLabel_mi.Size = new System.Drawing.Size(75, 17);
            this.FieldsLabel_mi.TabIndex = 23;
            this.FieldsLabel_mi.Text = "Middle Init:";
            // 
            // FieldsLabel_fn
            // 
            this.FieldsLabel_fn.AutoSize = true;
            this.FieldsLabel_fn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldsLabel_fn.Location = new System.Drawing.Point(336, 50);
            this.FieldsLabel_fn.Name = "FieldsLabel_fn";
            this.FieldsLabel_fn.Size = new System.Drawing.Size(85, 17);
            this.FieldsLabel_fn.TabIndex = 20;
            this.FieldsLabel_fn.Text = "*First Name:";
            // 
            // hide_time_start
            // 
            this.hide_time_start.Location = new System.Drawing.Point(336, 322);
            this.hide_time_start.Name = "hide_time_start";
            this.hide_time_start.Size = new System.Drawing.Size(100, 20);
            this.hide_time_start.TabIndex = 49;
            this.hide_time_start.TabStop = false;
            this.hide_time_start.Visible = false;
            // 
            // hide_time_save
            // 
            this.hide_time_save.Location = new System.Drawing.Point(336, 349);
            this.hide_time_save.Name = "hide_time_save";
            this.hide_time_save.Size = new System.Drawing.Size(100, 20);
            this.hide_time_save.TabIndex = 50;
            this.hide_time_save.TabStop = false;
            this.hide_time_save.Visible = false;
            // 
            // hide_back_num
            // 
            this.hide_back_num.Location = new System.Drawing.Point(336, 375);
            this.hide_back_num.Name = "hide_back_num";
            this.hide_back_num.Size = new System.Drawing.Size(100, 20);
            this.hide_back_num.TabIndex = 51;
            this.hide_back_num.TabStop = false;
            this.hide_back_num.Visible = false;
            // 
            // Btn_Del
            // 
            this.Btn_Del.Enabled = false;
            this.Btn_Del.Location = new System.Drawing.Point(476, 349);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(100, 60);
            this.Btn_Del.TabIndex = 13;
            this.Btn_Del.Text = "Delete";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // RebateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Del);
            this.Controls.Add(this.hide_back_num);
            this.Controls.Add(this.hide_time_save);
            this.Controls.Add(this.hide_time_start);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.received_date);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.CB_PoP);
            this.Controls.Add(this.CB_Gender);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.TB_Tel);
            this.Controls.Add(this.TB_Zip);
            this.Controls.Add(this.TB_State);
            this.Controls.Add(this.TB_City);
            this.Controls.Add(this.TB_Addr2);
            this.Controls.Add(this.TB_Addr1);
            this.Controls.Add(this.FieldsLabel_date);
            this.Controls.Add(this.FieldsLabel_PoP);
            this.Controls.Add(this.FieldsLabel_email);
            this.Controls.Add(this.FieldsLabel_tel);
            this.Controls.Add(this.FieldsLabel_gn);
            this.Controls.Add(this.FieldsLabel_zip);
            this.Controls.Add(this.FieldsLabel_state);
            this.Controls.Add(this.FieldsLabel_city);
            this.Controls.Add(this.FieldsLabel_ad2);
            this.Controls.Add(this.FieldsLabel_ad1);
            this.Controls.Add(this.TB_LN);
            this.Controls.Add(this.TB_MI);
            this.Controls.Add(this.TB_FN);
            this.Controls.Add(this.FieldsLabel_ln);
            this.Controls.Add(this.FieldsLabel_mi);
            this.Controls.Add(this.FieldsLabel_fn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RebateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rebate Form";
            this.Load += new System.EventHandler(this.RebateForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RebateForm_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader Col_FN;
        private System.Windows.Forms.ColumnHeader Col_LN;
        private System.Windows.Forms.ColumnHeader Col_Tel;
        private System.Windows.Forms.DateTimePicker received_date;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.ComboBox CB_PoP;
        private System.Windows.Forms.ComboBox CB_Gender;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Tel;
        private System.Windows.Forms.TextBox TB_Zip;
        private System.Windows.Forms.TextBox TB_State;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.TextBox TB_Addr2;
        private System.Windows.Forms.TextBox TB_Addr1;
        private System.Windows.Forms.Label FieldsLabel_date;
        private System.Windows.Forms.Label FieldsLabel_PoP;
        private System.Windows.Forms.Label FieldsLabel_email;
        private System.Windows.Forms.Label FieldsLabel_tel;
        private System.Windows.Forms.Label FieldsLabel_gn;
        private System.Windows.Forms.Label FieldsLabel_zip;
        private System.Windows.Forms.Label FieldsLabel_state;
        private System.Windows.Forms.Label FieldsLabel_city;
        private System.Windows.Forms.Label FieldsLabel_ad2;
        private System.Windows.Forms.Label FieldsLabel_ad1;
        private System.Windows.Forms.TextBox TB_LN;
        private System.Windows.Forms.TextBox TB_MI;
        private System.Windows.Forms.TextBox TB_FN;
        private System.Windows.Forms.Label FieldsLabel_ln;
        private System.Windows.Forms.Label FieldsLabel_mi;
        private System.Windows.Forms.Label FieldsLabel_fn;
        private System.Windows.Forms.TextBox hide_time_start;
        private System.Windows.Forms.TextBox hide_time_save;
        private System.Windows.Forms.TextBox hide_back_num;
        private System.Windows.Forms.Button Btn_Del;
    }
}

