namespace File_Data_Quality_Analyzer
{
    partial class Main_Form
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
            this.checkBox_AnalyzeLineNumber = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox_LineBeingAnalyzed = new System.Windows.Forms.TextBox();
            this.button_LoadLine = new System.Windows.Forms.Button();
            this.checkBox_AnalyzeFirstLine = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox_UseLogFile = new System.Windows.Forms.CheckBox();
            this.textBox_LogFile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Run = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.numericUpDown_AnalyzeLineNumber = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox_LineTermination = new System.Windows.Forms.TextBox();
            this.checkBox_CRLF = new System.Windows.Forms.CheckBox();
            this.checkBox_CROnly = new System.Windows.Forms.CheckBox();
            this.checkBox_LFOnly = new System.Windows.Forms.CheckBox();
            this.button_GetLineTermination = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox_LineLength = new System.Windows.Forms.TextBox();
            this.button_GetLineLength = new System.Windows.Forms.Button();
            this.textBox_InputFile = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox_Insert_Nulls = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_SelectOutputFile = new System.Windows.Forms.Button();
            this.textBox_OutputFile = new System.Windows.Forms.TextBox();
            this.checkBox_First = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_SelectInputFile = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkBox_Check_For_Nulls = new System.Windows.Forms.CheckBox();
            this.checkBox_CheckOnlyRow = new System.Windows.Forms.CheckBox();
            this.numericUpDown_StartFromRow = new System.Windows.Forms.NumericUpDown();
            this.checkBox_StartFromRow = new System.Windows.Forms.CheckBox();
            this.button_CheckLineTerminators = new System.Windows.Forms.Button();
            this.checkBox_IgnoreBlankLines = new System.Windows.Forms.CheckBox();
            this.checkBox_CheckForValidCharaters = new System.Windows.Forms.CheckBox();
            this.checkBox_CheckLineTerminators = new System.Windows.Forms.CheckBox();
            this.checkBox_CheckLineLengths = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ElapsedTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_RowsWritten = new System.Windows.Forms.TextBox();
            this.textBox_RowsScanned = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Row_Written = new System.Windows.Forms.Label();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_DoAllRecords = new System.Windows.Forms.CheckBox();
            this.checkBox_Last = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_NumberOfRecords = new System.Windows.Forms.NumericUpDown();
            this.checkBox_Random = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel_Log_Main = new System.Windows.Forms.Panel();
            this.textBox_Log = new System.Windows.Forms.TextBox();
            this.panel_Log_Bottom = new System.Windows.Forms.Panel();
            this.button_Copy_To_Clipboard = new System.Windows.Forms.Button();
            this.button_Clear_Log = new System.Windows.Forms.Button();
            this.button_Save_Log = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox_Check_Pipe_Symbols_Per_Row = new System.Windows.Forms.CheckBox();
            this.button_Check_Pipe_Symbols = new System.Windows.Forms.Button();
            this.groupBox8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AnalyzeLineNumber)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StartFromRow)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfRecords)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel_Log_Main.SuspendLayout();
            this.panel_Log_Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_AnalyzeLineNumber
            // 
            this.checkBox_AnalyzeLineNumber.AutoSize = true;
            this.checkBox_AnalyzeLineNumber.Location = new System.Drawing.Point(19, 42);
            this.checkBox_AnalyzeLineNumber.Name = "checkBox_AnalyzeLineNumber";
            this.checkBox_AnalyzeLineNumber.Size = new System.Drawing.Size(129, 17);
            this.checkBox_AnalyzeLineNumber.TabIndex = 5;
            this.checkBox_AnalyzeLineNumber.Text = "Analyze Line Number:";
            this.checkBox_AnalyzeLineNumber.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzeLineNumber.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzeLineNumber_CheckedChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.textBox_LineBeingAnalyzed);
            this.groupBox8.Location = new System.Drawing.Point(19, 211);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(545, 295);
            this.groupBox8.TabIndex = 4;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Sample Line Being Analyzed";
            // 
            // textBox_LineBeingAnalyzed
            // 
            this.textBox_LineBeingAnalyzed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LineBeingAnalyzed.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_LineBeingAnalyzed.Location = new System.Drawing.Point(19, 19);
            this.textBox_LineBeingAnalyzed.Multiline = true;
            this.textBox_LineBeingAnalyzed.Name = "textBox_LineBeingAnalyzed";
            this.textBox_LineBeingAnalyzed.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_LineBeingAnalyzed.Size = new System.Drawing.Size(508, 258);
            this.textBox_LineBeingAnalyzed.TabIndex = 0;
            // 
            // button_LoadLine
            // 
            this.button_LoadLine.Location = new System.Drawing.Point(381, 182);
            this.button_LoadLine.Name = "button_LoadLine";
            this.button_LoadLine.Size = new System.Drawing.Size(162, 23);
            this.button_LoadLine.TabIndex = 1;
            this.button_LoadLine.Text = "Load Line";
            this.button_LoadLine.UseVisualStyleBackColor = true;
            this.button_LoadLine.Click += new System.EventHandler(this.button_LoadLine_Click_1);
            // 
            // checkBox_AnalyzeFirstLine
            // 
            this.checkBox_AnalyzeFirstLine.AutoSize = true;
            this.checkBox_AnalyzeFirstLine.Checked = true;
            this.checkBox_AnalyzeFirstLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_AnalyzeFirstLine.Location = new System.Drawing.Point(19, 19);
            this.checkBox_AnalyzeFirstLine.Name = "checkBox_AnalyzeFirstLine";
            this.checkBox_AnalyzeFirstLine.Size = new System.Drawing.Size(108, 17);
            this.checkBox_AnalyzeFirstLine.TabIndex = 3;
            this.checkBox_AnalyzeFirstLine.Text = "Analyze First Line";
            this.checkBox_AnalyzeFirstLine.UseVisualStyleBackColor = true;
            this.checkBox_AnalyzeFirstLine.CheckedChanged += new System.EventHandler(this.checkBox_AnalyzeFirstLine_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox_UseLogFile);
            this.tabPage3.Controls.Add(this.textBox_LogFile);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(580, 528);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox_UseLogFile
            // 
            this.checkBox_UseLogFile.AutoSize = true;
            this.checkBox_UseLogFile.Checked = true;
            this.checkBox_UseLogFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_UseLogFile.Location = new System.Drawing.Point(35, 32);
            this.checkBox_UseLogFile.Name = "checkBox_UseLogFile";
            this.checkBox_UseLogFile.Size = new System.Drawing.Size(190, 17);
            this.checkBox_UseLogFile.TabIndex = 2;
            this.checkBox_UseLogFile.Text = "Write Status and Errors to Log File.";
            this.checkBox_UseLogFile.UseVisualStyleBackColor = true;
            // 
            // textBox_LogFile
            // 
            this.textBox_LogFile.Location = new System.Drawing.Point(85, 55);
            this.textBox_LogFile.Name = "textBox_LogFile";
            this.textBox_LogFile.Size = new System.Drawing.Size(448, 20);
            this.textBox_LogFile.TabIndex = 1;
            this.textBox_LogFile.Text = ".\\LogFile.txt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Log File:";
            // 
            // button_Run
            // 
            this.button_Run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Run.Location = new System.Drawing.Point(215, 637);
            this.button_Run.Name = "button_Run";
            this.button_Run.Size = new System.Drawing.Size(75, 23);
            this.button_Run.TabIndex = 26;
            this.button_Run.Text = "Run";
            this.button_Run.UseVisualStyleBackColor = true;
            this.button_Run.Click += new System.EventHandler(this.button_Run_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.Location = new System.Drawing.Point(499, 637);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 27;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // numericUpDown_AnalyzeLineNumber
            // 
            this.numericUpDown_AnalyzeLineNumber.Enabled = false;
            this.numericUpDown_AnalyzeLineNumber.Location = new System.Drawing.Point(62, 63);
            this.numericUpDown_AnalyzeLineNumber.Name = "numericUpDown_AnalyzeLineNumber";
            this.numericUpDown_AnalyzeLineNumber.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown_AnalyzeLineNumber.TabIndex = 6;
            this.numericUpDown_AnalyzeLineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_AnalyzeLineNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_LoadLine);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(580, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Analyze";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkBox_AnalyzeFirstLine);
            this.groupBox10.Controls.Add(this.numericUpDown_AnalyzeLineNumber);
            this.groupBox10.Controls.Add(this.checkBox_AnalyzeLineNumber);
            this.groupBox10.Location = new System.Drawing.Point(362, 39);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(200, 100);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Line Options";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox_LineTermination);
            this.groupBox7.Controls.Add(this.checkBox_CRLF);
            this.groupBox7.Controls.Add(this.checkBox_CROnly);
            this.groupBox7.Controls.Add(this.checkBox_LFOnly);
            this.groupBox7.Controls.Add(this.button_GetLineTermination);
            this.groupBox7.Location = new System.Drawing.Point(19, 97);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(313, 99);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Line Termination";
            // 
            // textBox_LineTermination
            // 
            this.textBox_LineTermination.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_LineTermination.Location = new System.Drawing.Point(205, 62);
            this.textBox_LineTermination.Name = "textBox_LineTermination";
            this.textBox_LineTermination.ReadOnly = true;
            this.textBox_LineTermination.Size = new System.Drawing.Size(78, 20);
            this.textBox_LineTermination.TabIndex = 4;
            this.textBox_LineTermination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_CRLF
            // 
            this.checkBox_CRLF.AutoSize = true;
            this.checkBox_CRLF.Enabled = false;
            this.checkBox_CRLF.Location = new System.Drawing.Point(28, 65);
            this.checkBox_CRLF.Name = "checkBox_CRLF";
            this.checkBox_CRLF.Size = new System.Drawing.Size(76, 17);
            this.checkBox_CRLF.TabIndex = 3;
            this.checkBox_CRLF.Text = "CRLF - PC";
            this.checkBox_CRLF.UseVisualStyleBackColor = true;
            // 
            // checkBox_CROnly
            // 
            this.checkBox_CROnly.AutoSize = true;
            this.checkBox_CROnly.Enabled = false;
            this.checkBox_CROnly.Location = new System.Drawing.Point(28, 42);
            this.checkBox_CROnly.Name = "checkBox_CROnly";
            this.checkBox_CROnly.Size = new System.Drawing.Size(124, 17);
            this.checkBox_CROnly.TabIndex = 2;
            this.checkBox_CROnly.Text = "CR Only - MacIntosh";
            this.checkBox_CROnly.UseVisualStyleBackColor = true;
            // 
            // checkBox_LFOnly
            // 
            this.checkBox_LFOnly.AutoSize = true;
            this.checkBox_LFOnly.Enabled = false;
            this.checkBox_LFOnly.Location = new System.Drawing.Point(28, 19);
            this.checkBox_LFOnly.Name = "checkBox_LFOnly";
            this.checkBox_LFOnly.Size = new System.Drawing.Size(92, 17);
            this.checkBox_LFOnly.TabIndex = 1;
            this.checkBox_LFOnly.Text = "LF Only - Unix";
            this.checkBox_LFOnly.UseVisualStyleBackColor = true;
            // 
            // button_GetLineTermination
            // 
            this.button_GetLineTermination.Location = new System.Drawing.Point(189, 19);
            this.button_GetLineTermination.Name = "button_GetLineTermination";
            this.button_GetLineTermination.Size = new System.Drawing.Size(114, 23);
            this.button_GetLineTermination.TabIndex = 0;
            this.button_GetLineTermination.Text = "Get Line Termination";
            this.button_GetLineTermination.UseVisualStyleBackColor = true;
            this.button_GetLineTermination.Click += new System.EventHandler(this.button_GetLineTermination_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox_LineLength);
            this.groupBox6.Controls.Add(this.button_GetLineLength);
            this.groupBox6.Location = new System.Drawing.Point(19, 36);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(313, 55);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Line Length";
            // 
            // textBox_LineLength
            // 
            this.textBox_LineLength.Location = new System.Drawing.Point(19, 19);
            this.textBox_LineLength.Name = "textBox_LineLength";
            this.textBox_LineLength.Size = new System.Drawing.Size(119, 20);
            this.textBox_LineLength.TabIndex = 1;
            // 
            // button_GetLineLength
            // 
            this.button_GetLineLength.Location = new System.Drawing.Point(189, 19);
            this.button_GetLineLength.Name = "button_GetLineLength";
            this.button_GetLineLength.Size = new System.Drawing.Size(114, 23);
            this.button_GetLineLength.TabIndex = 0;
            this.button_GetLineLength.Text = "Get Line Length";
            this.button_GetLineLength.UseVisualStyleBackColor = true;
            this.button_GetLineLength.Click += new System.EventHandler(this.button_GetLineLength_Click_1);
            // 
            // textBox_InputFile
            // 
            this.textBox_InputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_InputFile.Location = new System.Drawing.Point(6, 19);
            this.textBox_InputFile.Multiline = true;
            this.textBox_InputFile.Name = "textBox_InputFile";
            this.textBox_InputFile.Size = new System.Drawing.Size(464, 23);
            this.textBox_InputFile.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox_Insert_Nulls);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(580, 528);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Debug";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox_Insert_Nulls
            // 
            this.checkBox_Insert_Nulls.AutoSize = true;
            this.checkBox_Insert_Nulls.Location = new System.Drawing.Point(93, 98);
            this.checkBox_Insert_Nulls.Name = "checkBox_Insert_Nulls";
            this.checkBox_Insert_Nulls.Size = new System.Drawing.Size(124, 17);
            this.checkBox_Insert_Nulls.TabIndex = 27;
            this.checkBox_Insert_Nulls.Text = "Insert Nulls in Output";
            this.checkBox_Insert_Nulls.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_SelectOutputFile);
            this.groupBox2.Controls.Add(this.textBox_OutputFile);
            this.groupBox2.Location = new System.Drawing.Point(13, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 51);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Sample File";
            // 
            // button_SelectOutputFile
            // 
            this.button_SelectOutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SelectOutputFile.Location = new System.Drawing.Point(477, 18);
            this.button_SelectOutputFile.Name = "button_SelectOutputFile";
            this.button_SelectOutputFile.Size = new System.Drawing.Size(75, 23);
            this.button_SelectOutputFile.TabIndex = 25;
            this.button_SelectOutputFile.Text = "Select File";
            this.button_SelectOutputFile.UseVisualStyleBackColor = true;
            // 
            // textBox_OutputFile
            // 
            this.textBox_OutputFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_OutputFile.Enabled = false;
            this.textBox_OutputFile.Location = new System.Drawing.Point(6, 18);
            this.textBox_OutputFile.Multiline = true;
            this.textBox_OutputFile.Name = "textBox_OutputFile";
            this.textBox_OutputFile.Size = new System.Drawing.Size(465, 24);
            this.textBox_OutputFile.TabIndex = 18;
            // 
            // checkBox_First
            // 
            this.checkBox_First.AutoSize = true;
            this.checkBox_First.Location = new System.Drawing.Point(24, 42);
            this.checkBox_First.Name = "checkBox_First";
            this.checkBox_First.Size = new System.Drawing.Size(130, 17);
            this.checkBox_First.TabIndex = 0;
            this.checkBox_First.Text = "Take First N Records:";
            this.checkBox_First.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_SelectInputFile);
            this.groupBox1.Controls.Add(this.textBox_InputFile);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 53);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input File";
            // 
            // button_SelectInputFile
            // 
            this.button_SelectInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SelectInputFile.Location = new System.Drawing.Point(476, 19);
            this.button_SelectInputFile.Name = "button_SelectInputFile";
            this.button_SelectInputFile.Size = new System.Drawing.Size(75, 23);
            this.button_SelectInputFile.TabIndex = 17;
            this.button_SelectInputFile.Text = "Select File";
            this.button_SelectInputFile.UseVisualStyleBackColor = true;
            this.button_SelectInputFile.Click += new System.EventHandler(this.button_SelectInputFile_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_Check_Pipe_Symbols);
            this.tabPage1.Controls.Add(this.checkBox_Check_Pipe_Symbols_Per_Row);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.button_Run);
            this.tabPage1.Controls.Add(this.button_Exit);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(580, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkBox_Check_For_Nulls);
            this.groupBox9.Controls.Add(this.checkBox_CheckOnlyRow);
            this.groupBox9.Controls.Add(this.numericUpDown_StartFromRow);
            this.groupBox9.Controls.Add(this.checkBox_StartFromRow);
            this.groupBox9.Controls.Add(this.button_CheckLineTerminators);
            this.groupBox9.Controls.Add(this.checkBox_IgnoreBlankLines);
            this.groupBox9.Controls.Add(this.checkBox_CheckForValidCharaters);
            this.groupBox9.Controls.Add(this.checkBox_CheckLineTerminators);
            this.groupBox9.Controls.Add(this.checkBox_CheckLineLengths);
            this.groupBox9.Location = new System.Drawing.Point(296, 65);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(273, 180);
            this.groupBox9.TabIndex = 31;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data Checks";
            // 
            // checkBox_Check_For_Nulls
            // 
            this.checkBox_Check_For_Nulls.AutoSize = true;
            this.checkBox_Check_For_Nulls.Checked = true;
            this.checkBox_Check_For_Nulls.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Check_For_Nulls.Location = new System.Drawing.Point(11, 88);
            this.checkBox_Check_For_Nulls.Name = "checkBox_Check_For_Nulls";
            this.checkBox_Check_For_Nulls.Size = new System.Drawing.Size(121, 17);
            this.checkBox_Check_For_Nulls.TabIndex = 42;
            this.checkBox_Check_For_Nulls.Text = "Check Line for Nulls";
            this.checkBox_Check_For_Nulls.UseVisualStyleBackColor = true;
            this.checkBox_Check_For_Nulls.CheckedChanged += new System.EventHandler(this.checkBox_Check_For_Nulls_CheckedChanged);
            // 
            // checkBox_CheckOnlyRow
            // 
            this.checkBox_CheckOnlyRow.AutoSize = true;
            this.checkBox_CheckOnlyRow.Location = new System.Drawing.Point(37, 157);
            this.checkBox_CheckOnlyRow.Name = "checkBox_CheckOnlyRow";
            this.checkBox_CheckOnlyRow.Size = new System.Drawing.Size(109, 17);
            this.checkBox_CheckOnlyRow.TabIndex = 41;
            this.checkBox_CheckOnlyRow.Text = "Check Only Row:";
            this.checkBox_CheckOnlyRow.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_StartFromRow
            // 
            this.numericUpDown_StartFromRow.Location = new System.Drawing.Point(152, 140);
            this.numericUpDown_StartFromRow.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_StartFromRow.Name = "numericUpDown_StartFromRow";
            this.numericUpDown_StartFromRow.Size = new System.Drawing.Size(105, 20);
            this.numericUpDown_StartFromRow.TabIndex = 40;
            this.numericUpDown_StartFromRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_StartFromRow.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox_StartFromRow
            // 
            this.checkBox_StartFromRow.AutoSize = true;
            this.checkBox_StartFromRow.Location = new System.Drawing.Point(37, 139);
            this.checkBox_StartFromRow.Name = "checkBox_StartFromRow";
            this.checkBox_StartFromRow.Size = new System.Drawing.Size(102, 17);
            this.checkBox_StartFromRow.TabIndex = 39;
            this.checkBox_StartFromRow.Text = "Start From Row:";
            this.checkBox_StartFromRow.UseVisualStyleBackColor = true;
            // 
            // button_CheckLineTerminators
            // 
            this.button_CheckLineTerminators.Location = new System.Drawing.Point(172, 55);
            this.button_CheckLineTerminators.Name = "button_CheckLineTerminators";
            this.button_CheckLineTerminators.Size = new System.Drawing.Size(81, 35);
            this.button_CheckLineTerminators.TabIndex = 38;
            this.button_CheckLineTerminators.Text = "Check Line Terminators";
            this.button_CheckLineTerminators.UseVisualStyleBackColor = true;
            this.button_CheckLineTerminators.Click += new System.EventHandler(this.button_CheckLineTerminators_Click);
            // 
            // checkBox_IgnoreBlankLines
            // 
            this.checkBox_IgnoreBlankLines.AutoSize = true;
            this.checkBox_IgnoreBlankLines.Location = new System.Drawing.Point(37, 42);
            this.checkBox_IgnoreBlankLines.Name = "checkBox_IgnoreBlankLines";
            this.checkBox_IgnoreBlankLines.Size = new System.Drawing.Size(112, 17);
            this.checkBox_IgnoreBlankLines.TabIndex = 37;
            this.checkBox_IgnoreBlankLines.Text = "Ignore blank lines.";
            this.checkBox_IgnoreBlankLines.UseVisualStyleBackColor = true;
            // 
            // checkBox_CheckForValidCharaters
            // 
            this.checkBox_CheckForValidCharaters.AutoSize = true;
            this.checkBox_CheckForValidCharaters.Checked = true;
            this.checkBox_CheckForValidCharaters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CheckForValidCharaters.Location = new System.Drawing.Point(11, 111);
            this.checkBox_CheckForValidCharaters.Name = "checkBox_CheckForValidCharaters";
            this.checkBox_CheckForValidCharaters.Size = new System.Drawing.Size(155, 17);
            this.checkBox_CheckForValidCharaters.TabIndex = 36;
            this.checkBox_CheckForValidCharaters.Text = "Check For Valid Characters";
            this.checkBox_CheckForValidCharaters.UseVisualStyleBackColor = true;
            // 
            // checkBox_CheckLineTerminators
            // 
            this.checkBox_CheckLineTerminators.AutoSize = true;
            this.checkBox_CheckLineTerminators.Checked = true;
            this.checkBox_CheckLineTerminators.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_CheckLineTerminators.Location = new System.Drawing.Point(11, 65);
            this.checkBox_CheckLineTerminators.Name = "checkBox_CheckLineTerminators";
            this.checkBox_CheckLineTerminators.Size = new System.Drawing.Size(138, 17);
            this.checkBox_CheckLineTerminators.TabIndex = 35;
            this.checkBox_CheckLineTerminators.Text = "Check Line Terminators";
            this.checkBox_CheckLineTerminators.UseVisualStyleBackColor = true;
            // 
            // checkBox_CheckLineLengths
            // 
            this.checkBox_CheckLineLengths.AutoSize = true;
            this.checkBox_CheckLineLengths.Location = new System.Drawing.Point(11, 19);
            this.checkBox_CheckLineLengths.Name = "checkBox_CheckLineLengths";
            this.checkBox_CheckLineLengths.Size = new System.Drawing.Size(239, 17);
            this.checkBox_CheckLineLengths.TabIndex = 34;
            this.checkBox_CheckLineLengths.Text = "Check Line Lengths (Fixed Length Files Only)";
            this.checkBox_CheckLineLengths.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_ElapsedTime);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_RowsWritten);
            this.groupBox3.Controls.Add(this.textBox_RowsScanned);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label_Row_Written);
            this.groupBox3.Controls.Add(this.textBox_Status);
            this.groupBox3.Location = new System.Drawing.Point(11, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 331);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Secs.";
            // 
            // textBox_ElapsedTime
            // 
            this.textBox_ElapsedTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_ElapsedTime.Location = new System.Drawing.Point(457, 13);
            this.textBox_ElapsedTime.Name = "textBox_ElapsedTime";
            this.textBox_ElapsedTime.ReadOnly = true;
            this.textBox_ElapsedTime.Size = new System.Drawing.Size(57, 20);
            this.textBox_ElapsedTime.TabIndex = 28;
            this.textBox_ElapsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Elapsed Time:";
            // 
            // textBox_RowsWritten
            // 
            this.textBox_RowsWritten.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_RowsWritten.Location = new System.Drawing.Point(285, 13);
            this.textBox_RowsWritten.Name = "textBox_RowsWritten";
            this.textBox_RowsWritten.ReadOnly = true;
            this.textBox_RowsWritten.Size = new System.Drawing.Size(78, 20);
            this.textBox_RowsWritten.TabIndex = 26;
            this.textBox_RowsWritten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_RowsWritten.Visible = false;
            // 
            // textBox_RowsScanned
            // 
            this.textBox_RowsScanned.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_RowsScanned.Location = new System.Drawing.Point(111, 13);
            this.textBox_RowsScanned.Name = "textBox_RowsScanned";
            this.textBox_RowsScanned.ReadOnly = true;
            this.textBox_RowsScanned.Size = new System.Drawing.Size(80, 20);
            this.textBox_RowsScanned.TabIndex = 25;
            this.textBox_RowsScanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Rows Scanned:";
            // 
            // label_Row_Written
            // 
            this.label_Row_Written.AutoSize = true;
            this.label_Row_Written.Location = new System.Drawing.Point(205, 16);
            this.label_Row_Written.Name = "label_Row_Written";
            this.label_Row_Written.Size = new System.Drawing.Size(74, 13);
            this.label_Row_Written.TabIndex = 23;
            this.label_Row_Written.Text = "Rows Written:";
            this.label_Row_Written.Visible = false;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Status.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Status.Location = new System.Drawing.Point(6, 45);
            this.textBox_Status.Multiline = true;
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Status.Size = new System.Drawing.Size(546, 280);
            this.textBox_Status.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_DoAllRecords);
            this.groupBox4.Controls.Add(this.checkBox_Last);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.checkBox_Random);
            this.groupBox4.Controls.Add(this.checkBox_First);
            this.groupBox4.Location = new System.Drawing.Point(12, 65);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 180);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // checkBox_DoAllRecords
            // 
            this.checkBox_DoAllRecords.AutoSize = true;
            this.checkBox_DoAllRecords.Checked = true;
            this.checkBox_DoAllRecords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DoAllRecords.Location = new System.Drawing.Point(24, 19);
            this.checkBox_DoAllRecords.Name = "checkBox_DoAllRecords";
            this.checkBox_DoAllRecords.Size = new System.Drawing.Size(127, 17);
            this.checkBox_DoAllRecords.TabIndex = 5;
            this.checkBox_DoAllRecords.Text = "Do All Records in File";
            this.checkBox_DoAllRecords.UseVisualStyleBackColor = true;
            // 
            // checkBox_Last
            // 
            this.checkBox_Last.AutoSize = true;
            this.checkBox_Last.Location = new System.Drawing.Point(24, 65);
            this.checkBox_Last.Name = "checkBox_Last";
            this.checkBox_Last.Size = new System.Drawing.Size(131, 17);
            this.checkBox_Last.TabIndex = 4;
            this.checkBox_Last.Text = "Take Last N Records:";
            this.checkBox_Last.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown_NumberOfRecords);
            this.groupBox5.Location = new System.Drawing.Point(24, 111);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(137, 45);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "N Record Setting";
            // 
            // numericUpDown_NumberOfRecords
            // 
            this.numericUpDown_NumberOfRecords.Location = new System.Drawing.Point(6, 19);
            this.numericUpDown_NumberOfRecords.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_NumberOfRecords.Name = "numericUpDown_NumberOfRecords";
            this.numericUpDown_NumberOfRecords.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_NumberOfRecords.TabIndex = 1;
            this.numericUpDown_NumberOfRecords.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_NumberOfRecords.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBox_Random
            // 
            this.checkBox_Random.AutoSize = true;
            this.checkBox_Random.Location = new System.Drawing.Point(24, 88);
            this.checkBox_Random.Name = "checkBox_Random";
            this.checkBox_Random.Size = new System.Drawing.Size(218, 17);
            this.checkBox_Random.TabIndex = 2;
            this.checkBox_Random.Text = "Take a Random Sampling of N Records:";
            this.checkBox_Random.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(588, 692);
            this.tabControl1.TabIndex = 103;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel_Log_Main);
            this.tabPage5.Controls.Add(this.panel_Log_Bottom);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(580, 528);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Log";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel_Log_Main
            // 
            this.panel_Log_Main.Controls.Add(this.textBox_Log);
            this.panel_Log_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Log_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Log_Main.Name = "panel_Log_Main";
            this.panel_Log_Main.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Log_Main.Size = new System.Drawing.Size(580, 495);
            this.panel_Log_Main.TabIndex = 27;
            // 
            // textBox_Log
            // 
            this.textBox_Log.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Log.Location = new System.Drawing.Point(5, 5);
            this.textBox_Log.Multiline = true;
            this.textBox_Log.Name = "textBox_Log";
            this.textBox_Log.ReadOnly = true;
            this.textBox_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Log.Size = new System.Drawing.Size(570, 485);
            this.textBox_Log.TabIndex = 23;
            // 
            // panel_Log_Bottom
            // 
            this.panel_Log_Bottom.Controls.Add(this.button_Copy_To_Clipboard);
            this.panel_Log_Bottom.Controls.Add(this.button_Clear_Log);
            this.panel_Log_Bottom.Controls.Add(this.button_Save_Log);
            this.panel_Log_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Log_Bottom.Location = new System.Drawing.Point(0, 495);
            this.panel_Log_Bottom.Name = "panel_Log_Bottom";
            this.panel_Log_Bottom.Size = new System.Drawing.Size(580, 33);
            this.panel_Log_Bottom.TabIndex = 26;
            // 
            // button_Copy_To_Clipboard
            // 
            this.button_Copy_To_Clipboard.Location = new System.Drawing.Point(313, 6);
            this.button_Copy_To_Clipboard.Name = "button_Copy_To_Clipboard";
            this.button_Copy_To_Clipboard.Size = new System.Drawing.Size(108, 23);
            this.button_Copy_To_Clipboard.TabIndex = 26;
            this.button_Copy_To_Clipboard.Text = "Copy To Clipboard";
            this.button_Copy_To_Clipboard.UseVisualStyleBackColor = true;
            this.button_Copy_To_Clipboard.Click += new System.EventHandler(this.button_Copy_To_Clipboard_Click);
            // 
            // button_Clear_Log
            // 
            this.button_Clear_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear_Log.Location = new System.Drawing.Point(485, 7);
            this.button_Clear_Log.Name = "button_Clear_Log";
            this.button_Clear_Log.Size = new System.Drawing.Size(75, 23);
            this.button_Clear_Log.TabIndex = 24;
            this.button_Clear_Log.Text = "Clear Log";
            this.button_Clear_Log.UseVisualStyleBackColor = true;
            this.button_Clear_Log.Click += new System.EventHandler(this.button_Clear_Log_Click);
            // 
            // button_Save_Log
            // 
            this.button_Save_Log.Location = new System.Drawing.Point(219, 6);
            this.button_Save_Log.Name = "button_Save_Log";
            this.button_Save_Log.Size = new System.Drawing.Size(75, 23);
            this.button_Save_Log.TabIndex = 25;
            this.button_Save_Log.Text = "Save Log";
            this.button_Save_Log.UseVisualStyleBackColor = true;
            this.button_Save_Log.Click += new System.EventHandler(this.button_Save_Log_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.HideSelection = false;
            this.textBox3.Location = new System.Drawing.Point(12, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(587, 46);
            this.textBox3.TabIndex = 200;
            this.textBox3.Text = "File Data Quality Analyzer - Scans a file before data import for illegal characte" +
    "rs that will cause problems in the data import process.  Version 1.0 Grant Ander" +
    "son 7/20/06";
            // 
            // checkBox_Check_Pipe_Symbols_Per_Row
            // 
            this.checkBox_Check_Pipe_Symbols_Per_Row.AutoSize = true;
            this.checkBox_Check_Pipe_Symbols_Per_Row.Checked = true;
            this.checkBox_Check_Pipe_Symbols_Per_Row.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Check_Pipe_Symbols_Per_Row.Location = new System.Drawing.Point(61, 264);
            this.checkBox_Check_Pipe_Symbols_Per_Row.Name = "checkBox_Check_Pipe_Symbols_Per_Row";
            this.checkBox_Check_Pipe_Symbols_Per_Row.Size = new System.Drawing.Size(167, 17);
            this.checkBox_Check_Pipe_Symbols_Per_Row.TabIndex = 32;
            this.checkBox_Check_Pipe_Symbols_Per_Row.Text = "Check Pipe Symbols Per Row";
            this.checkBox_Check_Pipe_Symbols_Per_Row.UseVisualStyleBackColor = true;
            this.checkBox_Check_Pipe_Symbols_Per_Row.CheckedChanged += new System.EventHandler(this.checkBox_Check_Pipe_Symbols_Per_Row_CheckedChanged);
            // 
            // button_Check_Pipe_Symbols
            // 
            this.button_Check_Pipe_Symbols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Check_Pipe_Symbols.Location = new System.Drawing.Point(244, 260);
            this.button_Check_Pipe_Symbols.Name = "button_Check_Pipe_Symbols";
            this.button_Check_Pipe_Symbols.Size = new System.Drawing.Size(130, 23);
            this.button_Check_Pipe_Symbols.TabIndex = 33;
            this.button_Check_Pipe_Symbols.Text = "Check Pipe Symbols";
            this.button_Check_Pipe_Symbols.UseVisualStyleBackColor = true;
            this.button_Check_Pipe_Symbols.Click += new System.EventHandler(this.button_Check_Pipe_Symbols_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 768);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox3);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Data Quality Analyzer";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_AnalyzeLineNumber)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_StartFromRow)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfRecords)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel_Log_Main.ResumeLayout(false);
            this.panel_Log_Main.PerformLayout();
            this.panel_Log_Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.CheckBox checkBox_AnalyzeLineNumber;
      private System.Windows.Forms.GroupBox groupBox8;
      private System.Windows.Forms.Button button_LoadLine;
      private System.Windows.Forms.TextBox textBox_LineBeingAnalyzed;
      private System.Windows.Forms.CheckBox checkBox_AnalyzeFirstLine;
      private System.Windows.Forms.TabPage tabPage3;
      private System.Windows.Forms.Button button_Run;
      private System.Windows.Forms.Button button_Exit;
      private System.Windows.Forms.NumericUpDown numericUpDown_AnalyzeLineNumber;
      private System.Windows.Forms.TabPage tabPage2;
      private System.Windows.Forms.GroupBox groupBox7;
      private System.Windows.Forms.CheckBox checkBox_CRLF;
      private System.Windows.Forms.CheckBox checkBox_CROnly;
      private System.Windows.Forms.CheckBox checkBox_LFOnly;
      private System.Windows.Forms.Button button_GetLineTermination;
      private System.Windows.Forms.GroupBox groupBox6;
      private System.Windows.Forms.TextBox textBox_LineLength;
      private System.Windows.Forms.Button button_GetLineLength;
      private System.Windows.Forms.TextBox textBox_InputFile;
      private System.Windows.Forms.TabPage tabPage4;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TextBox textBox_OutputFile;
      private System.Windows.Forms.CheckBox checkBox_First;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.TextBox textBox_RowsWritten;
      private System.Windows.Forms.TextBox textBox_RowsScanned;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label_Row_Written;
      private System.Windows.Forms.TextBox textBox_Status;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.CheckBox checkBox_Last;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfRecords;
      private System.Windows.Forms.CheckBox checkBox_Random;
      private System.Windows.Forms.TabControl tabControl1;
      private System.Windows.Forms.TextBox textBox3;
      private System.Windows.Forms.Button button_SelectOutputFile;
      private System.Windows.Forms.Button button_SelectInputFile;
      private System.Windows.Forms.TextBox textBox_LineTermination;
      private System.Windows.Forms.GroupBox groupBox9;
      private System.Windows.Forms.CheckBox checkBox_CheckForValidCharaters;
      private System.Windows.Forms.CheckBox checkBox_CheckLineTerminators;
      private System.Windows.Forms.CheckBox checkBox_CheckLineLengths;
      private System.Windows.Forms.CheckBox checkBox_DoAllRecords;
      private System.Windows.Forms.CheckBox checkBox_IgnoreBlankLines;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox textBox_ElapsedTime;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button button_CheckLineTerminators;
      private System.Windows.Forms.CheckBox checkBox_CheckOnlyRow;
      private System.Windows.Forms.NumericUpDown numericUpDown_StartFromRow;
      private System.Windows.Forms.CheckBox checkBox_StartFromRow;
      private System.Windows.Forms.TextBox textBox_LogFile;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.CheckBox checkBox_UseLogFile;
      private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.Panel panel_Log_Bottom;
		private System.Windows.Forms.Button button_Clear_Log;
		private System.Windows.Forms.Button button_Save_Log;
		private System.Windows.Forms.TextBox textBox_Log;
		private System.Windows.Forms.Panel panel_Log_Main;
		private System.Windows.Forms.Button button_Copy_To_Clipboard;
		private System.Windows.Forms.CheckBox checkBox_Insert_Nulls;
		private System.Windows.Forms.CheckBox checkBox_Check_For_Nulls;
        private System.Windows.Forms.Button button_Check_Pipe_Symbols;
        private System.Windows.Forms.CheckBox checkBox_Check_Pipe_Symbols_Per_Row;
   }
}