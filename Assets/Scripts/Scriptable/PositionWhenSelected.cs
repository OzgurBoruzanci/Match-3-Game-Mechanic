using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PositionWhenSelected : ScriptableObject
{
    public abstract void PositionOnClicked(BaseShape baseShape);
}
