//Load sample data
using Moment4;

var sampleData = new SentimentAnalysis.ModelInput()
{
    Col0 = @"Place is clean. ",
};

//Load model and predict output
var result = SentimentAnalysis.Predict(sampleData);
var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine(sentiment);