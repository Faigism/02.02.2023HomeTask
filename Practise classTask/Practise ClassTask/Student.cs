using System;
using System.Collections.Generic;
using System.Text;

namespace wefqe
{
    internal class Student
    {
        static byte count;
        public Student()
        {
            count++;
            No = count;
        }
        public byte No;
        public string FullName;
        private string _groupNo;
        public byte Point;
        public string GroupNo
        {
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;
                    
            }
            get
            {
                return _groupNo;
            }
        }

        static public bool CheckGroupNo(string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length != 4)
                return false;
            if (!char.IsUpper(str[0]))
                return false;
            for (int i = 1; i < str.Length; i++)
            {
                if (!char.IsDigit(str[i]))
                    return false;
            }
            return true;
        }       
    }
}
