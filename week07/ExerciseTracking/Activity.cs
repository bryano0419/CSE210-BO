public abstract class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date} Activity ({_minutes} min): Distance {GetDistance():0.0} miles, " +
               $"Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
