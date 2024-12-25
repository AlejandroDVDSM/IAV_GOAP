public class GA_Zombie : GAgent
{
    new void Start()
    {
        base.Start();
        
        SubGoal s2 = new SubGoal("InvokeZombie", 1, false);
        goals.Add(s2, 1);
    }
}
