namespace Lesson4
{
    internal abstract class Animal
    {
        public string? Name { get; set; }
        public int Year { get; set; }
        public double Weight { get; set; }
        public abstract void Go();
        public abstract void Eat();
        public abstract void Say();

        public override string? ToString()
        {
            return $"Меня зовут {Name}, мне {Year} лет, моя масса {Weight}";
        }
    }
}