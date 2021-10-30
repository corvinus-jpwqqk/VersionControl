using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08.Abstractions;

namespace week08.Entities
{
    class Car : Toy
    {
        protected override void DrawImage(Graphics gIn)
        {
            Image imageFile = Image.FromFile("Images/car.png");
            gIn.DrawImage(imageFile, new Rectangle(0, 0, this.Width, this.Height));
        }
    }
}
