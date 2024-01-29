namespace CSharpLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name:");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter your student ID:");
            int Studentid = Int32.Parse(Console.ReadLine());
            int n = Studentid % 10000;
            Console.WriteLine($"Your mail ID is {FirstName[0]}.{LastName}{n}.conestogac.on.ca".ToLower());
        }
    }
}
