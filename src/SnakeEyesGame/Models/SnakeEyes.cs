using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SnakeEyesGame.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SnakeEyes
    {
        [JsonProperty]
        private Dice _eye1;
        [JsonProperty]
        private Dice _eye2;

        public SnakeEyes()
        {
            _eye1 = new Dice();
            _eye2 = new Dice();
            Total = 0;

        }

        [JsonProperty]
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
