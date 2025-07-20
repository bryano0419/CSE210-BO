public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
        }
    }

    public override string GetStatus()
    {
        return $"[{_currentCount}/{_targetCount}] {_name} - {_description}";
    }

    public override string GetSaveString()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonusPoints}|{_targetCount}|{_currentCount}";
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }
}
