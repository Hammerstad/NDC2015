using System;

namespace NDC2015
{
    [Serializable]
    public struct Score
    {
        public Score(TimeSpan elapsedTime, string contestantName, string phone)
        {
            ElapsedTime = elapsedTime;
            ContestantName = contestantName;
            Phone = phone;
        }

        public readonly TimeSpan ElapsedTime;
        public readonly string ContestantName;
        public readonly string Phone;

        public string FriendlyElapsedTime
        {
            get { return ElapsedTime.ToString(Leaderboard.ElapsedFormatString); }
        }
    }
}