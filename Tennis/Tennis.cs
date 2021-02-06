namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;
        private string _firstPlayerName;
        private string _secondPlayerName;

        private string _love;
        private string _fifteen;
        private string _thirty;
        private string _forty;

        private string _all = "all";
        private string _deuce = "deuce";

        public Tennis()
        {
            _firstPlayerName = "Joey";
            _secondPlayerName = "Tom";
        }

        public string Score()
        {
            _love = "love";
            _fifteen = "fifteen";
            _thirty = "thirty";
            _forty = "forty";
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 0)
            {
                return _love + " " + _all;
            }
            if (_firstPlayerScoreTimes == 1 && _secondPlayerScoreTimes == 0)
            {
                return _fifteen + " " + _love;
            }

            if (_firstPlayerScoreTimes == 2 && _secondPlayerScoreTimes == 0)
            {
                return _thirty + " " + _love;
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 0)
            {
                return _forty + " " + _love;
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 1)
            {
                return _love + " " + _fifteen;
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 2)
            {
                return _love + " " + _thirty;
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 3)
            {
                return _love + " " + _forty;
            }
            if (_firstPlayerScoreTimes == 1 && _secondPlayerScoreTimes == 1)
            {
                return _fifteen + " " + _all;
            }
            if (_firstPlayerScoreTimes == 2 && _secondPlayerScoreTimes == 2)
            {
                return _thirty + " " + _all;
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
