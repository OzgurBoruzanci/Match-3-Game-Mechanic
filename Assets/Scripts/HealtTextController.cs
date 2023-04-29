using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtTextController : MonoBehaviour
{
    Text healtText;
    public int healt=10;
    public GameScriptable gameScriptable;
    private void OnEnable()
    {
        EventManager.HealthDecreased += HealthDecreased;
    }
    private void OnDisable()
    {
        EventManager.HealthDecreased -= HealthDecreased;
    }

    void HealthDecreased()
    {
        gameScriptable.remainingHealth--;
        healtText.text =" Healt : "+ gameScriptable.remainingHealth;
    }

    void Start()
    {
        healtText = GetComponent<Text>();
        healtText.text = " Healt : " + gameScriptable.healt.ToString();
        gameScriptable.remainingHealth = healt;
    }

   
    void Update()
    {
        
    }
}
