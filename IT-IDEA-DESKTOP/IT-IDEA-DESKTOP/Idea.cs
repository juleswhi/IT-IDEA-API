using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_IDEA_DESKTOP
{
    public class Idea
    {
        public static List<Idea> Ideas = new();
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Feasibility { get; set; }
    }
}
