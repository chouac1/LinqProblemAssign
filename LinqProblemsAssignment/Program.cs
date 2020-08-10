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

            //---------------------------------------- Question 1 ----------------------------------------

            //---------------------------------------- without LINQ ----------------------------------------
            //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //List<string> wordsWithTh = new List<string>();
            //foreach (var word in words)
            //{
            //    if (word.Contains("th"))
            //    {
            //        wordsWithTh.Add(word);
            //    }
            //}
            //foreach (var word in wordsWithTh)
            //{
            //    Console.WriteLine(word);
            //    Console.ReadLine();
            //}


            //---------------------------------------- with LINQ ----------------------------------------
            var words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTh = words.Where(w => w.Contains("th"));
            foreach (var word in wordsWithTh)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }

            //---------------------------------------- Question 2 ----------------------------------------
            var names = new List<string>
        }
    }
}
