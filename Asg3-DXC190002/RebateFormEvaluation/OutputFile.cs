using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RebateFormEvaluation
{
    class OutputFile
    {
        public string output_file_path = "";
        public string evaluation_file_path = "";
        public List<InputFileData> input_file_data_list = new List<InputFileData>();
        public int number_of_records = 0;
        public int backspace_count = 0;
        public TimeSpan min_entry_time = new TimeSpan(11, 59, 59);
        public TimeSpan max_entry_time = new TimeSpan(0, 0, 0);
        public TimeSpan average_entry_time;
        public TimeSpan min_inter_time = new TimeSpan(11, 59, 59);
        public TimeSpan max_inter_time = new TimeSpan(0, 0, 0);
        public TimeSpan average_inter_time;
        public TimeSpan total_time;

        public void get_inter_time()
        {
            int i = 0;
            while (i < input_file_data_list.Count)
            {
                if (i == 0)
                {
                    TimeSpan t = new TimeSpan(0, 0, 0);
                    input_file_data_list[i].inter_time = t;
                }
                else
                {
                    TimeSpan diff = input_file_data_list[i].time_start - input_file_data_list[i - 1].time_save;
                    input_file_data_list[i].inter_time = diff;
                }
                i += 1;
            }

        }

        public void read_input_file()
        {
            if (File.Exists(output_file_path))
            {
                StreamReader resultfile = new StreamReader(output_file_path);
                List<String> lines = File.ReadAllLines(output_file_path).ToList();
                foreach (var line in lines)
                {
                    string[] entries = line.Split('\t');
                    InputFileData new_record = new InputFileData
                    {
                        id = entries[0],
                        time_start = TimeSpan.Parse(entries[14].Split(' ')[0]),
                        time_save = TimeSpan.Parse(entries[15].Split(' ')[0]),
                        back_num = entries[16]
                    };
                    backspace_count += int.Parse(new_record.back_num);
                    new_record.time_total = new_record.get_total_time();
                    input_file_data_list.Add(new_record);
                    input_file_data_list[input_file_data_list.Count - 1].inter_time = new_record.inter_time;
                    number_of_records += 1;
                }
                resultfile.Close();
            }
        }

        public void get_max_entry()
        {
            int r = 0;
            while (r < input_file_data_list.Count)
            {
                if (TimeSpan.Compare(input_file_data_list[r].time_total, max_entry_time) != -1)
                {
                    max_entry_time = input_file_data_list[r].time_total;
                }
                r += 1;
            }
        }

        public void get_min_entry()
        {
            int r = 0;
            while (r < input_file_data_list.Count)
            {
                if (TimeSpan.Compare(input_file_data_list[r].time_total, min_entry_time) == -1)
                {
                    min_entry_time = input_file_data_list[r].time_total;
                }
                r += 1;
            }
        }

        public void get_total_entry()
        {
            total_time = (input_file_data_list[input_file_data_list.Count - 1].time_save - input_file_data_list[0].time_start);
        }

        public void get_average_entry()
        {
            TimeSpan t = new TimeSpan(0, 0, 0);
            int r = 0;
            while (r < input_file_data_list.Count)
            {
                t += input_file_data_list[r].time_total;
                r += 1;
            }
            //TimeSpan t = Total_Entering_Time - TimeSpan.Parse("00:00:00");
            average_entry_time = TimeSpan.FromMilliseconds(t.TotalMilliseconds / number_of_records);
        }

        public void get_average_inter()
        {
            TimeSpan t = new TimeSpan(0, 0, 0);
            int r = 0;
            while (r < input_file_data_list.Count)
            {
                t += input_file_data_list[r].inter_time;
                r += 1;
            }
            //TimeSpan t = Total_Entering_Time - TimeSpan.Parse("00:00:00");
            average_inter_time = TimeSpan.FromMilliseconds(t.TotalMilliseconds / number_of_records);
        }
        public void get_max_inter()
        {
            int r = 0;
            while (r < input_file_data_list.Count)
            {
                if (TimeSpan.Compare(input_file_data_list[r].inter_time, max_inter_time) != -1)
                {
                    max_inter_time = input_file_data_list[r].inter_time;
                }
                r += 1;
            }
        }

        public void get_min_inter()
        {
            int r = 0;
            while (r < input_file_data_list.Count)
            {
                if (TimeSpan.Compare(input_file_data_list[r].inter_time, min_inter_time) == -1)
                {
                    min_inter_time = input_file_data_list[r].inter_time;
                }
                r += 1;
            }
        }

        public void write_output_file(string info)
        {
            System.IO.File.WriteAllText(evaluation_file_path, string.Empty); 
            System.IO.StreamWriter file_write = new System.IO.StreamWriter(evaluation_file_path, true);
            
            file_write.WriteLine(info);
            file_write.Close();
        }
    }
}
