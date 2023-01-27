﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADO2023.Task07.Ex01
{
    internal class Program
    {
        public class Student
        {
            public string First { get; set; }
            public string Last { get; set; }
            public int ID { get; set; }
            public List<int> Scores;
        }

        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Andrew", Last="Daniels", ID=113, Scores= new List<int> {68, 72, 95, 50}},
            new Student {First="Paul", Last="Marks", ID=114, Scores= new List<int> {80, 70, 68, 90}},
            new Student {First="Dan", Last="Hopper", ID=115, Scores= new List<int> {70, 95, 70, 60}},
            new Student {First="Bill", Last="Gates", ID=116, Scores= new List<int> {75, 85, 60, 95}},
            new Student {First="Sarah", Last="Johns", ID=117, Scores= new List<int> {86, 89, 86, 60}},
            new Student {First="Daniel", Last="Price", ID=118, Scores= new List<int> {75, 65, 91, 40}},
            new Student {First="Sam", Last="Royf", ID=119, Scores= new List<int> {75, 60, 86, 39}},
            new Student {First="Roman", Last="Shapiro", ID=120, Scores= new List<int> {86, 70, 75, 70}},
            new Student {First="Liam", Last="Oren", ID=121, Scores= new List<int> {96, 84, 91, 95}},
            new Student {First="Carl", Last="Brown", ID=122, Scores= new List<int> {54, 86, 91, 40}},
            new Student {First="Jack", Last="Kolins", ID=123, Scores= new List<int> {91, 70, 60, 70}}
        };

        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery =
                from student in students
                where student.Scores[0] > 90
                select student;
            foreach (Student student in studentQuery)
            {
                Console.WriteLine("{0}, {1}", student.Last, student.First);
            }
        }
    }
}
