using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testPasswordExtractor
{
    public partial class registeredNumber : Form
    {
        public registeredNumber()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string from = "";
            string password = "";

            if (File.Exists("number.txt") && File.Exists("pass.txt"))
            {
                from = File.ReadAllText("number.txt");
                password = File.ReadAllText("pass.txt");

                if (!String.IsNullOrEmpty(txtTo.Text) && !String.IsNullOrEmpty(txtMsg.Text))
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
                            foreach (string s in numbersList)
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
            else
            {
                MessageBox.Show("No numbers are registered !");
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
                                if(excelNumbers[i][0] == '0')
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
