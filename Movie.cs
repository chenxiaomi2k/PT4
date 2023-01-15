using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest4
{
    internal class Movie : IMovie
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get => name; 
            set => name = value; 
        }
        private DateTime publishDate;
        public DateTime PublishDate
        {
            get => publishDate;
            set => publishDate = value;
        }
        private string director;
        public string Director
        {
            get => director;
            set => director = value;
        }
        private string subtitle;
        public string Subtitle
        {
            get => subtitle; 
            set => subtitle = value;
        }

        public float AvarageRate { get; }

        public Movie()
        {
            Id = 1;
        }

        public Movie(string name, DateTime publishDate, string director, string subtitle, float avg)
        {
            Name = name;
            PublishDate = publishDate;
            Director = director;
            Subtitle = subtitle;
            AvarageRate = avg;
        }

        public void display()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("PublishDate: {0}", PublishDate);
            Console.WriteLine("Director: {0}", Director);
            Console.WriteLine("Language: {0}", Subtitle);
            Console.WriteLine("AvarageRate: {0}", AvarageRate);
        }

        double[] RateList = new double[3];

        public double this[int i]
        {
            get => RateList[i];
            set => RateList[i] = value;
        }

        public float calculate()
        {
            double sum = 0;
            for (int i = 0; i < RateList.Length; i++)
            {
                sum += RateList[i];
            }
            return (float)sum / 3;
        }
    }
}
