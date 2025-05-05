namespace WorkOutTracker2.Models;

//EDW PANTW PUBLIC TO MODELS
public class WorkOutDay
{
    public string Date { get; set; }
    public List<Exercise> Exercises { get; set; } = new();
}
