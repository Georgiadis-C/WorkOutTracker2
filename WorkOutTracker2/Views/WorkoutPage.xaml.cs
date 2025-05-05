using WorkOutTracker2.ViewModels;

namespace WorkOutTracker2;

public partial class WorkoutPage : ContentPage
{
    public WorkoutPage(WorkoutViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;                // Ορίζει το BindingContext της σελίδας στο ViewModel που παρέχεται από το IoC container.
    }
}
