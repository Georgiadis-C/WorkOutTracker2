namespace WorkOutTracker2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("WorkoutPage", typeof(WorkoutPage));
        }
    }
}
