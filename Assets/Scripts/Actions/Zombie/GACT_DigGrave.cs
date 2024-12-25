using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GACT_DigGrave : GAction
{
    private Grave currentGrave;
    
    public override bool PrePerform()
    {
        // Get a random filled grave
        List<GameObject> filledGraves = GWorld.Graves.Where(g => g.GetComponent<Grave>().IsFilled()).ToList();

        if (filledGraves.Count > 0)
            target = filledGraves[Random.Range(0, filledGraves.Count)];
        else
            target = null;
        
        if (target)
            currentGrave = target.GetComponent<Grave>();
        else
            return false;
        
        return true;
    }

    public override bool PostPerform()
    {
        if (currentGrave != null)
        {
            currentGrave.DigGrave();
            currentGrave = null;
        }
        return true;
    }
}
