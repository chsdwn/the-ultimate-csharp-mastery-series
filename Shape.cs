using System;

namespace ultimate_csharp_mastery
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copied");
        }

        public void Select()
        {
            Console.WriteLine("Selected");
        }
    }
}