using System.Linq;
using UnityEngine;

public class GACT_RecoverEnergy : GAction
{
    public override bool PrePerform()
    {
        target = GWorld.Pumpkins.OrderBy(s => Vector3.Distance(s.transform.position, transform.position)).First();
        return true;
    }

    public override bool PostPerform()
    {
        beliefs.ModifyState("IsRested", Random.Range(1, 3));
        return true;
    }
}
