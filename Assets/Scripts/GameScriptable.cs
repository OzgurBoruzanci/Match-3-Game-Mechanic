using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New GameScriptableOnject", menuName = "GameScriptableOnject")]
public class GameScriptable : ScriptableObject
{
    public int healt;
    public int remainingHealth;
    public int totalScore;
}
