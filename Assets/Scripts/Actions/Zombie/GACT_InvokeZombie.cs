using UnityEngine;

public class GACT_InvokeZombie : GAction
{
    [SerializeField] private GA_Zombie zombiePrefab;
    
    public override bool PrePerform()
    {
        // We assign a fake target so the planner can perform this state
        target = gameObject;
        return true;
    }

    public override bool PostPerform()
    {
        Debug.Log($"Zombies: {GWorld.Zombies.Count} -- Gravestones: {GWorld.Zombies.Count}");
        
        // We can invoke more zombies as long as there are less zombies than graves
        if (GWorld.Zombies.Count < GWorld.Gravestones.Count)
        {
            GWorld.Zombies.Add(Instantiate(zombiePrefab));
            return true;
        }

        return false;
    }
}
