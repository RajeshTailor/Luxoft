using MarkdownLog;
using System.Collections.Generic;
using System.Linq;


namespace LuxoftTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Element> elements = new List<Element> { 
                new Element {num = 1, age = 18, name = "Nick"},
                new Element {num = 2, age = 16, name = "Jhon"},
                new Element {num = 3, age = 21, name = "Eric"},
                new Element {num = 3, age = 21, name = "Mac"},
                new Element {num = 4, age = 25, name = "Bill"},
                new Element {num = 5, age = 30, name = "Ali"}
                };
            System.Console.WriteLine("Input Elements are:" + System.Environment.NewLine);
            PrintElements(elements);
            System.Console.WriteLine("Unique Output Elements are:" +System.Environment.NewLine);
            PrintElements(GetUniqueElements(elements));
            System.Console.ReadKey();
        }
        /// <summary>
        /// Return Unique ELements by Num and age > 20
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        static List<Element> GetUniqueElements(List<Element> elements)
        {
            var uniquenums = elements.Where(e => e.age > 20).GroupBy(x => x.num).Where(grp => grp.Count() == 1).Select(grp=>grp.Key).ToList();
            return elements.Where(x=>uniquenums.Contains(x.num)).ToList();
        }
        /// <summary>
        /// Method to print List in Table format
        /// </summary>
        /// <param name="elements"></param>
        static void PrintElements(List<Element> elements)
        {
            System.Console.WriteLine(elements.Select(s => new
                 {
                    Num = s.num,
                    Age = s.age,
                    Name = s.name
                 }).ToMarkdownTable());
            
        }
    }
}
