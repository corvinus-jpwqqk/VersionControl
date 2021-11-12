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
        public SolidBrush BallColor { get; private set; }
        public bool directionRight;
        public Ball(Color color)
        {
            BallColor = new SolidBrush(color);
            directionRight = true;
        }
        protected override void DrawImage(Graphics gIn)
        {
            gIn.FillEllipse(BallColor, 0, 0, this.Width, this.Height);
        }
       
        protected override void ToyClick()
        {
            this.BallColor = new SolidBrush(Color.White);
            Invalidate();
            MessageBox.Show("Clicked on Ball");
        }
    }
}
