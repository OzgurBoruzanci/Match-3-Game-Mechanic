using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public static Action<GameObject,int> OnClick;
    public static Action NotMatched;
    public static Action<int> ShapePoint;
}