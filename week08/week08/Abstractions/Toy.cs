using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week08.Abstractions
{
    public abstract class Toy : Label
    {
        public Toy()
        {
            this.AutoSize = false;
            this.Width = 50;
            this.Height = 50;
            this.Paint += Toy_Paint;
            MouseClick += Toy_MouseClick;
        }

        private void Toy_MouseClick(object sender, MouseEventArgs e)
        {
            ToyClick();
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        protected abstract void DrawImage(Graphics gIn);
        protected abstract void ToyClick();
        public virtual void MoveToy()
        {
            this.Left += 1;
        }
    }
}
