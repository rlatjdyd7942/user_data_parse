using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace user_data_parse
{
    public partial class UserDataParserForm : Form
    {
        public UserDataParserForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            dataParser = new UserDataParser();
            endAgeTextBox.Text = DateTime.Now.Year.ToString();
            dataFolderPath.Text = Application.StartupPath + "\\data";
            dataParser.loadUserData(dataFolderPath.Text);
            loadPreset();
            readSettings();
        }

        private void readSettings()
        {
            loadAges();
            loadDates();
            loadGender();
            loadTerms();
        }

        private void loadAges()
        {
            this.startAge = int.Parse(startAgeTextBox.Text);
            this.endAge = int.Parse(endAgeTextBox.Text);
        }

        private void loadDates()
        {
            this.startDate = startDateTimePicker.Value.ToString("yyyy-MM-dd");
            this.endDate = endDateTimePicker.Value.ToString("yyyy-MM-dd");
        }

        private void loadGender()
        {
            if (allRadioButton.Checked)
                this.gender = 0;
            else if (maleRadioButton.Checked)
                this.gender = 1;
            else
                this.gender = 2;
        }

        private void loadTerms()
        {
            String[] splited = termsTextBox.Text.Split(',');
            loadTermsImpl(splited);
        }

        private void loadTermsImpl(String[] splited)
        {
            try
            {
                //String[] splited = termsTextBox.Text.Split(',');
                if (splited.Length != 0)
                {
                    terms = new int[splited.Length];
                    for (int i = 0; i < terms.Length; ++i)
                        terms[i] = int.Parse(splited[i]);
                    Array.Sort(terms);
                    String newTermsText = "" + terms[0];
                    if (splited.Length >= 1)
                    {
                        for (int i = 1; i < terms.Length; ++i)
                            newTermsText += "," + terms[i];
                        termsTextBox.Text = newTermsText;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private bool loadPreset()
        {
            bool result = false;
            String filePath = dataFolderPath.Text + "\\preset.csv";
            if (File.Exists(filePath))
            {
                String[] terms = null;
                try
                {
                    StreamReader file = new StreamReader(filePath);
                    String line = file.ReadLine();
                    terms = line.Replace("\"", "").Split(',');
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine(filePath + " 파일을 읽는 중 오류가 발생했습니다.");
                }
                loadTermsImpl(terms);
                result = true;
            }
            else
            {
                Console.WriteLine(filePath + " 파일이 없습니다.");
            }
            return result;
        }

        private void run() {
            readSettings();
            dataParser.set(startAge, endAge, startDate, endDate, gender, terms);
            dataParser.run(dataFolderPath.Text, Application.StartupPath + "\\result.csv");
        }

        private UserDataParser dataParser;
        private int startAge;
        private int endAge;
        private String startDate;
        private String endDate;
        private int gender;
        private int[] terms;

        private void setFolderPathButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dataFolderPath.Text = folderBrowserDialog.SelectedPath;
                //loadUserData();
                dataParser.loadUserData(dataFolderPath.Text);
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            run();
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            String filePath = Application.StartupPath + "\\result.csv";
            if (File.Exists(filePath))
            {
                Process.Start("notepad.exe", filePath);
            }
            else
            {
                MessageBox.Show(filePath + " 파일이 없습니다.");
            }
        }

        private void resultExcelButton_Click(object sender, EventArgs e)
        {
            String filePath = Application.StartupPath + "\\result.csv";
            if (File.Exists(filePath))
            {
                Process.Start("excel.exe", filePath);
            }
            else
            {
                MessageBox.Show(filePath + " 파일이 없습니다.");
            }
        }
    }
}
