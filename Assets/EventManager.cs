using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public static Action OnClick;
    public static Action<Mesh,Color> LeftObject;
    public static Action<Mesh,Color> RightObject;
    public static Action Matched;
}