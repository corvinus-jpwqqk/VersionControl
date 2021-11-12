using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08.Entities;
using week08.Abstractions;
using System.Drawing;

namespace week08.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color Color1 {get; set;}
        public Color Color2 { get; set; }

        public Toy CreateNew()
        {
            return new Present(Color1, Color2);
        }
    }
}

