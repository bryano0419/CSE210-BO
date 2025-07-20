public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals never complete
    }

    public override string GetStatus()
    {
        return "[∞] " + _name + " - " + _description;
    }

    public override string GetSaveString()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}
