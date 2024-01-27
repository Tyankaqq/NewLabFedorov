using Lesson4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    internal class Tiger:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Я ем мясо");
        }

        public override void Go()
        {
            Console.WriteLine("Я бегаю");
        }

        public override void Say()
        {
            Console.WriteLine("Я рычу");
        }
    }
}
