using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GACT_DestroyGravestone : GAction
{
    private Gravestone _currentGravestone;
    
    public override bool PrePerform()
    {
        // Get a random destroyed gravestone
        List<Gravestone> gravestones = GWorld.Gravestones.Where(g => g.IsDestroyed() == false).ToList();
        
        if (gravestones.Count > 0)
            target = gravestones[Random.Range(0, gravestones.Count)].gameObject;
        else
            target = null;
        
        // target = GWorld.Gravestones.FirstOrDefault(g => g.GetComponent<Gravestone>().IsDestroyed() == false)?.gameObject;

        if (target)
            _currentGravestone = target.GetComponent<Gravestone>();
        else
            return false;
        
        return true;
    }

    public override bool PostPerform()
    {
        if (_currentGravestone != null)
        {
            _currentGravestone.DestroyGravestone();
            GWorld.Gravestones.Remove(_currentGravestone);
            _currentGravestone = null;
            
            GA_Zombie randomZombie = GWorld.Zombies[Random.Range(0, GWorld.Zombies.Count)];
            GWorld.Zombies.Remove(randomZombie);
            Destroy(randomZombie.gameObject);

            beliefs.ModifyState("IsRested", -1);
            if (!beliefs.HasState("IsRested"))
                beliefs.SetState("IsExhausted", 0);
                
        }
        
        return true;
    }
}
