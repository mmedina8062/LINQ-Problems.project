using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem one
            /*List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var selectedWords = words.Where(w => w.Contains("th"));
            foreach (var word in selectedWords)
            {
                Console.WriteLine(word);
            }*/


            //Problem two
            /*List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> distinct = names.Distinct().ToList();
            foreach(var name in distinct)
            {
                Console.WriteLine(name);
            }*/

            //Problem three
            /*     List<string> classGrades = new List<string>(){"80, 100, 92, 89, 65","93, 81, 78, 84, 69","73, 88, 83, 99, 64","98, 100, 66, 74, 55",};
                 var studentGrade = new List<int>();
                 double classGradeAverage = 0;

                 foreach (var grade in classGrades)
                 {
                     studentGrade = grade.Split(',').Select(g => int.Parse(g)).ToList();
                     var gradeValue = studentGrade.Where(s => s != studentGrade.Min()).Average();
                     classGradeAverage += gradeValue;
                 }
                 Console.WriteLine(classGradeAverage / classGrades.Count);*/



            //List<string> splitList = classGrades.Split(",").Where()
            //List<int> allNumbers = classGrades.SelectMany(x => x.Split(' ')).Select(int.Parse).ToList();


            //Problem Four
            var frequency = from f in "terrill".ToList()
                            group f by f into letterfrequency
                            orderby letterfrequency.Key
                            select letterfrequency;

            foreach (var f in frequency)
            {
                Console.WriteLine($"{f.Key}{f.Count()}");
            }






        }
    }
}
