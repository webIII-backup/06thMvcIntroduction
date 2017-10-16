using Newtonsoft.Json;
using System;

namespace SnakeEyesGame.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SnakeEyes
    {
        #region Fields
        private Dice _eye1;
        private Dice _eye2;
        #endregion

        #region Properties
        [JsonProperty]
        public int  Total {get; private set; }
        [JsonProperty]
        public int Eye1 { get { return _eye1.Pips; }  }
        [JsonProperty]
        public int Eye2 { get { return _eye2.Pips; } }
        #endregion

        #region Constructor
        public SnakeEyes()
        {
            _eye1 = new Dice();
            _eye2 = new Dice();
            Total = 0;
        }
        #endregion

        #region Methods
        public void Play()
        {
            _eye1.Roll();
            _eye2.Roll();
            if (Eye1 == 1 && Eye2 == 1)
                Total = 0;
            else
                Total += Eye1 + Eye2;

        }
        #endregion
    }
}