using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GACT_FillGrave : GAction
{
    private Grave _currentGrave;
    
    public override bool PrePerform()
    {
        // Get a random unfilled grave
        List<GameObject> unfilledGraves = GWorld.Graves.Where(g => g.GetComponent<Grave>().IsFilled() == false).ToList();

        if (unfilledGraves.Count > 0)
            target = unfilledGraves[Random.Range(0, unfilledGraves.Count)];
        else
            target = null;
        
        // target = GWorld.Graves.FirstOrDefault(g => g.GetComponent<Grave>().IsFilled() == false);
        
        if (target)
            _currentGrave = target.GetComponent<Grave>();
        else
            return false;
        
        return true;
    }

    public override bool PostPerform()
    {
        if (_currentGrave != null)
        {
            // Substract one use of the shovel so if it reaches 0, it will have to pick up another shovel.
            beliefs.ModifyState("HasShovel", -1);
            _currentGrave.FillGrave();
            _currentGrave = null;
        }
        
        return true;
    }
}
