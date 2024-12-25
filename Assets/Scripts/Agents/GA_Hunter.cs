using System;
using Random = UnityEngine.Random;

public class GA_Hunter : GAgent
{

    new void Start()
    {
        base.Start();
        
        beliefs.SetState("IsRested", Random.Range(1, 4));
        
        SubGoal s1 = new SubGoal("IsInGravestone", 1, false);
        goals.Add(s1, 3);
        
        SubGoal s2 = new SubGoal("IsRested", 1, false);
        goals.Add(s2, 1);
    }
}
