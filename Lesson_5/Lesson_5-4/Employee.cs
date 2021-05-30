using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_4
{
    class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public string Patronymic { get; }
        public int Age { get; }
        private Post post;
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Employee(string name, string surname, string patronymic, string email, string phoneNumber, int age, Post job)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            PhoneNumber = phoneNumber;
            Age = age;
            post = job;
        }


        public void EmployeeInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Сотрудник:");
            Console.ResetColor();
            Console.WriteLine($"\n{Surname} {Name} {Patronymic} {Age}\n{this.post.JobTitle} с зарплатой {this.post.Income} \n{Email} {PhoneNumber}");
        }

    }

    class Post
    {
        private double income;
        private int workExperience = 0;

        public string JobTitle { get; set; }
        public double Income 
        {
            get { return income; }

            set
            {
                income = value * (1 + workExperience / 100);
            }
        }
        public int WorkExperience 
        { 
            get
            {
                return workExperience;
            }
            set
            {
                if (value <= 0)
                {
                    workExperience = 0;
                }
                else
                {
                    workExperience = value;
                }
            }
        }

        public Post (double income, string jobTitle) : this(0,income, jobTitle)
        {

        }

        public Post (int workExperience, double income, string jobTitle)
        {
            WorkExperience = workExperience;
            Income = income;
            JobTitle = jobTitle;
        }

    }
}
