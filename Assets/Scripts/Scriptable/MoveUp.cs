using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Move Up")]

public class MoveUp : PositionWhenSelected
{
    public float distance = 1.5f;
    public float hight = 1.5f;

    public override void positionOnClicked(BaseShape baseShape)
    {
        baseShape.transform.position = new Vector3(baseShape.transform.position.x, baseShape.transform.position.y + hight, baseShape.transform.position.z - distance);
    }
}
