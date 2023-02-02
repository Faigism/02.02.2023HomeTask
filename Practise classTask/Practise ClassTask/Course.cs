using Practise;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace wefqe
{
    internal class Course
    {
        public int StudentsLimit;
        public Student[] Students=new Student[0];
        

        public void AddStudent(Student std)
        {
            if (StudentsLimit > Students.Length)
            {
                if (!HasStudentByNo(std.No))
                {
                    Array.Resize(ref Students, Students.Length + 1);
                    Students[Students.Length - 1] = std;
                }
                else
                {
                    throw new DublicatedItemException();
                }
            }
            else
            {
                throw new OutOfLimitException($"Limitiniz {StudentsLimit} dur, limiti asa bilmezsiniz");
            }
        }

        public bool HasStudentByNo(int no)
        {
            foreach (Student item in Students)
            {
                if (item.No == no)
                    return true;
            }
            return false;
        }
    }
}
