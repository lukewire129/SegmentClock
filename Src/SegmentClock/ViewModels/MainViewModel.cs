using System;
using System.Timers;
using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace SegmentClock.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string hour0;
    [ObservableProperty] private string hour1;
    [ObservableProperty] private string min0;
    [ObservableProperty] private string min1;

    public MainViewModel()
    {
    

        var tm = new Timer();
        tm.Interval = 1000;
        tm.Elapsed += (sender, args) =>
        {
            var time = DateTime.Now.ToString("HH:mm");

            var timeHour = time.Split(":")[0];
            var timeMin = time.Split(":")[1];

            Hour0 = timeHour[0].ToString();
            Hour1 = timeHour[1].ToString();
            Min0 = timeMin[0].ToString();
            Min1 = timeMin[1].ToString();

        };
        tm.Start();
    }
}