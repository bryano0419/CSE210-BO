// Program.cs

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Run();
    }
}

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Run()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine($"\nCurrent Score: {_score}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": quit = true; break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
        Console.Write("Choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1": _goals.Add(new SimpleGoal(name, desc, points)); break;
            case "2": _goals.Add(new EternalGoal(name, desc, points)); break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default: Console.WriteLine("Invalid goal type."); break;
        }
    }

    private void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                sw.WriteLine(g.ToCSV());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            Goal g = Goal.FromCSV(lines[i]);
            if (g != null)
                _goals.Add(g);
        }

        Console.WriteLine("Goals loaded.");
    }

    private void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"You earned {earned} points!");
        }
    }
}

abstract class Goal
{
    protected string _name, _desc;
    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _desc = desc;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string ToCSV();

    public static Goal FromCSV(string line)
    {
        string[] parts = line.Split('|');
        switch (parts[0])
        {
            case "Simple": return new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
            case "Eternal": return new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
            case "Checklist": return new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                                                        int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
            default: return null;
        }
    }
}

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points, bool complete = false)
        : base(name, desc, points)
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string check = _isComplete ? "[X]" : "[ ]";
        return $"{check} {_name} ({_desc})";
    }

    public override string ToCSV() => $"Simple|{_name}|{_desc}|{_points}|{_isComplete}";
}

class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points) : base(name, desc, points) { }

    public override int RecordEvent() => _points;

    public override string GetStatus() => $"[∞] {_name} ({_desc})";

    public override string ToCSV() => $"Eternal|{_name}|{_desc}|{_points}";
}

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonus;
    private int _completed;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus, int completed = 0)
        : base(name, desc, points)
    {
        _targetCount = target;
        _bonus = bonus;
        _completed = completed;
    }

    public override int RecordEvent()
    {
        if (_completed < _targetCount)
        {
            _completed++;
            return _completed == _targetCount ? _points + _bonus : _points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        string check = _completed >= _targetCount ? "[X]" : "[ ]";
        return $"{check} {_name} ({_desc}) -- Completed: {_completed}/{_targetCount}";
    }

    public override string ToCSV() => $"Checklist|{_name}|{_desc}|{_points}|{_targetCount}|{_bonus}|{_completed}";
}
