using System.Linq;
using UnityEngine;

public class GACT_PickShovelUp : GAction
{
    public override bool PrePerform()
    {
        // Set the closest shovel as the target
        target = GWorld.Shovels.OrderBy(s => Vector3.Distance(s.transform.position, transform.position)).First();
        return true;
    }

    public override bool PostPerform()
    {
        beliefs.ModifyState("HasShovel", 3);
        return true;
    }
}
