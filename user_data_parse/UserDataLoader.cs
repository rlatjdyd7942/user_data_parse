using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace user_data_parse
{
    class UserDataLoader
    {
        public static readonly DateTime BaseDate = new DateTime(2012, 11, 15);
        private static readonly string UserDataFileName = "user_data.csv";
        private static readonly string UserIdTableFileName = "user_id_table.csv";

        public static int[] loadUserIdData(String folderPath)
        {
            List<int> userIdDataList = new List<int>();
            string[] splited = null;
            try
            {
                foreach (string line in File.ReadAllLines(folderPath + "\\" + UserIdTableFileName))
                {
                    splited = line.Split(',');
                    userIdDataList.Add(Int32.Parse(splited[0].Replace("\"", "")));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return userIdDataList.ToArray();
        }

        public static List<UserData> loadUserData(String folderPath)
        {
            List<UserData> userDataList = new List<UserData>();
            UserData userData = null;
            try
            {
                foreach (string line in File.ReadAllLines(folderPath + "\\" + UserDataFileName))
                {
                    if (line != null)
                    {
                        userData = parseUserData(line);
                        if (userData.count != 0)
                            userDataList.Add(userData);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            return userDataList;
        }

        private static UserData parseUserData(string line)
        {
            long dateTimeTick = -1;
            int age = -1;
            int gender = -1;
            int marriage = -1;
            int count = 0;
            string[] parts = line.Replace("\"", "").Split(',');
            try
            {
                if (!line.Contains("null"))
                {
                    dateTimeTick = DateTime.ParseExact(parts[0], "yyyy-MM-dd", null).Ticks;
                    age = int.Parse(parts[1]);
                    gender = int.Parse(parts[2]);
                    //marriage = int.Parse(parts[3]);
                    count = int.Parse(parts[4]);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.StackTrace);
            }
            UserData userData = new UserData(dateTimeTick, age, gender, marriage, count);
            return userData;
        }
    }
}
