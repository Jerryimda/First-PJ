using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jerrybaring1.Models
{
    public class Seminar
    {
        public Seminar(string? title, string? name, string? job, string? time)
        {
            Title = title;
            Name = name;
            Job = job;
            Time = time;
        }

        //이건 함수 아니고 변수.
        public string? Title { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }
        public string? Time { get; set; }
    }
}
