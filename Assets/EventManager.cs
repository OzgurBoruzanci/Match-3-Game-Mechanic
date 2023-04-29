using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public static Action<BaseShape> OnClick;
    public static Action NotMatched;
    public static Action<int> ShapePoint;
    public static Action HealthDecreased;
}