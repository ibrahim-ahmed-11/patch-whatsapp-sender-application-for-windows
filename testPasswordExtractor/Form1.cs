using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace testPasswordExtractor
{
    public partial class Form1 : Form
    {

        string from;
        string password;

        public Form1()
        {
            InitializeComponent();

            grp2.Enabled = false;
            grp3.Enabled = false;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            if(!String.IsNullOrEmpty(txtTo.Text) && !String.IsNullOrEmpty(txtMsg.Text))
            {
                string numbers = txtTo.Text;
                string msg = txtMsg.Text;

                List<string> numbersList = numbers.Split(',').ToList<string>();

                if (File.Exists("batch3.bat"))
                {
                    File.Delete("batch3.bat");
                }

                using (StreamWriter sw = File.CreateText("batch3.bat"))
                {
                    sw.WriteLine("cd yowsup-master");
                    foreach(string s in numbersList)
                    {
                        sw.WriteLine("py yowsup-cli demos -l " + from + ":" + password + " -M -s 2" + s.Trim() + " \"" + msg + "\"");
                    }
                }

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "batch3.bat";
                proc.Start();

                MessageBox.Show("Message sent successfully !");

            }
            else
            {
                MessageBox.Show("Fill data first !");
            }
            
        }

        private void btnGetCode_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtFrom.Text) && cmbNetwork.SelectedItem != null)
            {
                from = "2" + txtFrom.Text;
                int networkOperator = cmbNetwork.SelectedIndex;
                string op = "";
                switch (networkOperator)
                {
                    case 0:
                        {
                            op = "01";
                            break;
                        }
                    case 1:
                        {
                            op = "02";
                            break;
                        }
                    case 2:
                        {
                            op = "03";
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Select Operator first !");
                            break;
                        }
                }

                if (File.Exists("batch.bat"))
                {
                    File.Delete("batch.bat");
                }

                using (StreamWriter sw = File.CreateText("batch.bat"))
                {
                    sw.WriteLine("cd yowsup-master");
                    sw.WriteLine("py setup.py build");
                    sw.WriteLine("py setup.py install");
                    sw.WriteLine("py yowsup-cli registration --requestcode sms --phone " + from + " --cc 20 --mcc 602 --mnc " + op);
                }

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = "batch.bat";
                proc.Start();

                grp2.Enabled = true;

                MessageBox.Show("Code sent to your number");
            }
            else
            {
                MessageBox.Show("Fill data first !");
            }

        }

        private void btnCode_Click(object sender, EventArgs e)
        {

            string code = txtCode.Text;

            string code1 = "" + code[0] + code[1] + code[2];
            string code2 = "" + code[3] + code[4] + code[5];


            if (File.Exists("batch2.bat"))
            {
                File.Delete("batch2.bat");
            }

            using (StreamWriter sw = File.CreateText("batch2.bat"))
            {
                sw.WriteLine("cd yowsup-master");
                sw.WriteLine("py yowsup-cli registration --register " + code1 + "-" + code2 + " --phone " + from + " -C 20");
            }

            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.RedirectStandardError = true;
            proc.StartInfo.FileName = "batch2.bat";
            proc.Start();

            proc.WaitForExit();

            StringBuilder response= new StringBuilder();

            using(StreamReader sr = proc.StandardOutput)
            {
                response.Append(sr.ReadToEnd());
            }
            using (StreamReader sr2 = proc.StandardError)
            {
                response.Append(sr2.ReadToEnd());
            }
            
            proc.WaitForExit();

            password = getBetween(response.ToString(), "pw: b'", "'");

            grp3.Enabled = true;

            if (File.Exists("number.txt"))
                File.Delete("number.txt");
            if (File.Exists("pass.txt"))
                File.Delete("pass.txt");

            using (StreamWriter sw = File.CreateText("number.txt"))
            {
                sw.Write(from);
            }
            using (StreamWriter sw = File.CreateText("pass.txt"))
            {
                sw.Write(password);
            }


            MessageBox.Show("Registered Successfully !");


        }

        public string getBetween(string strSource, string strStart, string strEnd)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }

        private void btnBrowseExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Microsoft.Office.Interop.Excel.Application xlsApp = new Microsoft.Office.Interop.Excel.Application();

                    if (xlsApp == null)
                    {
                        MessageBox.Show("EXCEL could not be started. Check that your office installation and project references are correct.");
                    }
                    else
                    {
                        Workbook wb = xlsApp.Workbooks.Open(openFileDialog1.FileName, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true);
                        Sheets sheets = wb.Worksheets;
                        Worksheet ws = (Worksheet)sheets.get_Item(1);

                        Range firstColumn = ws.UsedRange.Columns[1];
                        System.Array myvalues = (System.Array)firstColumn.Cells.Value;
                        string[] excelNumbers = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();


                        if (!String.IsNullOrEmpty(txtTo.Text))
                        {
                            for (int i = 0; i < excelNumbers.Length; i++)
                            {
                                if (excelNumbers[i][0] == '0')
                                    txtTo.Text += "," + excelNumbers[i];
                                else
                                    txtTo.Text += ",0" + excelNumbers[i];
                            }
                        }
                        else
                        {
                            for (int i = 0; i < excelNumbers.Length; i++)
                            {
                                if (excelNumbers[i][0] == '0')
                                    txtTo.Text += excelNumbers[i] + ",";
                                else
                                    txtTo.Text += "0" + excelNumbers[i] + ",";
                            }
                            txtTo.Text = txtTo.Text.Remove(txtTo.TextLength - 1);
                        }
                        MessageBox.Show("Numbers imported successfully !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
    
}
