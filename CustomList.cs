using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest4
{
    internal class CustomList : IEnumerable
    {
        public ArrayList MovieList { get; set; }

        public CustomList()
        {
            MovieList = new ArrayList();
        }

        public void add(IMovie movie)
        {
            movie.Id++;
            MovieList.Add(movie);
            Console.WriteLine("Add movie successful!");
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)MovieList).GetEnumerator();
        }

        public void remove()
        {
            Console.Write("Enter movie name: ");
            string name = Console.ReadLine();
            foreach (IMovie m in MovieList)
            {
                if (name.Equals(m.Name))
                {
                    MovieList.Remove(m);
                    Console.WriteLine("Delete movie successfull!");
                    break;
                }
                else
                {
                    Console.WriteLine("Movie {0} does not exist!");
                }
            }
        }
        
        public void sort(IComparer comp)
        {
            MovieList.Sort(comp);
        }
    }
}
