using System;
using System.Collections.Generic;
using System.Linq;

namespace DormMgr
{
    public class Program
    {
        private static List<Dormitory> dormitories = new List<Dormitory>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("基沃托斯千禧年学院-宿舍信息管理系统");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.查询单个学生");
                Console.WriteLine("2.输入学生信息");
                Console.WriteLine("3.修改学生信息");
                Console.WriteLine("4.删除学生信息");
                Console.WriteLine("5.查看全部学生");
                Console.WriteLine("6.退出管理系统");
                Console.WriteLine("---------------------------------");
                string UserInput = Console.ReadLine();
                switch (UserInput)
                {
                    case "1":
                        QuerySingleStudent();
                        break;
                    case "2":
                        ImportStudent();
                        break;
                    case "3":
                        ModifyStudent();
                        break;
                    case "4":
                        RemoveStudent();
                        break;
                    case "5":
                        QueryAllStudent();
                        break;
                    case "6":
                        Quit();
                        break;
                    default:
                        Console.WriteLine("无效的输入，请重新选择！");
                        break;
                }
            }
        }
        public static void QuerySingleStudent()
        {
            Console.WriteLine("---------------------------------");
            Console.Write("请输入要查询的学生的学号: ");
            string searchStudentID = Console.ReadLine();

            Dormitory student = dormitories.FirstOrDefault(s => s.ID == searchStudentID);
            if (student == null)
            {
                Console.WriteLine("该学号不存在。");
                return;
            }

            Console.WriteLine($"姓名: {student.Name}");
            Console.WriteLine($"学号: {student.ID}");
            Console.WriteLine($"手机号: {student.Phone}");
        }
        public static void ImportStudent()
        {
            Console.WriteLine("---------------------------------");
            Console.Write("请输入学生姓名：");
            string StuName = Console.ReadLine();
            Console.Write("请输入学生学号：");
            string StuID = Console.ReadLine();
            Console.Write("请输入学生手机号：");
            string StuPhone = Console.ReadLine();

            Dormitory dormitory = new Dormitory
            {
                Name = StuName,
                ID = StuID,
                Phone = StuPhone

            };
            dormitories.Add(dormitory);
            Console.WriteLine("已存入学生信息。");
        }
        public static void ModifyStudent()
        {
            Console.WriteLine("---------------------------------");
            Console.Write("请输入要修改的学生的学号: ");
            string searchStudentID = Console.ReadLine();

            Dormitory student = dormitories.FirstOrDefault(s => s.ID == searchStudentID);
            if (student == null)
            {
                Console.WriteLine("此学号不存在。");
                return;
            }

            Console.WriteLine("请选择要修改的信息: 1.姓名 2.学号 3.手机号");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("请输入新的姓名: ");
                    student.Name = Console.ReadLine();
                    break;
                case "2":
                    Console.Write("请输入新的学号: ");
                    student.ID = Console.ReadLine();
                    break;
                case "3":
                    Console.Write("请输入新的手机号: ");
                    student.Phone = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("无效的选择。");
                    break;
            }

            Console.WriteLine("已修改学生信息。");
        }
        public static void RemoveStudent()
        {
            Console.Write("请输入要删除的学生的学号: ");
            string searchStudentID = Console.ReadLine();

            Dormitory student = dormitories.FirstOrDefault(s => s.ID == searchStudentID);
            if (student == null)
            {
                Console.WriteLine("未找到此学号。");
                return;
            }

            dormitories.Remove(student);
            Console.WriteLine("已删除学生信息。");
        }
        public static void QueryAllStudent()
        {
            if (dormitories.Count == 0)
            {
                Console.WriteLine("没有可供展示的学生信息。");
                return;
            }

            foreach (Dormitory student in dormitories)
            {
                Console.WriteLine($"姓名: {student.Name}");
                Console.WriteLine($"学号: {student.ID}");
                Console.WriteLine($"手机号: {student.Phone}");
                Console.WriteLine();  // 输出一个空行以分隔不同学生的信息
            }
        }
        public static void Quit()
        {
            Console.WriteLine("程序即将退出...");
            Environment.Exit(0);
        }
    }
    class Dormitory
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Phone { get; set; }
    }
}
