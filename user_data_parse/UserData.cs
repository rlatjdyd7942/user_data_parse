using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace user_data_parse
{
    class UserData : IComparable
    {
        public long dateTimeTick;
        public int age;
        public int gender;
        public int marriage;
        public int count;

        public UserData(long dateTimeTick, int age, int gender, int marriage, int count)
        {
            this.dateTimeTick = dateTimeTick;
            this.age = age;
            this.gender = gender;
            this.marriage = marriage;
            this.count = count;
        }

        public DateTime getDate()
        {
            return new DateTime(dateTimeTick);
        }

        int IComparable.CompareTo(object obj)
        {
            int result = 0;
            if (obj == null)
                result = 1;
            else
            {
                UserData userData = obj as UserData;
                if (this.dateTimeTick > userData.dateTimeTick)
                    result = 1;
                else if (this.dateTimeTick == userData.dateTimeTick)
                {
                    result = 0;
                }
                else
                    result = -1;
            }
            return result;
        }
    }
}
