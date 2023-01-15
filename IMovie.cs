using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressTest4
{
    internal interface IMovie
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime PublishDate { get; set; }
        string Director { get; set; }
        string Subtitle { get; set; }
        float AvarageRate { get; }

        void display();
    }
}
