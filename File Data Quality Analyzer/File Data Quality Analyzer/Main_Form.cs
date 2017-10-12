// Standard usings
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


// Extra usings.
using System.IO;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;


namespace File_Data_Quality_Analyzer
{
   public partial class Main_Form : Form
   {
   
      // Globals.
      StreamReader sr;
      FileStream fs;
      
      string FileName;
      
      int RowNumber;
      string currentRecord;
      char LastCharacterPlusTwo;
      char LastCharacterPlusOne;
      
      int Sample_LineLength;
      string Sample_Terminator_Type;     
      
      DateTime StartTime;
      DateTime StopTime;
      TimeSpan ElapsedTime;

      Int64 LinesScanned = 0;
      Int64 LinesWritten = 0;
      Int32 LinesToSample = 0;  
      
      Int32 TotalTerminatorErrors = 0;

      StreamWriter w;

      int pipe_Symbol_Count = 0;


      //public Main_Form(string filename)
          public Main_Form()
      {
         InitializeComponent();
         
         //FileName = filename;
   
         //if (filename == null)
         //{
         //   // Then we were NOT passed a filename.
            
         //}
         //else
         //{
         //   if (File.Exists(FileName))
         //   {
         //      textBox_InputFile.Text = FileName;
         //   }
         //   else
         //   {
         //      MessageBox.Show("Cannot find the passed file name!  File name = " + FileName, "File Error!", MessageBoxButtons.OK);
         //   }
         //}
      }

      private void button_Exit_Click(object sender, EventArgs e)
      {
         // Exit the program.

         Application.Exit();
      }

      private void button_Run_Click(object sender, EventArgs e)
      {
         LinesScanned = 0;
         LinesWritten = 0;
         LinesToSample = 0;
			RowNumber = 0;
         
         textBox_RowsScanned.Clear();
         textBox_RowsWritten.Clear();
         textBox_ElapsedTime.Clear();

			textBox_Log.Clear();
      
         // First get the sample information for the file.
         Get_First_Line(1);
         Get_Sample_Line_Length();

         Get_First_Line_Binary();
         Check_For_Line_Terminators();
         
         // Now scan the file.
         Scan_File();
      }

