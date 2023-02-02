using Practise;
using System;

namespace wefqe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Course course1= new Course();
            //course1.StudentsLimit= 10;
            //course1.Students =new Student[3];
            //Student std1 = new Student()
            //{
            //    Name = "Hikmet Abbasov",
            //    GroupNo = "P231",
            //    Point = 80
            //};
            //Student std2 = new Student()
            //{
            //    Name = "Bextiyar Ismayilov",
            //    GroupNo = "A343",
            //    Point = 65
            //};
            //Student std3 = new Student()
            //{
            //    Name = "Nermin Abbasova",
            //    GroupNo = "P300",
            //    Point = 50
            //};

            //course1.Students[0]= std1;
            //course1.Students[1]= std2;
            //course1.Students[2]= std3;
            //Console.WriteLine(course1.Students.Length);

            Course crs = new Course();
            crs.StudentsLimit = 3;
            Student std1 = new Student()
            {
                FullName = "Eli Haciyev",
                GroupNo = "E245",
                Point = 57,
            };
            Student std2 = new Student()
            {
                FullName = "Faiq Ismayilov",
                GroupNo = "P231",
                Point = 100,
            };
            Student std3 = new Student()
            {
                FullName = "Nermin Eliyeva",
                GroupNo = "C565",
                Point = 88,
            };

            //crs.Students[0]= std1;
            //crs.Students[1]= std2;
            //crs.Students[2]= std3;
            try
            {
                crs.AddStudent(std1);
                crs.AddStudent(std2);
                crs.AddStudent(std3);
                crs.AddStudent(std3);

            }
            catch (DublicatedItemException ex)
            {
                Console.WriteLine("Bu nomreli telebe movcuddur..."+ex.Message);
            }
            catch (OutOfLimitException ex)
            {
                Console.WriteLine("Limit asilir..."+ex.Message);
            }
            



            Console.WriteLine(crs.Students.Length);

            foreach (Student item in crs.Students)
            {
                Console.WriteLine(item.FullName);
            }
            //    int num;
            //    string numStr;
            //    do
            //    {
            //        Console.WriteLine("Eded daxil edin:  ");
            //        numStr= Console.ReadLine();
            //    } while (int.TryParse(numStr,out num));
            //    Console.WriteLine(num);
            //}
            //static bool TryConvert(string str, out int num)
            //{
            //    try
            //    {
            //        num = Convert.ToInt32(str);
            //        return true;
            //    }
            //    catch (Exception)
            //    {

            //        num = 0;
            //        return false;
            //    }
        }
    }
}
