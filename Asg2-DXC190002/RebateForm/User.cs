using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace RebateForm
{
    class User
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string middle_initial { get; set; }
        public string last_name { get; set; }
        public string addr1 { get; set; }
        public string addr2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string gender { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public string proof { get; set; }
        public string date { get; set; }
        public string time_start { get; set; }
        public string time_save { get; set; }
        public string back_num { get; set; }

        public string get_full_name()
        {
            return first_name + " " + middle_initial + " " + last_name;
        }
    }
}