      private void Scan_File()
      {
			bool writeOutputFile = false;

			if (string.IsNullOrEmpty(textBox_OutputFile.Text))
			{
				writeOutputFile = false;

				label_Row_Written.Visible = true;
				textBox_RowsWritten.Visible = true;
			}
			else
			{
				writeOutputFile = true;

				label_Row_Written.Visible = true;
				textBox_RowsWritten.Visible = true;
			}

         textBox_Status.Clear();

         if (textBox_OutputFile.Text.Length <= 0)
         {
            // To Do:  Add error handling code here for this exception.
         }

         // Get the input file path.
         string path;
         path = textBox_InputFile.Text.Trim();

         // Get the number of lines we're supposed to grab.
         LinesToSample = (int)numericUpDown_NumberOfRecords.Value;

			// Output file.

			//StreamWriter w = new StreamWriter(@"C:\x.txt");

			if (writeOutputFile == true)
			{
				//try
				//{
				//   w.Close();
				//}
				//catch (Exception ex)
				//{
				//   string errorString = ex.ToString();
				//}

				w = new StreamWriter(textBox_OutputFile.Text.Trim());
			}
         
         // Establish line processing limits.
         
         if (checkBox_DoAllRecords.Checked == true)
         {
         }

         Cursor.Current = Cursors.WaitCursor;

         StartTime = DateTime.Now;
         
         // Open the file.
         try
         {

            using (sr = File.OpenText(path))
            {
               string s = "";
               int maxLines = 0;
               
               // File scan loop.
               while ((s = sr.ReadLine()) != null)
               {

                  RowNumber++;

                  if (checkBox_DoAllRecords.Checked == true)
                  {
                     // Do all lines in the file.
                     maxLines = 0;
                  }

                  if (checkBox_First.Checked == true)
                  {
                     // Do just the first N lines in the file.
                     maxLines = (int)numericUpDown_NumberOfRecords.Value;
                  }                
    
                  /////////////////////////////////////////////////////////////////
                  // Do the checks.
                  /////////////////////////////////////////////////////////////////
                  
                  if (checkBox_CheckLineLengths.Checked == true)
                  {
                     Check_Line_Lengths(s);
                  }

                  if (checkBox_CheckLineTerminators.Checked == true)
                  {
                     Check_Line_Terminators(s);
                  }

                  if (checkBox_CheckForValidCharaters.Checked == true)
                  {
                     Check_Line_Characters(s);
                  }

				  if (checkBox_Check_For_Nulls.Checked == true)
                  {
                     Check_For_Nulls(s);
                  } 



						// Possibly insert some nulls for a test file.
						if (checkBox_Insert_Nulls.Checked == true)
						{
							switch (RowNumber)
							{
								case 3:
								case 6:
								case 9:
									{
										s = s + Convert.ToChar(0x0).ToString();

										break;
									}

								default:
									{
										// Do nothing.
										break;
									}
							}

						}

                  // Write the line to the output file.
						// Output file.
						if (writeOutputFile == true)
						{
							w.WriteLine(s);
							w.Flush();

							LinesWritten++;

							// Rows Written Count.
							textBox_RowsWritten.Text = LinesWritten.ToString();
							textBox_RowsWritten.Refresh();
						}

                  LinesScanned++;

                  // Rows Scanned Count.
                  textBox_RowsScanned.Text = LinesScanned.ToString();
                  textBox_RowsScanned.Refresh();

                  // Check if we got enough of the first lines.
                  if (maxLines > 0)
                  {
                     if (LinesScanned >= maxLines)
                     {
                        // If so then stop scanning.
                        break;
                     }
                  }                  
               }

               LogAndDisplay(LinesScanned.ToString() + " Lines scanned.");

					if (writeOutputFile == true)
					{
						LogAndDisplay(LinesWritten.ToString() + " Lines written."); 
					}
               
            }

				if (writeOutputFile == true)
				{
					try
					{
						w.Close();
					}
					catch (Exception ex)
					{
						string errorString = ex.ToString();
					}
				}

            // Update the elapsed time.
            StopTime = DateTime.Now;
            ElapsedTime = StopTime - StartTime;
            Int32 elapsedTimeInt = (Int32)ElapsedTime.TotalSeconds;
            textBox_ElapsedTime.Text = elapsedTimeInt.ToString("N0");

            Cursor.Current = Cursors.WaitCursor;

            LogAndDisplay("Done!");
         }
         catch (Exception ex)
         {
            textBox_Status.Text = "Exception:  " + ex.ToString();
         }
         finally
         {
         }

         // Update the status message textbox.
         //textBox_Status.Text += LineCount.ToString() + " Lines processed.";
         //textBox_Status.Text += ReplacementCount.ToString() + " Lines changed.";


      }
      
      
      private void button_SelectInputFile_Click(object sender, EventArgs e)
      {
         OpenFileDialog diag = new OpenFileDialog();

         if (diag.ShowDialog() == DialogResult.OK)
         {
            // File was successfully opened.
            textBox_InputFile.Text = diag.FileName;

            textBox_OutputFile.Enabled = true;
         }
      }

      private void button_SelectOutputFile_Click(object sender, EventArgs e)
      {
         OpenFileDialog diag = new OpenFileDialog();

         if (diag.ShowDialog() == DialogResult.OK)
         {
            // File was successfully opened.
            textBox_OutputFile.Text = diag.FileName;
         }
      }

      private void textBox_OutputFile_TextChanged(object sender, EventArgs e)
      {
         button_Run.Enabled = true;
      }

      private void Form1_Load(object sender, EventArgs e)
      {

         textBox_InputFile.Select();

      }

      private void textBox_InputFile_TextChanged(object sender, EventArgs e)
      {

      }


#region "Checkbox Code"

      private void checkBox_First_CheckedChanged(object sender, EventArgs e)
      {

         checkBox_First.Checked = true;

         checkBox_Last.Checked = false;
         checkBox_Random.Checked = false;

         textBox_Status.Clear();

      }

      private void checkBox_Last_CheckedChanged(object sender, EventArgs e)
      {
         checkBox_Last.Checked = false;
         checkBox_Random.Checked = false;

         textBox_Status.Clear();
         textBox_Status.Text = "Not yet implemented!";

         //MessageBox.Show("Not yet implemented!", "To Be Implemented");
      }

