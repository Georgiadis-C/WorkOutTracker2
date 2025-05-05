using WorkOutTracker2.ViewModels;

namespace WorkOutTracker2;

public partial class WorkoutPage : ContentPage
{
    public WorkoutPage(WorkoutViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;                // ������ �� BindingContext ��� ������� ��� ViewModel ��� ��������� ��� �� IoC container.
    }
}
