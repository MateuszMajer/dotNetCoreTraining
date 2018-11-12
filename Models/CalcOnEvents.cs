namespace NET_Core_Training.Models
{
    public class CalcOnEvents
    {
        public delegate double DCalc(int FirstValue, int SecondValue);
        public event DCalc CalcEvent;

        public void ExecuteEvent()
        {
            CalcEvent?.Invoke(1, 3);
        }
    }

    public class CalcOperations
    {
        public int AddValues(int FirstValue, int SecondValue)
        {
            return FirstValue+SecondValue;
        }
        public int SubValues(int FirstValue, int SecondValue)
        {
            return FirstValue-SecondValue;
        }
        public int MulValues(int FirstValue, int SecondValue)
        {
            return FirstValue*SecondValue;
        }
        public int DivValues(int FirstValue, int SecondValue)
        {
            return FirstValue/SecondValue;
        }
    }
}