      private void checkBox_Random_CheckedChanged(object sender, EventArgs e)
      {
         checkBox_Last.Checked = false;
         checkBox_Random.Checked = false;

         textBox_Status.Clear();
         textBox_Status.Text = "Not yet implemented!";

         //MessageBox.Show("Not yet implemented!", "To Be Implemented");
      }

#endregion


      private void button_LoadLine_Click_1(object sender, EventArgs e)
      {

         // Just get the first line for now.
         // Get_First_Line(1);
         
         if(checkBox_AnalyzeFirstLine.Checked == true)
         {
            Get_First_Line(1);
         }
         else
         {
            Int32 lineNumber = (Int32) numericUpDown_AnalyzeLineNumber.Value;
            
            Get_First_Line(lineNumber);
         }

      }
      
      private void Get_First_Line(int lineNumber)
      {
         textBox_Status.Clear();

         // Get the input file path.
         string path;
         path = textBox_InputFile.Text.Trim();

         Int64 LinesScanned = 1;
         Int64 LinesWritten = 0;
         Int32 LinesToSample = 0;

         // Get the number of lines we're supposed to grab.
         //LinesToSample = (int)numericUpDown_NumberOfRecords.Value;
         //LinesToSample = 1;
       
         
         //StreamWriter w = new StreamWriter(textBox_OutputFile.Text.Trim());
         
         // Open the file.
         try
         {

            using (sr = File.OpenText(path))
            {
               currentRecord = "";
               string retrievedRecord = "";

               // File scan loop.
               while ((retrievedRecord = sr.ReadLine()) != null)
               {

                  // Check if we got enough of the first lines.
                  if (LinesScanned == lineNumber)
                  {
                     currentRecord = retrievedRecord;

                     // Write the line to the output file.
                     //w.WriteLine(s);
                     //w.Flush();

                     textBox_LineBeingAnalyzed.Text = "<Start of Line>" + currentRecord + "<End of Line>";

                     LinesWritten++;

                     // Rows Written Count.
                     //textBox_RowsWritten.Text = LinesWritten.ToString();
                     //textBox_RowsWritten.Refresh();

                     LinesScanned++;
                     
                     break;

                  }
                  else
                  {
                     // Just continue.
                     // break;

                     LinesScanned++;
                     
                  }
               }
                  

                  // Rows Scanned Count.
                  textBox_RowsScanned.Text = LinesScanned.ToString();
                  textBox_RowsScanned.Refresh();

                  //LogAndDisplay(LinesScanned.ToString() + " Lines scanned.");
                  //LogAndDisplay(LinesWritten.ToString() + " Lines written.");
            }

            //w.Close();
                  
            //LogAndDisplay("Done!");      
         }
         catch (Exception ex)
         {
            textBox_Status.Text = "Exception:  " + ex.ToString();
         }
         finally
         {
         }

         // Update the status message textbox.
         //textBox_Status.Text += LineCount.ToString() + " Lines processed.";
         //textBox_Status.Text += ReplacementCount.ToString() + " Lines changed.";

      }

      private void button_GetLineLength_Click_1(object sender, EventArgs e)
      {
      
         Get_Sample_Line_Length();
         
      }
         
      private void Get_Sample_Line_Length()
      {
         Sample_LineLength = currentRecord.Length;
 
         textBox_LineLength.Text = Sample_LineLength.ToString() + " Characters";
      }

      private void button_GetLineTermination_Click(object sender, EventArgs e)
      {
      
         Get_First_Line_Binary();
         
         Check_For_Line_Terminators();
         
      }
         

      private void Get_First_Line_Binary()
      {
         // This gets the line termination characters that StreamReader does not.

         textBox_Status.Clear();

         // Get the input file path.
         string path;
         path = textBox_InputFile.Text.Trim();
         
         // Create the reader for data.
         fs = new FileStream(path, FileMode.Open, FileAccess.Read);
         
         // This gets the length of the current line with the ending CR/LF (if any).
         int lineLength = currentRecord.Length;
         
         // Set the stream position to the end of the file.
         fs.Seek(lineLength, SeekOrigin.Begin);
                  
         BinaryReader r = new BinaryReader(fs);
  
         // Read data the first line from the file.
         LastCharacterPlusOne = r.ReadChar();
         LastCharacterPlusTwo = r.ReadChar();
         
         r.Close();
         fs.Close();
     
      }

