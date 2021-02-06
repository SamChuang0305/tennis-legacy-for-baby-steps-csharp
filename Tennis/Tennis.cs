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
            if (IsSameScore())
            {
                if (IsDeuce())
                {
                    return _deuce;
                }
                return SameScore();
            }
            if (IsLookupScore())
            {
                return LookupScore();
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

        private bool IsLookupScore()
        {
            return _firstPlayerScoreTimes < 4 && _secondPlayerScoreTimes < 4;
        }

        private bool IsSameScore()
        {
            return _firstPlayerScoreTimes == _secondPlayerScoreTimes;
        }

        private bool IsDeuce()
        {
            return _firstPlayerScoreTimes >= 3;
        }

        private string SameScore()
        {
            return scoreLookup[_firstPlayerScoreTimes] + " " + _all;
        }

        private string LookupScore()
        {
            return scoreLookup[_firstPlayerScoreTimes] + " " + scoreLookup[_secondPlayerScoreTimes];
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
