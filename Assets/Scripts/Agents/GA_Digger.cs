public class GA_Digger : GAgent
{
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("PickShovel", 1, false);
        goals.Add(s1, 3);
        
        SubGoal s2 = new SubGoal("FillGrave", 1, false);
        goals.Add(s2, 5);
    }
}