      private void Check_For_Line_Terminators()
      {

         string fileType;
         
         // Variations:
         //    1.  LF Only - Unix                    ASCII 10  0x0A   \r
         //    2.  CR Only - MacIntosh               ASCII 13  0x0D   \n
         //    3.  CR/LF - Windows/DOS    ASCII 13 + ASCII 10  0x0D + 0x0A   \r\n

         switch ((int)LastCharacterPlusOne)
         {
            case 0x0A:       // LF - Line Feed - Ox0A
               // It's a Unix file.
               fileType = "Unix";
               checkBox_LFOnly.Checked = true;
               checkBox_CROnly.Checked = false;
               checkBox_CRLF.Checked = false;
               break;
    
            case 0x0D:       // CR - Carriage Return - 0x0D

               if (LastCharacterPlusTwo == 0x0A)
               {
                  // It's a PC file.
                  fileType = "PC";
                  checkBox_LFOnly.Checked = false;
                  checkBox_CROnly.Checked = false;
                  checkBox_CRLF.Checked = true;
               }
               else
               {
                  // It's a MacIntosh file.
                  fileType = "Mac";
                  checkBox_LFOnly.Checked = false;
                  checkBox_CROnly.Checked = true;
                  checkBox_CRLF.Checked = false;
                  break;
               }
               break;            


            default:
               // Nothing.
               fileType = "Unknown";
               checkBox_LFOnly.Checked = false;
               checkBox_CROnly.Checked = false;
               checkBox_CRLF.Checked = false;
               break;
         }
         
         textBox_LineTermination.Text = fileType;
         Sample_Terminator_Type = fileType;
         
      }

      private void checkBox_DoAllRecords_CheckedChanged(object sender, EventArgs e)
      {

         checkBox_First.Checked = false;
         checkBox_Last.Checked = false;
         checkBox_Random.Checked = false;
         
      }

      private void checkBox_First_CheckedChanged_1(object sender, EventArgs e)
      {
         checkBox_DoAllRecords.Checked = false;
      }

      private void checkBox_Last_CheckedChanged_1(object sender, EventArgs e)
      {
         checkBox_DoAllRecords.Checked = false;
      }

      private void checkBox_Random_CheckedChanged_1(object sender, EventArgs e)
      {
         checkBox_DoAllRecords.Checked = false;
      }

      private void checkBox_CheckLineLengths_CheckedChanged(object sender, EventArgs e)
      {

      }


      private void Check_Line_Lengths(string row)
      {
         int rowLength;

         rowLength = row.Length;

         if (rowLength == Sample_LineLength)
         {
            // Then row length is ok.

         }
         else
         {
            if (row.Length == 0)
            {
               if (checkBox_IgnoreBlankLines.Checked == true)
               {

                  // Ignore the blank line.

               }
               else
               {
                  // Log the blank line error.
                  LogAndDisplay("Row " + RowNumber.ToString() + ": Blank line!");
               }
            }
            else
            {
               // Log the error.
               LogAndDisplay("Row " + RowNumber.ToString() + ": Bad length! " + rowLength.ToString() + " characters.");
               LogAndDisplay("   Row = |" + row + "|");
            }
         }
      }



      private void Check_Line_Terminators(string row)
      {

          // To Do.

      }

      private void Check_Line_Characters(string row)
      {

         // Non-Printable characters to match:
         // [\x00-\x09\x0B-\x0C\x0E-\x1F\x7F-\xFF]
         //
         // \x00-\x09 - ASCII decimal   0 -   9, skipping the LF (10, 0xA) character.
         // \x0B-\x0C - ASCII decimal  11 -  12.
         // \x0E-\x1F - ASCII decimal  14 -  31, skipping the CR (13, 0xD) character.
         // \x7F-\xFF - ASCII decimal 127 - 255.


         // Define a regular expression for non-printable characters.
         // Skips the LF and CR characters.
         // Regex rx = new Regex(@"[\x00-\x09\x0B-\x0C\x0E-\x1F\x7F-\xFF]");
         // Includes the LF and CR characters.
         Regex rx = new Regex(@"[\x00-\x1F\x7F-\xFF]");

         if (rx.IsMatch(row))
         {
            // The line contains non-printable characters.

            // Log the error.
            LogAndDisplay("Row " + RowNumber.ToString() + ": Bad Characters!");
            LogAndDisplay("   Row = |" + row + "|");             
         }
         else
         {
            // The line does NOT contain non-printable characters.
            // Thus the line is OK!
         }
      }

