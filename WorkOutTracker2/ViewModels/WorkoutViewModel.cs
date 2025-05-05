using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WorkOutTracker2.Models;

namespace WorkOutTracker2.ViewModels
{
    public class WorkoutViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<WorkOutDay> WorkOutDays { get; set; } = new();
        public ICommand AddWorkoutDayCommand { get; }                                  // Συνδέει τα κουμπιά στο XAML με τις μεθόδους του ViewModel.
        public ICommand AddExerciseCommand { get; }

        private string _workoutDate;
        public string WorkoutDate
        {
            get => _workoutDate;                                             // Αποθηκεύει την τιμή της ημερομηνίας της προπόνησης και 
            set { _workoutDate = value; OnPropertyChanged(); }               //                           επιτρέπει στο UI να ενημερωθεί αυτόματα όταν αλλάζει η τιμή.
        }

        private string _exerciseName;
        public string ExerciseName
        {
            get => _exerciseName;
            set { _exerciseName = value; OnPropertyChanged(); }
        }

        private int _sets;
        public int Sets
        {
            get => _sets;
            set { _sets = value; OnPropertyChanged(); }
        }

        private int _repetitions;
        private ObservableCollection<WorkOutDay> workOutDays = new();
        private ObservableCollection<WorkOutDay> workOutDays1 = new();

        public int Repetitions
        {
            get => _repetitions;
            set { _repetitions = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public WorkoutViewModel()
        {
            AddWorkoutDayCommand = new Command(AddWorkoutDay);           // Αρχικοποιεί τις εντολές AddWorkoutDayCommand και AddExerciseCommand και
            AddExerciseCommand = new Command(AddExercise);               //                                     συνδέει τις εντολές με τις αντίστοιχες μεθόδους
        }

        private void AddWorkoutDay()
        {
            if (!string.IsNullOrWhiteSpace(WorkoutDate))                // Eπαλήθευση αν η ημερομηνία της προπόνησης δεν είναι κενή
            {
                WorkOutDays.Add(new WorkOutDay { Date = WorkoutDate });
                WorkoutDate = string.Empty;
            }
        }

        private void AddExercise()                                                       // // Προσθήκη νέας άσκησης στην τελευταία ημέρα προπόνησης
        {
            if (WorkOutDays.Count > 0 && !string.IsNullOrWhiteSpace(ExerciseName))
            {
                WorkOutDays[^1].Exercises.Add(new Exercise { Name = ExerciseName, Sets = Sets, Repetitions = Repetitions });
                ExerciseName = string.Empty;
                Sets = 0;
                Repetitions = 0;
            }
        }
    }
}
