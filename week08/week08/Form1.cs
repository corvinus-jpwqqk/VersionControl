using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week08.Entities;

namespace week08
{
    public partial class Form1 : Form
    {
        List<Ball> _balls = new List<Ball>();
        private BallFactory _factory;
        
        private BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }
        
        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            Ball newBall = Factory.CreateNew();
            _balls.Add(newBall);
            panel1.Controls.Add(newBall);
            newBall.Left = -newBall.Width;
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var firstBallPos = 0;
            foreach(var ball in _balls)
            {
                ball.MoveBall();
                if (ball.Left > firstBallPos)
                {
                    firstBallPos = ball.Left;
                }
            }
            if (firstBallPos > 1000)
            {
                var deleteBall = _balls[0];
                panel1.Controls.Remove(deleteBall);
                _balls.Remove(deleteBall);
            }
        }
    }
}
