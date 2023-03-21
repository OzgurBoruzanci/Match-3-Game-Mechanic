using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public static Action<GameObject> OnClick;
    public static Action NotMatched;
}