using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebateForm
{
    public partial class RebateForm : Form
    {
        #region Initializations

        /// <summary>
        /// set some important values
        /// </summary>
        int back_num = 0;
        bool modify = false;

        public RebateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ListView: Preventing users from resizig columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstItems_ColmnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lstItems.Columns[e.ColumnIndex].Width;
        }

        /// <summary>
        /// Main Form Load: Initialize some default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RebateForm_Load(object sender, EventArgs e)
        {
            back_num = 0;
            clear_form();
            
            CB_PoP.SelectedIndex = 1;
            received_date.Value = DateTime.Today;
            received_date.MaxDate = DateTime.Today;

            FileIO.user_list.Clear();
            FileIO.current_user_number = 0;
            lstItems.Items.Clear();
            FileIO fileIO = new FileIO();
            fileIO.update_data();
            foreach( User NewUser in FileIO.user_list )
            {
                string[] new_user = { NewUser.first_name, NewUser.last_name, NewUser.tel };
                ListViewItem n_user = new ListViewItem(new_user);
                n_user.Tag = NewUser.id;
                lstItems.Items.Add(n_user);
            }
        }

        #endregion

        #region Basic Functions

        /// <summary>
        /// Basic Form Functions: clear
        /// </summary>
        private void clear_form()
        {
            modify = false;
            Btn_Ok.Enabled = false;
            TB_FN.Clear();
            TB_MI.Clear();
            TB_LN.Clear();
            CB_Gender.SelectedIndex = -1;
            TB_Addr1.Clear();
            TB_Addr2.Clear();
            TB_City.Clear();
            TB_State.Clear();
            TB_Zip.Clear();
            TB_Email.Clear();
            TB_Tel.Clear();
            lstItems.SelectedItems.Clear();
            hide_time_start.Clear();
            hide_time_save.Clear();
            hide_back_num.Clear();
        }
        /// <summary>
        /// Basic Form Functions: update
        /// </summary>
        private void update_form()
        {
            Btn_Ok.Enabled = false;
            clear_form();
            modify = false;
            FileIO.user_list.Clear();
            lstItems.Items.Clear();
            back_num = 0;
            CB_PoP.SelectedIndex = 1;
            FileIO.current_user_number = 0;
            FileIO fileIO = new FileIO();
            fileIO.update_data();
            foreach (User NewUser in FileIO.user_list)//add all file data to list view
            {
                // string[] new_user = { NewUser.id, NewUser.get_full_name(), NewUser.tel };
                string[] new_user = { NewUser.first_name, NewUser.last_name, NewUser.tel };
                ListViewItem n_user = new ListViewItem(new_user);
                n_user.Tag = NewUser.id;
                lstItems.Items.Add(n_user);
            }
        }

        /// <summary>
        /// Function Count number of 'BackSpace'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RebateForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                back_num++;
            }
        }

        #region Validation Check Functions

        /// <summary>
        /// Check for same record
        /// </summary>
        /// <param name="first_name"></param>
        /// <param name="last_name"></param>
        /// <param name="phone_number"></param>
        /// <returns></returns>
        private bool validation(string first_name, string last_name, string phone_number)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                string full_name = lstItems.SelectedItems[0].SubItems[1].Text;
                string[] temp_user = full_name.Split(' ');
                string first_name_temp = temp_user[0];
                string last_name_temp = temp_user[temp_user.Length - 1];
                string phone_number_temp = lstItems.SelectedItems[0].SubItems[2].Text; //get the basic user info for sorting
                if (first_name == first_name_temp && last_name == last_name_temp && phone_number == phone_number_temp)//grab the exist data of the select user
                {
                    return true;
                }
            }
            foreach (User user in FileIO.user_list)
            {
                if (user.first_name == first_name && user.last_name == last_name && user.tel == phone_number)//grab the exist data of the select user
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// form_validation_function
        /// </summary>
        /* // Previous Solution of validation
        private void form_validation()
        {
            Regex email_reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            Regex states_reg = new Regex("^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$");

            Regex zip_reg = new Regex(@"^\d{5}(?:[-\s]\d{4})?$");

            Regex tel_reg = new Regex(@"^(\+0?1\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$");

            if (!string.IsNullOrEmpty(TB_FN.Text) && !string.IsNullOrEmpty(TB_LN.Text) && !string.IsNullOrEmpty(TB_Addr1.Text) &&
                !string.IsNullOrEmpty(TB_Zip.Text) && !string.IsNullOrEmpty(TB_State.Text) && !string.IsNullOrEmpty(CB_Gender.Text) &&
                !string.IsNullOrEmpty(TB_Tel.Text) && !string.IsNullOrEmpty(TB_Email.Text) && !string.IsNullOrEmpty(TB_City.Text)
                && !string.IsNullOrEmpty(CB_PoP.Text) && email_reg.IsMatch(TB_Email.Text) && tel_reg.IsMatch(TB_Tel.Text)
                && states_reg.IsMatch(TB_State.Text) && zip_reg.IsMatch(TB_Zip.Text))
            {
                Btn_Ok.Enabled = true;
            }
            else
            {
                Btn_Ok.Enabled = false;
            }
        }*/
        private void form_validation()
        {
            Regex email_reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex states_reg = new Regex("^(?-i:A[LKSZRAEP]|C[AOT]|D[EC]|F[LM]|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEHINOPST]|N[CDEHJMVY]|O[HKR]|P[ARW]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$");
            Regex zip_reg = new Regex(@"^\d{5}(?:[-\s]\d{4})?$");
            Regex tel_reg = new Regex(@"^(\+0?1\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$");
            bool mark = true;

            // check for every single field to do ForeColor
            if (string.IsNullOrEmpty(TB_FN.Text))
            {
                TB_FN.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                TB_FN.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(TB_LN.Text))
            {
                TB_LN.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                TB_LN.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(CB_Gender.Text))
            {
                CB_Gender.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                CB_Gender.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(TB_Tel.Text) || !tel_reg.IsMatch(TB_Tel.Text))
            {
                TB_Tel.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                TB_Tel.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(TB_Email.Text) || !email_reg.IsMatch(TB_Email.Text))
            {
                TB_Email.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                TB_Email.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(TB_Addr1.Text))
            {
                TB_Addr1.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                TB_Addr1.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(TB_City.Text))
            {
                TB_City.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                TB_City.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(TB_State.Text) || !states_reg.IsMatch(TB_State.Text))
            {
                TB_State.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                TB_State.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(TB_Zip.Text) || !zip_reg.IsMatch(TB_Zip.Text))
            {
                TB_Zip.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                TB_Zip.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(CB_PoP.Text))
            {
                CB_PoP.ForeColor = Color.Red;
                mark = false;
            }
            else
            {
                CB_PoP.ForeColor = Color.Black;
            }

            Btn_Ok.Enabled = mark;
            return;
        }

        private void TB_FN_TextChanged(object sender, EventArgs e)
        {
            hide_time_start.Text = DateTime.Now.ToString("HH:mm:ss tt");
            form_validation();
        }

        private void TB_MI_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TB_LN_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void CB_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TB_Addr1_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TB_Addr2_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TB_City_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TB_State_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TB_Zip_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TB_Email_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void TB_Tel_TextChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        private void CB_PoP_SelectedIndexChanged(object sender, EventArgs e)
        {
            form_validation();
        }

        #endregion

        #region Button OnClick Functions
        /// <summary>
        /// Submit Button OnClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            FileIO fileIO = new FileIO();
            string proof_of_purchase_attached = CB_PoP.Text;
            string first_name = TB_FN.Text;
            string middle_initial = TB_MI.Text;
            string last_name = TB_LN.Text;
            string gender = CB_Gender.Text;
            string addr1 = TB_Addr1.Text;
            string addr2 = TB_Addr2.Text;
            string city = TB_City.Text;
            string state = TB_State.Text;
            string zip = TB_Zip.Text;
            string email = TB_Email.Text;
            string phone = TB_Tel.Text;
            string date_received = received_date.Value.ToString();
            string time_start = hide_time_start.Text;
            string time_save = DateTime.Now.ToString("HH:mm:ss tt");
            if( modify == true )
            {
                User user_temp;
                string first_name_temp = lstItems.SelectedItems[0].SubItems[0].Text;
                string last_name_temp = lstItems.SelectedItems[0].SubItems[1].Text;
                string phone_number_temp = lstItems.SelectedItems[0].SubItems[2].Text;
                foreach( var user in FileIO.user_list )
                {
                    if( user.first_name == first_name_temp && user.last_name == last_name_temp && user.tel == phone_number_temp )
                    {
                        user_temp = user;
                        time_start = user_temp.time_start;
                        time_save = user_temp.time_save;
                        back_num = Int32.Parse(user_temp.back_num);
                        modify = true;
                    }
                }
                int user_temp_index = lstItems.SelectedItems[0].Index;
                string info = String.Join("\t", user_temp_index, first_name, middle_initial, last_name, gender, addr1, addr2, city, state, zip,
                    email, phone, proof_of_purchase_attached, date_received, time_start, time_save, back_num);
                if (validation(first_name, last_name, phone))
                {
                    fileIO.modify_data(info, user_temp_index);    //filo IO function call _modify data
                    received_date.Value = DateTime.Today;
                    update_form();
                }
            }
            else
            {
                string info = String.Join("\t", FileIO.current_user_number,
                    first_name, middle_initial, last_name, gender, addr1, addr2, city, state, zip,
                    email, phone, proof_of_purchase_attached, date_received, time_start, time_save, back_num);
                if( validation(first_name, last_name, phone) )
                {
                    fileIO.add_data(info);
                    received_date.Value = DateTime.Today;
                    update_form();
                }
            }
        }
        /// <summary>
        /// Delete Button OnClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            FileIO fileIO = new FileIO();
            int user_temp_index = lstItems.SelectedItems[0].Index;
            fileIO.delete_data(user_temp_index);
            received_date.Value = DateTime.Today;
            update_form();
            Btn_Del.Enabled = false;
        }
        /// <summary>
        /// Reset Button OnClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Reset_MouseClick(object sender, MouseEventArgs e)
        {
            Btn_Ok.Enabled = false;
            TB_FN.Clear();
            TB_MI.Clear();
            TB_LN.Clear();
            CB_Gender.SelectedIndex = -1;
            TB_Addr1.Clear();
            TB_Addr2.Clear();
            TB_City.Clear();
            TB_State.Clear();
            TB_Zip.Clear();
            TB_Email.Clear();
            TB_Tel.Clear();
            hide_time_start.Clear();
            hide_time_save.Clear();
            hide_back_num.Clear();
        }

        #endregion

        #endregion

        #region list_interaction_func

        private void lstItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            User user_temp;
            string first_name_temp = lstItems.SelectedItems[0].SubItems[0].Text;
            string last_name_temp = lstItems.SelectedItems[0].SubItems[1].Text;
            string phone_number_temp = lstItems.SelectedItems[0].SubItems[2].Text;
            foreach( var user in FileIO.user_list )
            {
                if (user.first_name == first_name_temp && user.last_name == last_name_temp && user.tel == phone_number_temp)
                {
                    user_temp = user;
                    TB_FN.Text = user_temp.first_name;
                    TB_MI.Text = user_temp.middle_initial;
                    TB_LN.Text = user_temp.last_name;
                    TB_Addr1.Text = user_temp.addr1;
                    TB_Addr2.Text = user_temp.addr2;
                    TB_City.Text = user_temp.city;
                    TB_State.Text = user_temp.state;
                    TB_Zip.Text = user_temp.zip;
                    CB_Gender.Text = user_temp.gender;
                    TB_Tel.Text = user_temp.tel;
                    TB_Email.Text = user_temp.email;
                    if (user_temp.proof == "YES")
                        CB_PoP.SelectedIndex = 0;
                    else
                        CB_PoP.SelectedIndex = 1;
                    DateTime dt = Convert.ToDateTime(user_temp.date); ;
                    received_date.Value = dt;
                    hide_time_start.Text = user_temp.time_start;
                    hide_time_save.Text = user_temp.time_save;
                    hide_back_num.Text = user_temp.back_num;
                    modify = true;
                    Btn_Del.Enabled = true;
                }
            }
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                User user_temp;
                string first_name_temp = lstItems.SelectedItems[0].SubItems[0].Text;
                string last_name_temp = lstItems.SelectedItems[0].SubItems[1].Text;
                string phone_number_temp = lstItems.SelectedItems[0].SubItems[2].Text;
                foreach (var user in FileIO.user_list)
                {
                    if (user.first_name == first_name_temp && user.last_name == last_name_temp && user.tel == phone_number_temp)
                    {
                        user_temp = user;
                        TB_FN.Text = user_temp.first_name;
                        TB_MI.Text = user_temp.middle_initial;
                        TB_LN.Text = user_temp.last_name;
                        TB_Addr1.Text = user_temp.addr1;
                        TB_Addr2.Text = user_temp.addr2;
                        TB_City.Text = user_temp.city;
                        TB_State.Text = user_temp.state;
                        TB_Zip.Text = user_temp.zip;
                        CB_Gender.Text = user_temp.gender;
                        TB_Tel.Text = user_temp.tel;
                        TB_Email.Text = user_temp.email;
                        if (user_temp.proof == "YES")
                            CB_PoP.SelectedIndex = 0;
                        else
                            CB_PoP.SelectedIndex = 1;
                        DateTime dt = Convert.ToDateTime(user_temp.date);
                        received_date.Value = dt;
                        hide_time_start.Text = user_temp.time_start;
                        hide_time_save.Text = user_temp.time_save;
                        hide_back_num.Text = user_temp.back_num;
                        modify = true;
                        Btn_Del.Enabled = true;
                    }
                }

            }
        }

        #endregion
    }
}
