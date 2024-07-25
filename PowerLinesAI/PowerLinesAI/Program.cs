//Load sample data
using PowerLinesAI;

var sampleData = new ResultModel.ModelInput()
{
    Division = @"E0",
    HomeTeam = @"Aston Villa",
    AwayTeam = @"QPR",
};

//Load model and predict output
var result = ResultModel.Predict(sampleData);

var resultDictionary = new Dictionary<string, string>()
{
    { "H", "Home win" },
    { "A", "Away win" },
    { "D", "Draw" }
};

Console.WriteLine($"Predicted result for {sampleData.HomeTeam} v {sampleData.AwayTeam} is {resultDictionary[result.PredictedLabel]}");
