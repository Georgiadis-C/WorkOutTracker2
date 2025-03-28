namespace WorkOutTracker2.Models
{
    internal class WorkOutDay
    {
        public string Date { get; set; }
        public List<Exercise> Exercises { get; set; } = new();
    }
}
