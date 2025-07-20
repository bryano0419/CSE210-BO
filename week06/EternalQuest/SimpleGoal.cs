public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override string GetStatus()
    {
        return (_isComplete ? "[X] " : "[ ] ") + _name + " - " + _description;
    }

    public override string GetSaveString()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }
}
