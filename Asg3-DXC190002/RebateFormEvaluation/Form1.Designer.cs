namespace RebateFormEvaluation
{
    partial class RebateFormEvaluation
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
            this.Button_Dir_IN = new System.Windows.Forms.Button();
            this.Label_Dir_IN = new System.Windows.Forms.Label();
            this.Button_Dir_OUT = new System.Windows.Forms.Button();
            this.Label_Dir_OUT = new System.Windows.Forms.Label();
            this.Label_Filename_OUT = new System.Windows.Forms.Label();
            this.Label_NOTE_Dir_IN = new System.Windows.Forms.Label();
            this.Label_NOTE_Dir_OUT = new System.Windows.Forms.Label();
            this.Button_Run = new System.Windows.Forms.Button();
            this.Label_NOTE_Result = new System.Windows.Forms.Label();
            this.Label_NOTE_NumberOfRecords = new System.Windows.Forms.Label();
            this.Label_NOTE_MinimumEntryTime = new System.Windows.Forms.Label();
            this.Label_NOTE_MaximumEntryTime = new System.Windows.Forms.Label();
            this.Label_NOTE_AverageEntryTime = new System.Windows.Forms.Label();
            this.Label_NOTE_MinimumInterrecordTime = new System.Windows.Forms.Label();
            this.Label_NOTE_MaximumInterrecordTime = new System.Windows.Forms.Label();
            this.Label_NOTE_AverageInterrecordTime = new System.Windows.Forms.Label();
            this.Label_NOTE_TotalTime = new System.Windows.Forms.Label();
            this.Label_NOTE_BackspaceCount = new System.Windows.Forms.Label();
            this.Label_RecordNum = new System.Windows.Forms.Label();
            this.Label_EntryTime_MIN = new System.Windows.Forms.Label();
            this.Label_EntryTime_MAX = new System.Windows.Forms.Label();
            this.Label_EntryTime_AVG = new System.Windows.Forms.Label();
            this.Label_InterTime_MIN = new System.Windows.Forms.Label();
            this.Label_InterTime_MAX = new System.Windows.Forms.Label();
            this.Label_InterTime_AVG = new System.Windows.Forms.Label();
            this.Label_TotalTime = new System.Windows.Forms.Label();
            this.Label_BackspaceCount = new System.Windows.Forms.Label();
            this.Label_NOTE_FileName_OUT = new System.Windows.Forms.Label();
            this.Textbox_OutputFileName = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Button_Dir_IN
            // 
            this.Button_Dir_IN.AutoSize = true;
            this.Button_Dir_IN.Location = new System.Drawing.Point(159, 32);
            this.Button_Dir_IN.Name = "Button_Dir_IN";
            this.Button_Dir_IN.Size = new System.Drawing.Size(75, 23);
            this.Button_Dir_IN.TabIndex = 0;
            this.Button_Dir_IN.Text = "Browse";
            this.Button_Dir_IN.UseVisualStyleBackColor = true;
            this.Button_Dir_IN.Click += new System.EventHandler(this.Button_Dir_IN_Click);
            // 
            // Label_Dir_IN
            // 
            this.Label_Dir_IN.AutoSize = true;
            this.Label_Dir_IN.Location = new System.Drawing.Point(240, 37);
            this.Label_Dir_IN.Name = "Label_Dir_IN";
            this.Label_Dir_IN.Size = new System.Drawing.Size(77, 13);
            this.Label_Dir_IN.TabIndex = 1;
            this.Label_Dir_IN.Text = "(Input file path)";
            // 
            // Button_Dir_OUT
            // 
            this.Button_Dir_OUT.AutoSize = true;
            this.Button_Dir_OUT.Location = new System.Drawing.Point(159, 76);
            this.Button_Dir_OUT.Name = "Button_Dir_OUT";
            this.Button_Dir_OUT.Size = new System.Drawing.Size(75, 23);
            this.Button_Dir_OUT.TabIndex = 2;
            this.Button_Dir_OUT.Text = "Browse";
            this.Button_Dir_OUT.UseVisualStyleBackColor = true;
            this.Button_Dir_OUT.Click += new System.EventHandler(this.Button_Dir_OUT_Click);
            // 
            // Label_Dir_OUT
            // 
            this.Label_Dir_OUT.AutoSize = true;
            this.Label_Dir_OUT.Location = new System.Drawing.Point(240, 81);
            this.Label_Dir_OUT.Name = "Label_Dir_OUT";
            this.Label_Dir_OUT.Size = new System.Drawing.Size(104, 13);
            this.Label_Dir_OUT.TabIndex = 3;
            this.Label_Dir_OUT.Text = "(Output file directory)";
            // 
            // Label_Filename_OUT
            // 
            this.Label_Filename_OUT.AutoSize = true;
            this.Label_Filename_OUT.Location = new System.Drawing.Point(268, 120);
            this.Label_Filename_OUT.Name = "Label_Filename_OUT";
            this.Label_Filename_OUT.Size = new System.Drawing.Size(217, 13);
            this.Label_Filename_OUT.TabIndex = 4;
            this.Label_Filename_OUT.Text = "this show the output file name in a kindy way";
            // 
            // Label_NOTE_Dir_IN
            // 
            this.Label_NOTE_Dir_IN.AutoSize = true;
            this.Label_NOTE_Dir_IN.Location = new System.Drawing.Point(31, 37);
            this.Label_NOTE_Dir_IN.Name = "Label_NOTE_Dir_IN";
            this.Label_NOTE_Dir_IN.Size = new System.Drawing.Size(85, 13);
            this.Label_NOTE_Dir_IN.TabIndex = 5;
            this.Label_NOTE_Dir_IN.Text = "Select input file: ";
            this.Label_NOTE_Dir_IN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_NOTE_Dir_OUT
            // 
            this.Label_NOTE_Dir_OUT.AutoSize = true;
            this.Label_NOTE_Dir_OUT.Location = new System.Drawing.Point(31, 81);
            this.Label_NOTE_Dir_OUT.Name = "Label_NOTE_Dir_OUT";
            this.Label_NOTE_Dir_OUT.Size = new System.Drawing.Size(119, 13);
            this.Label_NOTE_Dir_OUT.TabIndex = 6;
            this.Label_NOTE_Dir_OUT.Text = "Select output directory: ";
            this.Label_NOTE_Dir_OUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(159, 171);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 7;
            this.Button_Run.Text = "Analysis";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // Label_NOTE_Result
            // 
            this.Label_NOTE_Result.AutoSize = true;
            this.Label_NOTE_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_Result.Location = new System.Drawing.Point(31, 212);
            this.Label_NOTE_Result.Name = "Label_NOTE_Result";
            this.Label_NOTE_Result.Size = new System.Drawing.Size(63, 17);
            this.Label_NOTE_Result.TabIndex = 8;
            this.Label_NOTE_Result.Text = "Results: ";
            this.Label_NOTE_Result.Visible = false;
            // 
            // Label_NOTE_NumberOfRecords
            // 
            this.Label_NOTE_NumberOfRecords.AutoSize = true;
            this.Label_NOTE_NumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_NumberOfRecords.Location = new System.Drawing.Point(42, 247);
            this.Label_NOTE_NumberOfRecords.Name = "Label_NOTE_NumberOfRecords";
            this.Label_NOTE_NumberOfRecords.Size = new System.Drawing.Size(134, 17);
            this.Label_NOTE_NumberOfRecords.TabIndex = 9;
            this.Label_NOTE_NumberOfRecords.Text = "Number of records: ";
            this.Label_NOTE_NumberOfRecords.Visible = false;
            // 
            // Label_NOTE_MinimumEntryTime
            // 
            this.Label_NOTE_MinimumEntryTime.AutoSize = true;
            this.Label_NOTE_MinimumEntryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_MinimumEntryTime.Location = new System.Drawing.Point(42, 287);
            this.Label_NOTE_MinimumEntryTime.Name = "Label_NOTE_MinimumEntryTime";
            this.Label_NOTE_MinimumEntryTime.Size = new System.Drawing.Size(137, 17);
            this.Label_NOTE_MinimumEntryTime.TabIndex = 10;
            this.Label_NOTE_MinimumEntryTime.Text = "Minimum entry time: ";
            this.Label_NOTE_MinimumEntryTime.Visible = false;
            // 
            // Label_NOTE_MaximumEntryTime
            // 
            this.Label_NOTE_MaximumEntryTime.AutoSize = true;
            this.Label_NOTE_MaximumEntryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_MaximumEntryTime.Location = new System.Drawing.Point(42, 327);
            this.Label_NOTE_MaximumEntryTime.Name = "Label_NOTE_MaximumEntryTime";
            this.Label_NOTE_MaximumEntryTime.Size = new System.Drawing.Size(140, 17);
            this.Label_NOTE_MaximumEntryTime.TabIndex = 11;
            this.Label_NOTE_MaximumEntryTime.Text = "Maximum entry time: ";
            this.Label_NOTE_MaximumEntryTime.Visible = false;
            // 
            // Label_NOTE_AverageEntryTime
            // 
            this.Label_NOTE_AverageEntryTime.AutoSize = true;
            this.Label_NOTE_AverageEntryTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_AverageEntryTime.Location = new System.Drawing.Point(42, 367);
            this.Label_NOTE_AverageEntryTime.Name = "Label_NOTE_AverageEntryTime";
            this.Label_NOTE_AverageEntryTime.Size = new System.Drawing.Size(135, 17);
            this.Label_NOTE_AverageEntryTime.TabIndex = 12;
            this.Label_NOTE_AverageEntryTime.Text = "Average entry time: ";
            this.Label_NOTE_AverageEntryTime.Visible = false;
            // 
            // Label_NOTE_MinimumInterrecordTime
            // 
            this.Label_NOTE_MinimumInterrecordTime.AutoSize = true;
            this.Label_NOTE_MinimumInterrecordTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_MinimumInterrecordTime.Location = new System.Drawing.Point(268, 287);
            this.Label_NOTE_MinimumInterrecordTime.Name = "Label_NOTE_MinimumInterrecordTime";
            this.Label_NOTE_MinimumInterrecordTime.Size = new System.Drawing.Size(179, 17);
            this.Label_NOTE_MinimumInterrecordTime.TabIndex = 13;
            this.Label_NOTE_MinimumInterrecordTime.Text = "Minimum inter-record time: ";
            this.Label_NOTE_MinimumInterrecordTime.Visible = false;
            // 
            // Label_NOTE_MaximumInterrecordTime
            // 
            this.Label_NOTE_MaximumInterrecordTime.AutoSize = true;
            this.Label_NOTE_MaximumInterrecordTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_MaximumInterrecordTime.Location = new System.Drawing.Point(268, 327);
            this.Label_NOTE_MaximumInterrecordTime.Name = "Label_NOTE_MaximumInterrecordTime";
            this.Label_NOTE_MaximumInterrecordTime.Size = new System.Drawing.Size(182, 17);
            this.Label_NOTE_MaximumInterrecordTime.TabIndex = 14;
            this.Label_NOTE_MaximumInterrecordTime.Text = "Maximum inter-record time: ";
            this.Label_NOTE_MaximumInterrecordTime.Visible = false;
            // 
            // Label_NOTE_AverageInterrecordTime
            // 
            this.Label_NOTE_AverageInterrecordTime.AutoSize = true;
            this.Label_NOTE_AverageInterrecordTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_AverageInterrecordTime.Location = new System.Drawing.Point(268, 367);
            this.Label_NOTE_AverageInterrecordTime.Name = "Label_NOTE_AverageInterrecordTime";
            this.Label_NOTE_AverageInterrecordTime.Size = new System.Drawing.Size(177, 17);
            this.Label_NOTE_AverageInterrecordTime.TabIndex = 15;
            this.Label_NOTE_AverageInterrecordTime.Text = "Average inter-record time: ";
            this.Label_NOTE_AverageInterrecordTime.Visible = false;
            // 
            // Label_NOTE_TotalTime
            // 
            this.Label_NOTE_TotalTime.AutoSize = true;
            this.Label_NOTE_TotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_TotalTime.Location = new System.Drawing.Point(565, 287);
            this.Label_NOTE_TotalTime.Name = "Label_NOTE_TotalTime";
            this.Label_NOTE_TotalTime.Size = new System.Drawing.Size(78, 17);
            this.Label_NOTE_TotalTime.TabIndex = 16;
            this.Label_NOTE_TotalTime.Text = "Total time: ";
            this.Label_NOTE_TotalTime.Visible = false;
            // 
            // Label_NOTE_BackspaceCount
            // 
            this.Label_NOTE_BackspaceCount.AutoSize = true;
            this.Label_NOTE_BackspaceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NOTE_BackspaceCount.Location = new System.Drawing.Point(565, 327);
            this.Label_NOTE_BackspaceCount.Name = "Label_NOTE_BackspaceCount";
            this.Label_NOTE_BackspaceCount.Size = new System.Drawing.Size(124, 17);
            this.Label_NOTE_BackspaceCount.TabIndex = 17;
            this.Label_NOTE_BackspaceCount.Text = "Backspace count: ";
            this.Label_NOTE_BackspaceCount.Visible = false;
            // 
            // Label_RecordNum
            // 
            this.Label_RecordNum.AutoSize = true;
            this.Label_RecordNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RecordNum.Location = new System.Drawing.Point(182, 247);
            this.Label_RecordNum.Name = "Label_RecordNum";
            this.Label_RecordNum.Size = new System.Drawing.Size(46, 17);
            this.Label_RecordNum.TabIndex = 18;
            this.Label_RecordNum.Text = "label1";
            this.Label_RecordNum.Visible = false;
            // 
            // Label_EntryTime_MIN
            // 
            this.Label_EntryTime_MIN.AutoSize = true;
            this.Label_EntryTime_MIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EntryTime_MIN.Location = new System.Drawing.Point(182, 287);
            this.Label_EntryTime_MIN.Name = "Label_EntryTime_MIN";
            this.Label_EntryTime_MIN.Size = new System.Drawing.Size(46, 17);
            this.Label_EntryTime_MIN.TabIndex = 19;
            this.Label_EntryTime_MIN.Text = "label1";
            this.Label_EntryTime_MIN.Visible = false;
            // 
            // Label_EntryTime_MAX
            // 
            this.Label_EntryTime_MAX.AutoSize = true;
            this.Label_EntryTime_MAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EntryTime_MAX.Location = new System.Drawing.Point(182, 327);
            this.Label_EntryTime_MAX.Name = "Label_EntryTime_MAX";
            this.Label_EntryTime_MAX.Size = new System.Drawing.Size(46, 17);
            this.Label_EntryTime_MAX.TabIndex = 20;
            this.Label_EntryTime_MAX.Text = "label1";
            this.Label_EntryTime_MAX.Visible = false;
            // 
            // Label_EntryTime_AVG
            // 
            this.Label_EntryTime_AVG.AutoSize = true;
            this.Label_EntryTime_AVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EntryTime_AVG.Location = new System.Drawing.Point(182, 367);
            this.Label_EntryTime_AVG.Name = "Label_EntryTime_AVG";
            this.Label_EntryTime_AVG.Size = new System.Drawing.Size(46, 17);
            this.Label_EntryTime_AVG.TabIndex = 21;
            this.Label_EntryTime_AVG.Text = "label1";
            this.Label_EntryTime_AVG.Visible = false;
            // 
            // Label_InterTime_MIN
            // 
            this.Label_InterTime_MIN.AutoSize = true;
            this.Label_InterTime_MIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InterTime_MIN.Location = new System.Drawing.Point(456, 287);
            this.Label_InterTime_MIN.Name = "Label_InterTime_MIN";
            this.Label_InterTime_MIN.Size = new System.Drawing.Size(46, 17);
            this.Label_InterTime_MIN.TabIndex = 22;
            this.Label_InterTime_MIN.Text = "label1";
            this.Label_InterTime_MIN.Visible = false;
            // 
            // Label_InterTime_MAX
            // 
            this.Label_InterTime_MAX.AutoSize = true;
            this.Label_InterTime_MAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InterTime_MAX.Location = new System.Drawing.Point(456, 327);
            this.Label_InterTime_MAX.Name = "Label_InterTime_MAX";
            this.Label_InterTime_MAX.Size = new System.Drawing.Size(46, 17);
            this.Label_InterTime_MAX.TabIndex = 23;
            this.Label_InterTime_MAX.Text = "label1";
            this.Label_InterTime_MAX.Visible = false;
            // 
            // Label_InterTime_AVG
            // 
            this.Label_InterTime_AVG.AutoSize = true;
            this.Label_InterTime_AVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_InterTime_AVG.Location = new System.Drawing.Point(456, 367);
            this.Label_InterTime_AVG.Name = "Label_InterTime_AVG";
            this.Label_InterTime_AVG.Size = new System.Drawing.Size(46, 17);
            this.Label_InterTime_AVG.TabIndex = 24;
            this.Label_InterTime_AVG.Text = "label1";
            this.Label_InterTime_AVG.Visible = false;
            // 
            // Label_TotalTime
            // 
            this.Label_TotalTime.AutoSize = true;
            this.Label_TotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalTime.Location = new System.Drawing.Point(695, 287);
            this.Label_TotalTime.Name = "Label_TotalTime";
            this.Label_TotalTime.Size = new System.Drawing.Size(46, 17);
            this.Label_TotalTime.TabIndex = 25;
            this.Label_TotalTime.Text = "label1";
            this.Label_TotalTime.Visible = false;
            // 
            // Label_BackspaceCount
            // 
            this.Label_BackspaceCount.AutoSize = true;
            this.Label_BackspaceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_BackspaceCount.Location = new System.Drawing.Point(695, 327);
            this.Label_BackspaceCount.Name = "Label_BackspaceCount";
            this.Label_BackspaceCount.Size = new System.Drawing.Size(46, 17);
            this.Label_BackspaceCount.TabIndex = 26;
            this.Label_BackspaceCount.Text = "label1";
            this.Label_BackspaceCount.Visible = false;
            // 
            // Label_NOTE_FileName_OUT
            // 
            this.Label_NOTE_FileName_OUT.AutoSize = true;
            this.Label_NOTE_FileName_OUT.Location = new System.Drawing.Point(31, 120);
            this.Label_NOTE_FileName_OUT.Name = "Label_NOTE_FileName_OUT";
            this.Label_NOTE_FileName_OUT.Size = new System.Drawing.Size(113, 13);
            this.Label_NOTE_FileName_OUT.TabIndex = 27;
            this.Label_NOTE_FileName_OUT.Text = "Name your output file: ";
            // 
            // Textbox_OutputFileName
            // 
            this.Textbox_OutputFileName.Location = new System.Drawing.Point(150, 117);
            this.Textbox_OutputFileName.Name = "Textbox_OutputFileName";
            this.Textbox_OutputFileName.Size = new System.Drawing.Size(112, 20);
            this.Textbox_OutputFileName.TabIndex = 28;
            this.Textbox_OutputFileName.TextChanged += new System.EventHandler(this.get_output_file_name);
            // 
            // RebateFormEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Textbox_OutputFileName);
            this.Controls.Add(this.Label_NOTE_FileName_OUT);
            this.Controls.Add(this.Label_BackspaceCount);
            this.Controls.Add(this.Label_TotalTime);
            this.Controls.Add(this.Label_InterTime_AVG);
            this.Controls.Add(this.Label_InterTime_MAX);
            this.Controls.Add(this.Label_InterTime_MIN);
            this.Controls.Add(this.Label_EntryTime_AVG);
            this.Controls.Add(this.Label_EntryTime_MAX);
            this.Controls.Add(this.Label_EntryTime_MIN);
            this.Controls.Add(this.Label_RecordNum);
            this.Controls.Add(this.Label_NOTE_BackspaceCount);
            this.Controls.Add(this.Label_NOTE_TotalTime);
            this.Controls.Add(this.Label_NOTE_AverageInterrecordTime);
            this.Controls.Add(this.Label_NOTE_MaximumInterrecordTime);
            this.Controls.Add(this.Label_NOTE_MinimumInterrecordTime);
            this.Controls.Add(this.Label_NOTE_AverageEntryTime);
            this.Controls.Add(this.Label_NOTE_MaximumEntryTime);
            this.Controls.Add(this.Label_NOTE_MinimumEntryTime);
            this.Controls.Add(this.Label_NOTE_NumberOfRecords);
            this.Controls.Add(this.Label_NOTE_Result);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.Label_NOTE_Dir_OUT);
            this.Controls.Add(this.Label_NOTE_Dir_IN);
            this.Controls.Add(this.Label_Filename_OUT);
            this.Controls.Add(this.Label_Dir_OUT);
            this.Controls.Add(this.Button_Dir_OUT);
            this.Controls.Add(this.Label_Dir_IN);
            this.Controls.Add(this.Button_Dir_IN);
            this.Name = "RebateFormEvaluation";
            this.Text = "RebateFormEvaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Dir_IN;
        private System.Windows.Forms.Label Label_Dir_IN;
        private System.Windows.Forms.Button Button_Dir_OUT;
        private System.Windows.Forms.Label Label_Dir_OUT;
        private System.Windows.Forms.Label Label_Filename_OUT;
        private System.Windows.Forms.Label Label_NOTE_Dir_IN;
        private System.Windows.Forms.Label Label_NOTE_Dir_OUT;
        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.Label Label_NOTE_Result;
        private System.Windows.Forms.Label Label_NOTE_NumberOfRecords;
        private System.Windows.Forms.Label Label_NOTE_MinimumEntryTime;
        private System.Windows.Forms.Label Label_NOTE_MaximumEntryTime;
        private System.Windows.Forms.Label Label_NOTE_AverageEntryTime;
        private System.Windows.Forms.Label Label_NOTE_MinimumInterrecordTime;
        private System.Windows.Forms.Label Label_NOTE_MaximumInterrecordTime;
        private System.Windows.Forms.Label Label_NOTE_AverageInterrecordTime;
        private System.Windows.Forms.Label Label_NOTE_TotalTime;
        private System.Windows.Forms.Label Label_NOTE_BackspaceCount;
        private System.Windows.Forms.Label Label_RecordNum;
        private System.Windows.Forms.Label Label_EntryTime_MIN;
        private System.Windows.Forms.Label Label_EntryTime_MAX;
        private System.Windows.Forms.Label Label_EntryTime_AVG;
        private System.Windows.Forms.Label Label_InterTime_MIN;
        private System.Windows.Forms.Label Label_InterTime_MAX;
        private System.Windows.Forms.Label Label_InterTime_AVG;
        private System.Windows.Forms.Label Label_TotalTime;
        private System.Windows.Forms.Label Label_BackspaceCount;
        private System.Windows.Forms.Label Label_NOTE_FileName_OUT;
        private System.Windows.Forms.TextBox Textbox_OutputFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

