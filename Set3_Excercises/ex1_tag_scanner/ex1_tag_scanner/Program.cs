using System;
using System.Collections.Generic;

namespace ex1_tag_scanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tag> tagsToRead = new List<Tag> { new Tag("Employee1"), new Tag("Employee3"), new Tag("Employee3"), new Tag("Employee3"), new Tag("Employee3"), new Tag("Employee10"), new Tag("Employee10"), new Tag("Employee10") };
            Scanner scanner = new Scanner();

            foreach (var tag in tagsToRead)
            {
                Console.WriteLine();
                scanner.ReadTag(tag);
                scanner.EvaluateTag();
            }
        }
    }
}
