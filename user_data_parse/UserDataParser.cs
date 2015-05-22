using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace user_data_parse
{
    class UserDataParser
    {
        private int startAge;
        private int endAge;
        private String startDate;
        private String endDate;
        private int gender;
        private int[] terms;
        private List<UserData> userData;
        private int[] userIdData;

        public void loadUserData(String userDataFolderPath)
        {
            try
            {
                userData = UserDataLoader.loadUserData(userDataFolderPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("파일 읽어오는 중 오류 발생");
            }

            try
            {
                userIdData = UserDataLoader.loadUserIdData(userDataFolderPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("파일 읽어오는 중 오류 발생");
            }
        }

        public void set(int startAge, int endAge, String startDate, String endDate, int gender, int[] terms)
        {
            this.startAge = startAge;
            this.endAge = endAge;
            this.startDate = startDate;
            this.endDate = endDate;
            this.gender = gender;
            this.terms = terms;
        }

        public void run(String folderPath, String resultFilePath)
        {
            List<int[]> retensionList = new List<int[]>();
            List<int[]> userCountList = new List<int[]>();
            DateTime endDateTime = DateTime.ParseExact(endDate, "yyyy-MM-dd", null);
            for (DateTime current = DateTime.ParseExact(startDate, "yyyy-MM-dd", null)
                ; (endDateTime - current).Days >= 0
                ; current = current.AddDays(1))
            {
                retensionList.Add( calculateRetensionByDate(current, folderPath) );
                userCountList.Add( getUserCountByDate(current, folderPath) );
            }
            List<string> resultString = getResultStringList(retensionList, userCountList);
            writeResults(resultFilePath, resultString);
        }

        private List<string> getResultStringList(List<int[]> retensionList, List<int[]> userCountList)
        {
            int columns = retensionList.Count;
            int rows = retensionList[0].Length;
            List<string> resultString = new List<string>();
            try
            {
                string line = String.Format("\"{0}~{1}({2})\"", startAge, endAge, gender);
                DateTime endDateTime = DateTime.ParseExact(endDate, "yyyy-MM-dd", null);
                for (DateTime current = DateTime.ParseExact(startDate, "yyyy-MM-dd", null)
                    ; (endDateTime - current).Days >= 0
                    ; current = current.AddDays(1))
                {
                    line += String.Format(",\"{0}\",\"\"", current.ToString("yyyy-MM-dd"));
                }
                resultString.Add(line);
                for (int i = 0; i < rows - 1; ++i)
                {
                    line = "\"" + terms[i] + "\"";
                    for (int j = 0; j < columns; ++j)
                    {
                        line += ",\"" + retensionList[j][i] + "\"";
                        line += ",\"" + userCountList[j][i] + "\"";
                    }
                    resultString.Add(line);
                }
                line = "\"" + terms[terms.Length - 1] + "~\"";
                for (int i = 0; i < columns; ++i)
                {
                    line += ",\"" + retensionList[i][rows - 1] + "\"";
                    line += ",\"" + userCountList[i][rows - 1] + "\"";
                }
                resultString.Add(line);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            return resultString;
        }

        private void writeResults(string resultFilePath, List<string> resultString)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(resultFilePath))
                {
                    foreach (string line in resultString)
                    {
                        file.WriteLine(line);
                    }
                }
            }
            catch (PathTooLongException e)
            {
                MessageBox.Show("현재 폴더 경로가 너무 깁니다.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
        }

        private int[] getUserCountByDate(DateTime dateTime, string folderPath)
        {
            int[] result = new int[terms.Length + 1];
            int cur, prev;
            try
            {
                int days = 1 + getDaysFromDate( dateTime.ToString("yyyy-MM-dd") );
                cur = userIdData[days];
                DateTime startDateTime = DateTime.ParseExact(startDate, "yyyy-MM-dd", null);
                for (int i = 0; i < userData.Count; ++i)
                {
                    if (this.gender != 0 && userData[i].gender != this.gender)
                        continue;
                    if (userData[i].age < startAge || userData[i].age > endAge)
                        continue;
                    DateTime date = userData[i].getDate();
                    if (date > dateTime)
                        continue;
                    int index = getTermsIndexFromDays( dateTime, 1 + getDaysFromDate(date.ToString("yyyy-MM-dd")) );
                    result[index] += userData[i].count;
                }
                /*for (int i = 0; i < terms.Length; ++i)
                {
                    prev = userIdData[days - terms[i]];
                    result[i] = cur - prev;
                    cur = prev;
                }
                result[terms.Length] = cur;*/
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
            }
            return result;
        }

        private int[] calculateRetensionByDate(DateTime dateTime, string folderPath)
        {
            int[] result = new int[terms.Length + 1];
            string line;
            int lowestId = Int32.MaxValue;
            string filePath = folderPath + "\\" + dateTime.ToString("yyyy-MM-dd") + ".csv";
            try
            {
                StreamReader file = new StreamReader(filePath);
                file.ReadLine();
                string[] splited;
                int id, age, gender, marriage;
                int days;
                int index;
                while ((line = file.ReadLine()) != null)
                {
                    try
                    {
                        if (line.Equals(""))
                            continue;
                        splited = line.Replace("\"", "").Split(',');
                        id = Int32.Parse(splited[0]);
                        if (id < lowestId)
                            lowestId = id;
                        age = Int32.Parse(splited[1]);
                        gender = Int32.Parse(splited[2]);
                        //marriage = Int32.Parse(splited[3]);
                        if (startAge > age || age > endAge)
                            continue;
                        if (this.gender != 0 && this.gender != gender)
                            continue;
                        //if (marriage) {}
                        days = getDaysFromId(id);
                        index = getTermsIndexFromDays(dateTime, days);
                        ++result[index];
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                    }
                }
                file.Close();
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(filePath + "파일을 찾을 수 없습니다.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace);
                Console.WriteLine(e.StackTrace);
            }
            return result;
        }

        private int getTermsIndexFromDays(DateTime date, int days)
        {
            int index = terms.Length;
            int daysFromLast = getDaysFromDate(date.ToString("yyyy-MM-dd")) - days + 1;
            for (int i = 0; i < terms.Length; ++i)
            {
                if (daysFromLast < terms[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private int getDaysFromId(int id)
        {
            int index = userIdData.Length;
            for (int i = 0; i < userIdData.Length - 1; ++i)
            {
                if (id < userIdData[i + 1])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private int getDaysFromDate(String date)
        {
            DateTime currentDate = DateTime.ParseExact(date, "yyyy-MM-dd", null);
            int days = (currentDate - UserDataLoader.BaseDate).Days;
            return days;
        }
    }
}
