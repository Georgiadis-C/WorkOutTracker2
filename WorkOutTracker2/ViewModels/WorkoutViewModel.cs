using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WorkOutTracker2.Models;

namespace WorkOutTracker2.ViewModels;

public partial class WorkoutViewModel : ObservableObject
{
    public ObservableCollection<WorkOutDay> WorkOutDays { get; set; } = [];

    [ObservableProperty]
    string workoutDate;

    [ObservableProperty]
    string _exerciseName;

    [ObservableProperty]
    private int _sets;

    [ObservableProperty]
    private int _repetitions;

    [RelayCommand]
    private void AddWorkoutDay()
    {
        if (!string.IsNullOrWhiteSpace(WorkoutDate))                // Eπαλήθευση αν η ημερομηνία της προπόνησης δεν είναι κενή
        {
            WorkOutDays.Add(new WorkOutDay { Date = WorkoutDate });
            WorkoutDate = string.Empty;
        }
    }

    [RelayCommand]
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