		private void Check_For_Nulls(string row)
		{
			if (row.Contains(Convert.ToChar(0x0).ToString()))
			{
				// The line contains a null characters.

				// Log the error.
				LogAndDisplay("Row " + RowNumber.ToString() + ": NULL Character!");
				LogAndDisplay("   Row = |" + row + "|");
			}
			else
			{
				// The line does NOT contain null characters.
				// Thus the line is OK!
			}
		}

      private void button_CheckLineTerminators_Click(object sender, EventArgs e)
      {

         Check_Line_Terminators();

      }

      private void Check_Line_Terminators()
      {
         // This gets the line termination characters that StreamReader does not.

         //textBox_Status.Clear();

         LogAndDisplay("Scaning file for proper CRLF line terminators in Binary Mode...");

         // Get the input file path.
         string path;
         path = textBox_InputFile.Text.Trim();
         
         // Create the reader for data.
         fs = new FileStream(path, FileMode.Open, FileAccess.Read);
         
         // This gets the length of the current line with the ending CR/LF (if any).
         int lineLength = currentRecord.Length;

         LogAndDisplay("Text record length with CRLF: " + (currentRecord.Length + 2).ToString("N0"));

         if ((checkBox_CheckOnlyRow.Checked == true) || (checkBox_StartFromRow.Checked = true))
         {
           Int32 rowToStart = 0;

           try
           {
              rowToStart = (Int32)numericUpDown_StartFromRow.Value - 1;
           }
           catch (Exception)
           {
              rowToStart = 0;
              //throw;
           }
           
           
           // To Do:  This is hardcoded for now.  Fix it later.
           int rowSize = 2501;
           Int32 byteToStart;
           byteToStart = rowToStart * rowSize;

           // Set the stream position to the place in the file to start the reading.
           fs.Seek(byteToStart, SeekOrigin.Begin);
         }
         else
         {
            // Set the stream position to the beginning of the file.
            fs.Seek(0, SeekOrigin.Begin);
         }


         
         Int64 streamBytes = 0;
         int currentByte;
         Int64 byteCount = 0;
         int byteRecordCount = 0;
         
         char currentChar;
         
         // DEBUG:
         string currentString = "";
         // DEBUG:
         
         TotalTerminatorErrors = 0;

         StartTime = DateTime.Now;

         Cursor.Current = Cursors.WaitCursor;

         
         // Scan the file stream byte by byte.
         for (streamBytes = 0; streamBytes < fs.Length; streamBytes++)
         {
         
            // Group into "records" of the detected string length + 2 for CRLF.
            currentByte = fs.ReadByte();
            currentChar = (char)currentByte;

            // DEBUG:
            currentString += currentChar;
            // DEBUG:
            
            byteCount++;
            byteRecordCount++;
     
            if (byteRecordCount == (lineLength + 1))
            {
               // It should be a CR.
               if (currentByte == 0x0D)
               {
                  // That's good.
               }
               else
               {
                  // That's an error.
                  TotalTerminatorErrors++;
                  
                  // Log the error.
                  LogAndDisplay("Byte number: " + byteCount.ToString() + ": Missing Carriage Return character!  Char = " + currentChar + " Int = " + currentByte.ToString());               
               }
            }

            if (byteRecordCount == (lineLength + 2))
            {
               // It should be a LF.
               if (currentByte == 0x0A)
               {
                  // That's good.
               }
               else
               {
                  // That's an error.
                  TotalTerminatorErrors++;
                  
                  // Log the error.
                  LogAndDisplay("Byte number: " + byteCount.ToString() + ": Missing Line Feed character!  Char = " + currentChar + " Int = " + currentByte.ToString());
               }
               
               // Reset the byte record grouping count.
               byteRecordCount = 0;
               
               if (checkBox_CheckOnlyRow.Checked == true)
               {
                  // If it is only a single line to check then stop scan.
                  break;
               }
            }            
         }

         fs.Close();

         // Update the elapsed time.
         StopTime = DateTime.Now;
         ElapsedTime = StopTime - StartTime;
         Int32 elapsedTimeInt = (Int32)ElapsedTime.TotalSeconds;
         textBox_ElapsedTime.Text = elapsedTimeInt.ToString("N0");
         
         LogAndDisplay("Elapsed time = " + elapsedTimeInt.ToString("N0"));

         Cursor.Current = Cursors.Default;

         LogAndDisplay("Total Bytes Read: " + streamBytes.ToString());
         LogAndDisplay("Total Terminator Errors: " + TotalTerminatorErrors.ToString("N0"));
         LogAndDisplay("Done!.");
         
      }

