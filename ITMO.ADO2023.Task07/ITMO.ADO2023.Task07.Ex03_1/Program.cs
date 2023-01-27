using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADO2023.Task07.Ex03_1
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
            new Student {First="Andrew", Last="Garcia", ID=113, Scores= new List<int> {68, 72, 95, 50}},
            new Student {First="Paul", Last="Marks", ID=114, Scores= new List<int> {80, 70, 68, 90}},
            new Student {First="Dan", Last="Hopper", ID=115, Scores= new List<int> {93, 95, 70, 60}},
            new Student {First="Bill", Last="Garcia", ID=116, Scores= new List<int> {75, 85, 60, 95}},
            new Student {First="Sarah", Last="Johns", ID=117, Scores= new List<int> {86, 89, 86, 60}},
            new Student {First="Daniel", Last="Price", ID=118, Scores= new List<int> {75, 65, 91, 40}},
            new Student {First="Sam", Last="Royf", ID=119, Scores= new List<int> {95, 60, 86, 85}},
            new Student {First="Roman", Last="Shapiro", ID=120, Scores= new List<int> {86, 70, 75, 70}},
            new Student {First="Liam", Last="Oren", ID=121, Scores= new List<int> {96, 84, 91, 95}},
            new Student {First="Carl", Last="Garcia", ID=122, Scores= new List<int> {54, 86, 91, 40}},
            new Student {First="Jack", Last="Kolins", ID=123, Scores= new List<int> {91, 70, 60, 80}}
        };

        static void Main(string[] args)
        {
            var studentQuery6 =
                from student in students
                let totalScore = student.Scores[0] + student.Scores[1] +
                    student.Scores[2] + student.Scores[3]
                select totalScore;
            double averageScore = studentQuery6.Average();
            Console.WriteLine("Class average score = {0}", averageScore);

            IEnumerable<string> studentQuery7 =
                from student in students
                where student.Last == "Garcia"
                select student.First;

            Console.WriteLine("The Garcias in the class are:");
            foreach (string s in studentQuery7)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");

            var studentQuery8 =
                from student in students
                let x = student.Scores[0] + student.Scores[1] +
                    student.Scores[2] + student.Scores[3]
                where x > averageScore
                select new { id = student.ID, score = x };

            foreach (var item in studentQuery8)
            {
                Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
            }
        }
    }
}