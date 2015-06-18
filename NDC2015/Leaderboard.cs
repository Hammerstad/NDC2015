using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;


namespace NDC2015
{
    public class Leaderboard
    {
        public const string ElapsedFormatString = @"hh\:mm\:ss\:fff";

        public string CreateHTML(List<Score> scores, int latestContestant = 0)
        {
            const string Header = "<html><head><META HTTP-EQUIV=\"refresh\" CONTENT=\"10\"/><link rel=\"stylesheet\" type =\"text / css\" href =\"leaderboard.css\" media =\"screen\" /></head><body><h1>Leaderboard</h1><table style = \"width:100%\">";
            var body = new StringBuilder();
            for (int i = 0; i < scores.Count; i++)
            {
                var position = i + 1;
                string rowClass = position == latestContestant ? "id=\"selected\"" : "";
                var score = scores[i];
                body.Append("<tr ");
                body.Append(rowClass);
                body.Append("><td align=\"right\" style=\"width: 80px\">");
                body.Append(position);
                body.Append(".</td><td>");
                body.Append(score.ContestantName);
                body.Append("</td><td align=\"center\" style=\"width: 250px\">");
                body.Append(score.FriendlyElapsedTime);
                body.AppendLine("</td></tr>");
            }
            const string Footer = "</table></body></html>";
            return Header + body + Footer;
        } 
    }
}