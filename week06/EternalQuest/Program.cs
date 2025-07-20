// Exceeding Requirements:
// - Added Leveling System: Gain a new level 
//   every 1000 points.
// - Added Achievements/Badges: Earn badges for 
//   milestones like creating your first goal, 
//   scoring over 1000 points, and completing 
//   all goals.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

