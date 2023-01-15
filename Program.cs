using ProgressTest4;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        int menu()
        {
            Console.WriteLine("1. Insert new movie");
            Console.WriteLine("2. View list of movie");
            Console.WriteLine("3. Sort movie by Avarage List");
            Console.WriteLine("4. Delete a movie");
            Console.WriteLine("5. Exit");
            while (true)
            {
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());
                if (choice >= 1 && choice <= 5)
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("Enter again!");
                }
            }
        }
        Movie m = new Movie();
        CustomList cl = new CustomList();

        while (true)
        {
            int choice = menu();
            switch (choice)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Publish date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.Write("Director: ");
                    string dir = Console.ReadLine();
                    Console.Write("Language: ");
                    string lang = Console.ReadLine();
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("Enter rating point {0}: ", i + 1);
                        m[i] = double.Parse(Console.ReadLine());
                    }
                    float avg = m.calculate();
                    IMovie movie = new Movie(name, date, dir, lang, avg);
                    cl.add(movie);
                    break;
                case 2:
                    foreach (Movie m1 in cl.MovieList)
                    {
                        m1.display();
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    cl.MovieList.Sort(new CustomSort());
                    foreach (Movie m1 in cl.MovieList)
                    {
                        m1.display();
                    }
                    break;
                case 4:
                    cl.remove();
                    break;
                case 5:
                    return;
            }
        }
    }
}