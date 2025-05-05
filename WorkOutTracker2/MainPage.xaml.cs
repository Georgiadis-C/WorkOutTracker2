using WorkOutTracker2.ViewModels;

namespace WorkOutTracker2;
public partial class MainPage : ContentPage
{
        public MainPage(WorkoutViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
}
