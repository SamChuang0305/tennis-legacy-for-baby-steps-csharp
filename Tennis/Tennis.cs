using System;
using System.Collections.Generic;

namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;
        private string _firstPlayerName;
        private string _secondPlayerName;

        private Dictionary<int, string> scoreLookup = new Dictionary<int, string>
        {
            { 0, "love" },
            { 1, "fifteen" },
            { 2, "thirty" },
            { 3, "forty" },
        };

        public Tennis(string _firstPlayerName, string _secondPlayerName)
        {
            this._firstPlayerName = _firstPlayerName;
            this._secondPlayerName = _secondPlayerName;
        }

        public string Score()
        {
            return IsSameScore()
                ? IsDeuce()
                    ? "deuce" : SameScore()
                : IsLookupScore()
                    ? LookupScore() : GetAdvState();
        }

        private string GetAdvState()
        {
            return string.Format("{0} {1}", GetAdvPlayerName(), IsAdv() ? "adv" : "win");
        }

        private bool IsAdv()
        {
            return Math.Abs(_firstPlayerScoreTimes - _secondPlayerScoreTimes) == 1;
        }

        private string GetAdvPlayerName()
        {
            return _firstPlayerScoreTimes > _secondPlayerScoreTimes ? _firstPlayerName : _secondPlayerName;
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
            return scoreLookup[_firstPlayerScoreTimes] + " all";
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
