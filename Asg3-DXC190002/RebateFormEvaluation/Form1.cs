using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebateFormEvaluation
{
    public partial class RebateFormEvaluation : Form
    {
        // set some useful parameters
        public string input_file_path { get; set; }
        public string output_file_path { get; set; }
        public string evaluation { get; set; }
        public RebateFormEvaluation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set input file to be analysis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Dir_IN_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDataFileDialog = new OpenFileDialog();

            if (OpenDataFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Label_Dir_IN.Text = OpenDataFileDialog.FileName;
            }
        }

        /// <summary>
        /// Set output directory to generate result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Dir_OUT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OpenEvaluationFileDialog = new FolderBrowserDialog();

            if (OpenEvaluationFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Label_Dir_OUT.Text = OpenEvaluationFileDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Set output file full directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void get_output_file_name(object sender, EventArgs e)
        {
            Label_Filename_OUT.Text = Label_Dir_OUT.Text + "\\" + Textbox_OutputFileName.Text + ".txt";
        }

        /// <summary>
        /// Function when click on "Analysis"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Run_Click(object sender, EventArgs e)
        {
            // check input file directory
            if (String.IsNullOrEmpty(Label_Dir_IN.Text) || Label_Dir_IN.Text == "(Input file path)" || Label_Dir_IN.Text == "No input file selected.")
            {
                Label_Dir_IN.Text = "No input file selected.";
            }
            // check output directoy
            else if (String.IsNullOrEmpty(Label_Dir_OUT.Text) || Label_Dir_OUT.Text == "(Output file directory)" || Label_Dir_OUT.Text == "No output directory selected.")
            {
                Label_Dir_OUT.Text = "No output directory selected.";
            }
            // check output file name
            else if (String.IsNullOrEmpty(Textbox_OutputFileName.Text) || Label_Filename_OUT.Text == "No output file name.")
            {
                Label_Filename_OUT.Text = "No output file name.";
            }
            // when input and output set is finished, start analysis
            else
            {
                Show_Result_Label(); // make result fields visible
                output_file_path = Label_Filename_OUT.Text;
                OutputFile out_put_file = new OutputFile();
                out_put_file.output_file_path = Label_Dir_IN.Text;
                out_put_file.evaluation_file_path = Label_Filename_OUT.Text;
                out_put_file.read_input_file();
                out_put_file.get_inter_time();
                out_put_file.get_total_entry();
                out_put_file.get_average_inter();
                out_put_file.get_average_entry();
                out_put_file.get_max_inter();
                out_put_file.get_max_entry();
                out_put_file.get_min_inter();
                out_put_file.get_min_entry();
                Label_RecordNum.Text = out_put_file.number_of_records.ToString();
                Label_EntryTime_MIN.Text = out_put_file.min_entry_time.ToString("mm':'ss");
                Label_EntryTime_MAX.Text = out_put_file.max_entry_time.ToString("mm':'ss");
                Label_EntryTime_AVG.Text = out_put_file.average_entry_time.ToString("mm':'ss");
                Label_InterTime_MIN.Text = out_put_file.min_inter_time.ToString("mm':'ss");
                Label_InterTime_MAX.Text = out_put_file.max_inter_time.ToString("mm':'ss");
                Label_InterTime_AVG.Text = out_put_file.average_inter_time.ToString("mm':'ss");
                Label_TotalTime.Text = out_put_file.total_time.ToString("mm':'ss");
                Label_BackspaceCount.Text = out_put_file.backspace_count.ToString();
                Generate_Evaluation_Info();
                out_put_file.write_output_file(evaluation);
            }

        }

        /// <summary>
        /// Set result fields
        /// </summary>
        public void Generate_Evaluation_Info()
        {
            evaluation = "";
            evaluation = evaluation + "Number of records: " + Label_RecordNum.Text + "\n";
            evaluation = evaluation + "Minimum entry time: " + Label_EntryTime_MIN.Text + "\n";
            evaluation = evaluation + "Maximum entry time: " + Label_EntryTime_MAX.Text + "\n";
            evaluation = evaluation + "Average entry time: " + Label_EntryTime_AVG.Text + "\n";
            evaluation = evaluation + "Minimum inter-record time: " + Label_InterTime_MIN.Text + "\n";
            evaluation = evaluation + "Maximum inter-record time: " + Label_InterTime_MAX.Text + "\n";
            evaluation = evaluation + "Average inter-record time: " + Label_InterTime_AVG.Text + "\n";
            evaluation = evaluation + "Total time: " + Label_TotalTime.Text + "\n";
            evaluation = evaluation + "Backspace count: " + Label_BackspaceCount.Text + "\n";
        }

        /// <summary>
        /// Make the result field visible when correctly start analyze the file
        /// </summary>
        public void Show_Result_Label()
        {
            Label_NOTE_Result.Visible = true;
            Label_NOTE_NumberOfRecords.Visible = true;
            Label_RecordNum.Visible = true;
            Label_NOTE_MinimumEntryTime.Visible = true;
            Label_EntryTime_MIN.Visible = true;
            Label_NOTE_MaximumEntryTime.Visible = true;
            Label_EntryTime_MAX.Visible = true;
            Label_NOTE_AverageEntryTime.Visible = true;
            Label_EntryTime_AVG.Visible = true;
            Label_NOTE_MinimumInterrecordTime.Visible = true;
            Label_InterTime_MIN.Visible = true;
            Label_NOTE_MaximumInterrecordTime.Visible = true;
            Label_InterTime_MAX.Visible = true;
            Label_NOTE_AverageInterrecordTime.Visible = true;
            Label_InterTime_AVG.Visible = true;
            Label_NOTE_TotalTime.Visible = true;
            Label_TotalTime.Visible = true;
            Label_NOTE_BackspaceCount.Visible = true;
            Label_BackspaceCount.Visible = true;
        }
    }
}
