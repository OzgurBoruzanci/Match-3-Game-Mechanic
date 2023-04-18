using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Set Forward")]
public class SetForward : PositionWhenSelected
{
    public float distance = 2f;
    public override void PositionOnClicked(BaseShape baseShape)
    {
        baseShape.transform.position = new Vector3(baseShape.transform.position.x, baseShape.transform.position.y, baseShape.transform.position.z - distance);
    }
}
