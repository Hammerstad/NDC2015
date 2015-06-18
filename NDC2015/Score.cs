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

        public TimeSpan ElapsedTime { get; set; }
        public string ContestantName { get; set; }
        public string Phone;

        public string FriendlyElapsedTime => ElapsedTime.ToString(Leaderboard.ElapsedFormatString);
    }
}