      private void LogAndDisplay(string msg)
      {
         Log(msg);

         textBox_Status.AppendText(Environment.NewLine);
         textBox_Status.AppendText(msg);
         textBox_Status.Update();

			// Log it to the local logfile display window.
			textBox_Log.Text += msg + System.Environment.NewLine;
      }


      private void Log(string msg)
      {
         
         if (checkBox_UseLogFile.Checked == false)
         {
            // If log file logging not enabled, return.
            return;
         } 
        
         // Build up the log file record format.
         string LogFileMsg;
         DateTime currentTime =  DateTime.Now;
         
         LogFileMsg = currentTime + " " + msg.Trim();
         
         // Log the message.
         
         string LogFilePath = textBox_LogFile.Text.Trim();

         StreamWriter sw = File.AppendText(LogFilePath);

         sw.WriteLine(LogFileMsg);
         
         sw.Flush();
         
         sw.Close();     
      }

      private void Main_Form_Load(object sender, EventArgs e)
      {

         Log(" ");
         Log("-----------------------------------------------------------------");
         LogAndDisplay("File Data Quality Analyzer started.");
         Log(" ");
         



      }

      private void checkBox_AnalyzeFirstLine_CheckedChanged(object sender, EventArgs e)
      {
         if (checkBox_AnalyzeFirstLine.Checked == true)
         {
            checkBox_AnalyzeLineNumber.Checked = false;
            numericUpDown_AnalyzeLineNumber.Enabled = false;
         }
         else
         {
            checkBox_AnalyzeLineNumber.Checked = true;
            numericUpDown_AnalyzeLineNumber.Enabled = true;
         }
      }

      private void checkBox_AnalyzeLineNumber_CheckedChanged(object sender, EventArgs e)
      {
         if (checkBox_AnalyzeLineNumber.Checked == true)
         {
            checkBox_AnalyzeFirstLine.Checked = false;
         }
         else
         {
            checkBox_AnalyzeFirstLine.Checked = true;

            numericUpDown_AnalyzeLineNumber.Enabled = false;
         }
      }

		private void button_Clear_Log_Click(object sender, EventArgs e)
		{
			textBox_Log.Clear();
		}

		private void button_Save_Log_Click(object sender, EventArgs e)
		{
			// To Do:
			MessageBox.Show("Not yet implemented!", "Log File Save");
		}

		private void button_Copy_To_Clipboard_Click(object sender, EventArgs e)
		{
			// To Do:
			MessageBox.Show("Not yet implemented!", "Log File Save");
		}

		private void checkBox_Check_For_Nulls_CheckedChanged(object sender, EventArgs e)
		{

		}

        private void checkBox_Check_Pipe_Symbols_Per_Row_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_Check_Pipe_Symbols_Click(object sender, EventArgs e)
        {
            LinesScanned = 0;
            LinesWritten = 0;
            LinesToSample = 0;
            RowNumber = 0;

            textBox_RowsScanned.Clear();
            textBox_RowsWritten.Clear();
            textBox_ElapsedTime.Clear();

            textBox_Log.Clear();

            // First get the sample information for the file.
            Get_First_Line_Pipe_Count();
            //Get_Sample_Line_Length();

            // Get_First_Line_Binary();
            // Check_For_Line_Terminators();

            // Now scan the file.
            Scan_File_For_Pipe_Symbols();
        }


