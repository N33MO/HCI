using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebateFormEvaluation
{
    class InputFileData
    {
        public string id { get; set; }
        public TimeSpan time_start { get; set; }
        public TimeSpan time_save { get; set; }
        public TimeSpan inter_time { get; set; }

        public string back_num { get; set; }
        public TimeSpan time_total { get; set; }

        public TimeSpan get_total_time()
        {
            TimeSpan total_time = time_save - time_start;
            return total_time;
        }
    }
}
