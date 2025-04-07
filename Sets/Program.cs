    namespace Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zad1();
        }

        static void Zad1()
        {
            Console.WriteLine("Ex 1");
            Console.WriteLine("Enter numbers");
            HashSet<int> list = new HashSet<int>();
            list = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToHashSet();
            Console.WriteLine($"Uniques are: {String.Join(',', list)}");
        }
        static void Zad2()
        {

        }
        static void Zad3()
        {

        }
        static void Zad4()
        {

        }
    }
}