        private void Get_First_Line_Pipe_Count()
        {
            textBox_Status.Clear();

            // Get the input file path.
            string path;
            path = textBox_InputFile.Text.Trim();

            Int64 LinesScanned = 1;
            Int64 LinesWritten = 0;
            Int32 LinesToSample = 0;

            // Get the number of lines we're supposed to grab.
            //LinesToSample = (int)numericUpDown_NumberOfRecords.Value;
            //LinesToSample = 1;


            //StreamWriter w = new StreamWriter(textBox_OutputFile.Text.Trim());

            pipe_Symbol_Count = 0;

            // Open the file.
            try
            {

                using (sr = File.OpenText(path))
                {
                    currentRecord = "";
                    string retrievedRecord = "";

                    // File scan loop.
                    while ((retrievedRecord = sr.ReadLine()) != null)
                    {

                        // Count the Pipe Symbols in the first line.

                        foreach(char c in retrievedRecord)
                        {
                            if(c == '|')
                            {
                                pipe_Symbol_Count++;
                            }

                        }

                        textBox_Status.Text += "Line 1 has " + pipe_Symbol_Count.ToString() + " pipe symbols.";
                        textBox_Status.Text += System.Environment.NewLine;
                        textBox_Status.Text += System.Environment.NewLine;




                        // Check if we got enough of the first lines.
                        if (LinesScanned == 1)
                        {
                            currentRecord = retrievedRecord;

                            // Write the line to the output file.
                            //w.WriteLine(s);
                            //w.Flush();

                            textBox_LineBeingAnalyzed.Text = "<Start of Line>" + currentRecord + "<End of Line>";

                            LinesWritten++;

                            // Rows Written Count.
                            //textBox_RowsWritten.Text = LinesWritten.ToString();
                            //textBox_RowsWritten.Refresh();

                            LinesScanned++;

                            break;

                        }
                        else
                        {
                            // Just continue.
                            // break;

                            LinesScanned++;

                        }
                    }


                    // Rows Scanned Count.
                    textBox_RowsScanned.Text = LinesScanned.ToString();
                    textBox_RowsScanned.Refresh();

                    //LogAndDisplay(LinesScanned.ToString() + " Lines scanned.");
                    //LogAndDisplay(LinesWritten.ToString() + " Lines written.");
                }

                //w.Close();

                //LogAndDisplay("Done!");      
            }
            catch (Exception ex)
            {
                textBox_Status.Text = "Exception:  " + ex.ToString();
            }
            finally
            {
            }

            // Update the status message textbox.
            //textBox_Status.Text += LineCount.ToString() + " Lines processed.";
            //textBox_Status.Text += ReplacementCount.ToString() + " Lines changed.";

        }

