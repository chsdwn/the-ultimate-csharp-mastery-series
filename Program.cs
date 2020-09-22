using System;

namespace ultimate_csharp_mastery
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras nec diam at tortor imperdiet laoreet. Nulla porttitor risus nec nulla eleifend, in bibendum lectus gravida. Vivamus at nunc dui.";
            var summary = post.Shorten(5);

            Console.WriteLine(summary + "...");
        }
    }
}
