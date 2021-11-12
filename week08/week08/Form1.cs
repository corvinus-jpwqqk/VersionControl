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
using week08.Abstractions;

namespace week08
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        private IToyFactory _factory;
        Toy _nextToy;
        
        private IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value;
                DisplayNext();
            }
        }
        
        public Form1()
        {
            InitializeComponent();
            Factory = new CarFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            Toy newToy = Factory.CreateNew();
            _toys.Add(newToy);
            panel1.Controls.Add(newToy);
            newToy.Left = -newToy.Width;
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var firstBallPos = 0;
            foreach(var ball in _toys)
            {
                ball.MoveToy();
                if (ball.Left > firstBallPos)
                {
                    firstBallPos = ball.Left;
                }
            }
            if (firstBallPos > 1000)
            {
                var deleteBall = _toys[0];
                panel1.Controls.Remove(deleteBall);
                _toys.Remove(deleteBall);
            }
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void buttonBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory
            {
                BallColor = buttonBallColor.BackColor
            };
            
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            Controls.Add(_nextToy);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = button.BackColor;
            if(cd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            button.BackColor = cd.Color;
        }

        private void buttonPresent_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory
            {
                Color1 = buttonPresentColor1.BackColor,
                Color2 = buttonPresentColor2.BackColor
        };
        }

        private void buttonPresentColor1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = button.BackColor;
            if (cd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            button.BackColor = cd.Color;
        }

        private void buttonPresentColor2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = button.BackColor;
            if (cd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            button.BackColor = cd.Color;
        }
    }
}
