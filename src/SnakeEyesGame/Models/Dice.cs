using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SnakeEyesGame.Models
{
    public class Dice
    {
        private int _pips;
        private static Random _random;

        public Dice()
        {
            _random = new Random();
            Roll();
        }

        [JsonProperty]
        public int Pips
        {
            get { return _pips; }
        }

        public void Roll()
        {
            _pips = _random.Next(1, 7);
        }
    }
}
