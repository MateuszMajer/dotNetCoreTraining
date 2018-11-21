using System;

namespace dotNetCore.Models
{
    public class CalcOnEvents
    {
        public EventHandler<SettingsEventArgs> EventHandler;
        public void ExecuteEvent()
        {
            EventHandler?.Invoke(this, new SettingsEventArgs(20, 10));
        }
    }

    public class SettingsEventArgs:EventArgs
    {
        public int FirstValue { get; }
        public int SecondValue { get; }
        public SettingsEventArgs(int FirstV, int SecondV)
        {
            FirstValue=FirstV;
            SecondValue=SecondV;
        }
    }

    public class CalcOperations
    {
        public void CreateEvent()
        {
            var CalcOnEvents = new CalcOnEvents();
            CalcOnEvents.EventHandler += (s, e) => { Console.WriteLine($"Wynik dodawania: {e.FirstValue + e.SecondValue}."); };
            CalcOnEvents.EventHandler += (s, e) => { Console.WriteLine($"Wynik odejmowania: {e.FirstValue - e.SecondValue}."); };
            CalcOnEvents.EventHandler += (s, e) => { Console.WriteLine($"Wynik mnożenia: {e.FirstValue * e.SecondValue}."); };
            CalcOnEvents.EventHandler += (s, e) => { Console.WriteLine($"Wynik dzielenia: {e.FirstValue / (double)e.SecondValue}."); };
            CalcOnEvents.ExecuteEvent();
        }
    }
}