    namespace Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zad1();
            Zad2();
            Zad3();
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
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("Doesnt exist");
            }

        }
        static void Zad3()
        {
            HashSet<string> list = new HashSet<string>();
            list = Console.ReadLine().Split(' ').Select(x => x.ToLower()).ToHashSet();
            Console.WriteLine($"The sentence has {list.Count} words and they are {String.Join(',', list)}");
        }
        static void Zad4()
        {

        }
    }
}
