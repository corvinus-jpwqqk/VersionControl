using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week08.Abstractions;

namespace week08.Entities
{
    class Ball : Toy
    {
        protected override void DrawImage(Graphics gIn)
        {
            gIn.FillEllipse(new SolidBrush(Color.Blue), 0, 0, this.Width, this.Height);
        }
    }
}
