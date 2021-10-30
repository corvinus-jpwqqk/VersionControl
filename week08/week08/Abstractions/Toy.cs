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
        }
        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }
        protected abstract void DrawImage(Graphics gIn);
        public virtual void MoveToy()
        {
            this.Left += 1;
        }
    }
}
