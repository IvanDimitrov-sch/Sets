    namespace Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();
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
            Console.WriteLine("Ex 2");
            Console.WriteLine("Enter names");
            HashSet<string> list = new HashSet<string>();
            list = Console.ReadLine().Split(' ').ToHashSet();
            Console.WriteLine("Enter name for searching");
            string name = Console.ReadLine();

            if (list.Contains(name))
            {
                Console.WriteLine("Exists")";
            }
            else
            {
                Console.WriteLine("Doesnt exist");
            }

        }
        static void Zad3()
        {

        }
        static void Zad4()
        {

        }
    }
}
