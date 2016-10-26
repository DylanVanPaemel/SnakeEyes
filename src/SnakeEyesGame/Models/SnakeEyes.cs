using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnakeEyesGame.Models
{
    public class SnakeEyes
    {
        private Dice _eye1;
        private Dice _eye2;

        public SnakeEyes()
        {
            _eye1 = new Dice();
            _eye2 = new Dice();
            Total = 0;

        }

        public int Total { get; private set; }

        public int Eye1 { get { return _eye1.Pips; } }
        public int Eye2 { get { return _eye2.Pips; } }

        public void Play()
        {
            _eye1.Roll();
            _eye2.Roll();
            if (Eye1 ==1 && Eye2 == 1)
            {
                Total = 0;
            }
            else
            {
                Total += Eye1 + Eye2;
            }
        }
    }
}
