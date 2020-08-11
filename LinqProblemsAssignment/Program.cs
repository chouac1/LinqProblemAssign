using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqProblemsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            ////---------------------------------------- Question 1 ----------------------------------------

            //var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //var wordsWithTh = words.Where(w => w.Contains("th"));
            //foreach (var word in wordsWithTh)
            //{
            //    Console.WriteLine(word);
            //    Console.ReadLine();
            //}

            //////---------------------------------------- Question 2 ----------------------------------------
            //var names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            //var noDuplicateNames = names.Distinct();
            //foreach (var name in noDuplicateNames)
            //{
            //    Console.WriteLine(name);
            //    Console.ReadLine();
            //}

            //---------------------------------------- Question 3 ----------------------------------------
            var classGrades = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            var classGrades1 = classGrades.Select(g => g.Split(',')).ToList();
            var classGrades2 = classGrades1.Select(g => g.Select(h => int.Parse(h)).ToList()).ToList(); //'sort,' drop the lowest value
            var sortedList = classGrades2.Select(h => h.OrderBy(i => i).ToList()).ToList();

            //---------------------------------------- Test ----------------------------------------

            //var list = new List<int> { 5, 4, 3, 7, 9, 8, 6, 1, 0, 2 };
            //var sortedList = list.OrderBy(a => a);
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine(item);
            //    Console.ReadLine();
            //}


        }
    }
}
