using static Moment4.SentimentAnalysis;

namespace Moment4
{
    internal class CommentAnalyzer
    {
        public static string AnalyzeSentiment(string comment)
        {
            var data = new SentimentAnalysis.ModelInput()
            {
                Col0 = comment,
            };

            var analyzedComment = SentimentAnalysis.Predict(data);
            var sentiment = analyzedComment.PredictedLabel == 1 ? "The comment has a positive senitment." : "The comment has a negative sentiment";
            return sentiment;
        }
    }
}