        private void Scan_File_For_Pipe_Symbols()
        {
            bool writeOutputFile = false;

            if (string.IsNullOrEmpty(textBox_OutputFile.Text))
            {
                writeOutputFile = false;

                label_Row_Written.Visible = true;
                textBox_RowsWritten.Visible = true;
            }
            else
            {
                writeOutputFile = true;

                label_Row_Written.Visible = true;
                textBox_RowsWritten.Visible = true;
            }

            ///////////////////textBox_Status.Clear();

            if (textBox_OutputFile.Text.Length <= 0)
            {
                // To Do:  Add error handling code here for this exception.
            }

            // Get the input file path.
            string path;
            path = textBox_InputFile.Text.Trim();

            // Get the number of lines we're supposed to grab.
            LinesToSample = (int)numericUpDown_NumberOfRecords.Value;

            // Output file.

            //StreamWriter w = new StreamWriter(@"C:\x.txt");

            if (writeOutputFile == true)
            {
                //try
                //{
                //   w.Close();
                //}
                //catch (Exception ex)
                //{
                //   string errorString = ex.ToString();
                //}

                w = new StreamWriter(textBox_OutputFile.Text.Trim());
            }

            // Establish line processing limits.

            if (checkBox_DoAllRecords.Checked == true)
            {
            }

            Cursor.Current = Cursors.WaitCursor;

            StartTime = DateTime.Now;

            // Open the file.
            try
            {

                using (sr = File.OpenText(path))
                {
                    string s = "";
                    int maxLines = 0;

                    // File scan loop.
                    while ((s = sr.ReadLine()) != null)
                    {

                        RowNumber++;

                        if (checkBox_DoAllRecords.Checked == true)
                        {
                            // Do all lines in the file.
                            maxLines = 0;
                        }

                        if (checkBox_First.Checked == true)
                        {
                            // Do just the first N lines in the file.
                            maxLines = (int)numericUpDown_NumberOfRecords.Value;
                        }

                        /////////////////////////////////////////////////////////////////
                        // Count the pipe symbols!!!
                        /////////////////////////////////////////////////////////////////

                        //if (checkBox_CheckLineLengths.Checked == true)
                        //{
                        //    Check_Line_Lengths(s);
                        //}

                        //if (checkBox_CheckLineTerminators.Checked == true)
                        //{
                        //    Check_Line_Terminators(s);
                        //}

                        //if (checkBox_CheckForValidCharaters.Checked == true)
                        //{
                        //    Check_Line_Characters(s);
                        //}

                        //if (checkBox_Check_For_Nulls.Checked == true)
                        //{
                        //    Check_For_Nulls(s);
                        //}

                        int current_Line_Pipe_Symbol_Count = Count_Pipe_Symbols(s);


                        if(current_Line_Pipe_Symbol_Count == pipe_Symbol_Count)
                        {
                            // We're ok!
                        }
                        else
                        {
                            // We have a problem here!
                            // So display the line number and the problem.

                            textBox_Status.Text += "Line " + RowNumber.ToString() + ": " + current_Line_Pipe_Symbol_Count.ToString() + " pipe symbols.";
                            textBox_Status.Text += System.Environment.NewLine;
                            textBox_Status.Text += System.Environment.NewLine;
                        }



                        //// Possibly insert some nulls for a test file.
                        //if (checkBox_Insert_Nulls.Checked == true)
                        //{
                        //    switch (RowNumber)
                        //    {
                        //        case 3:
                        //        case 6:
                        //        case 9:
                        //            {
                        //                s = s + Convert.ToChar(0x0).ToString();

                        //                break;
                        //            }

                        //        default:
                        //            {
                        //                // Do nothing.
                        //                break;
                        //            }
                        //    }

                        //}

                        // Write the line to the output file.
                        // Output file.
                        //if (writeOutputFile == true)
                        //{
                        //    w.WriteLine(s);
                        //    w.Flush();

                        //    LinesWritten++;

                        //    // Rows Written Count.
                        //    textBox_RowsWritten.Text = LinesWritten.ToString();
                        //    textBox_RowsWritten.Refresh();
                        //}

                        LinesScanned++;

                        // Rows Scanned Count.
                        textBox_RowsScanned.Text = LinesScanned.ToString();
                        textBox_RowsScanned.Refresh();

                        // Check if we got enough of the first lines.
                        if (maxLines > 0)
                        {
                            if (LinesScanned >= maxLines)
                            {
                                // If so then stop scanning.
                                break;
                            }
                        }
                    }

                    //LogAndDisplay(LinesScanned.ToString() + " Lines scanned.");

                    //if (writeOutputFile == true)
                    //{
                    //    LogAndDisplay(LinesWritten.ToString() + " Lines written.");
                    //}

                }

                //if (writeOutputFile == true)
                //{
                //    try
                //    {
                //        w.Close();
                //    }
                //    catch (Exception ex)
                //    {
                //        string errorString = ex.ToString();
                //    }
                //}

                // Update the elapsed time.
                StopTime = DateTime.Now;
                ElapsedTime = StopTime - StartTime;
                Int32 elapsedTimeInt = (Int32)ElapsedTime.TotalSeconds;
                textBox_ElapsedTime.Text = elapsedTimeInt.ToString("N0");

                Cursor.Current = Cursors.WaitCursor;

                LogAndDisplay("Done!");
            }
            catch (Exception ex)
            {
                textBox_Status.Text += System.Environment.NewLine;
                textBox_Status.Text += System.Environment.NewLine;
                textBox_Status.Text += "Exception:  " + ex.ToString();
            }
            finally
            {
            }

            // Update the status message textbox.
            //textBox_Status.Text += LineCount.ToString() + " Lines processed.";
            //textBox_Status.Text += ReplacementCount.ToString() + " Lines changed.";

            textBox_Status.Text += System.Environment.NewLine;
            textBox_Status.Text += System.Environment.NewLine;

            textBox_Status.Text += "Complete!";
            textBox_Status.Text += System.Environment.NewLine;
            textBox_Status.Text += System.Environment.NewLine;


            textBox_Status.Text += "Last Line Number = " + RowNumber.ToString();
            textBox_Status.Text += System.Environment.NewLine;
            textBox_Status.Text += System.Environment.NewLine;

        }


       private int Count_Pipe_Symbols(string record_String)
        {
            // Count the Pipe Symbols in the first line.

            int pipe_Symbol_Count = 0;

            foreach (char c in record_String)
            {
                if (c == '|')
                {
                    pipe_Symbol_Count++;
                }

            }

            return pipe_Symbol_Count;
        }
      
   }
}