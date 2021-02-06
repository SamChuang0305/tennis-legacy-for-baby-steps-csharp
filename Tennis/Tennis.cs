using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;
        private string _firstPlayerName;
        private string _secondPlayerName;

        private string _all = "all";
        private string _deuce = "deuce";

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
        {
            { 0, "love" },
            { 1, "fifteen" },
            { 2, "thirty" },
            { 3, "forty" },
        };

        public Tennis()
        {
            _firstPlayerName = "Joey";
            _secondPlayerName = "Tom";
        }

        public string Score()
        {
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 0)
            {
                return scoreLookup[_firstPlayerScoreTimes] + " " + _all;
            }
            if (_firstPlayerScoreTimes < 4 && _secondPlayerScoreTimes == 0)
            {
                return scoreLookup[_firstPlayerScoreTimes] + " " + scoreLookup[_secondPlayerScoreTimes];
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes < 4)
            {
                return scoreLookup[_firstPlayerScoreTimes] + " " + scoreLookup[_secondPlayerScoreTimes];
            }
            if (_firstPlayerScoreTimes == 1 && _secondPlayerScoreTimes == 1)
            {
                return scoreLookup[_firstPlayerScoreTimes] + " " + _all;
            }
            if (_firstPlayerScoreTimes == 2 && _secondPlayerScoreTimes == 2)
            {
                return scoreLookup[_firstPlayerScoreTimes] + " " + _all;
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 3)
            {
                return _deuce;
            }
            if (_firstPlayerScoreTimes == 4 && _secondPlayerScoreTimes == 4)
            {
                return _deuce;
            }
            if (_firstPlayerScoreTimes == 4 && _secondPlayerScoreTimes == 3)
            {
                return _firstPlayerName + " adv";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 4)
            {
                return _secondPlayerName + " adv";
            }
            if (_firstPlayerScoreTimes == 5 && _secondPlayerScoreTimes == 3)
            {
                return _firstPlayerName + " win";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 5)
            {
                return _secondPlayerName + " win";
            }
            return null;
        }

        public void firstPlayerScore()
        {
            this._firstPlayerScoreTimes++;
        }

        public void secondPlayerScore()
        {
            this._secondPlayerScoreTimes++;
        }
    }
}
