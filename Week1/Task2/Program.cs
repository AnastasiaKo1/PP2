using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        //создаем имя, айди и год обученияу студента
        public string Name { get; set; }
        public string Id { get; set; }
        public int Year { get; set; }

        //создаем конструктор, передающий имя и айди студента
        public Student(string Name, string Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
        //создаем конструктор для увеличения года обучения
        public void IncrementYear()
        {
            Year++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //передаем значения  - имя и айди, год
            Student st = new Student("Nastya", "18BD11090")
            {
                Year = 1
            };
            // выводим все данные
            Console.WriteLine("Name of student: " + st.Name + " ID: " + st.Id + " Course: " + st.Year);
            //вызываем функцию, увеличивающую год обучения
            st.IncrementYear();
            // выводим обновленные данные
            Console.WriteLine("Name of student: " + st.Name + " ID: " + st.Id + " Course: " + st.Year);
        }
    }
}

