namespace Tennis
{
    public class Tennis
    {
        private int _firstPlayerScoreTimes;
        private int _secondPlayerScoreTimes;

        public string Score()
        {
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 0)
            {
                return "love all";
            }
            if (_firstPlayerScoreTimes == 1 && _secondPlayerScoreTimes == 0)
            {
                return "fifteen love";
            }
            if (_firstPlayerScoreTimes == 2 && _secondPlayerScoreTimes == 0)
            {
                return "thirty love";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 0)
            {
                return "forty love";
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 1)
            {
                return "love fifteen";
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 2)
            {
                return "love thirty";
            }
            if (_firstPlayerScoreTimes == 0 && _secondPlayerScoreTimes == 3)
            {
                return "love forty";
            }
            if (_firstPlayerScoreTimes == 1 && _secondPlayerScoreTimes == 1)
            {
                return "fifteen all";
            }
            if (_firstPlayerScoreTimes == 2 && _secondPlayerScoreTimes == 2)
            {
                return "thirty all";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 3)
            {
                return "deuce";
            }
            if (_firstPlayerScoreTimes == 4 && _secondPlayerScoreTimes == 4)
            {
                return "deuce";
            }
            if (_firstPlayerScoreTimes == 4 && _secondPlayerScoreTimes == 3)
            {
                return "Joey adv";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 4)
            {
                return "Tom adv";
            }
            if (_firstPlayerScoreTimes == 5 && _secondPlayerScoreTimes == 3)
            {
                return "Joey win";
            }
            if (_firstPlayerScoreTimes == 3 && _secondPlayerScoreTimes == 5)
            {
                return "Tom win";
            }
            return null;
        }

        public void firstPlayerScore()
        {
            _firstPlayerScoreTimes++;
        }

        public void secondPlayerScore()
        {
            _secondPlayerScoreTimes++;
        }
    }
}
