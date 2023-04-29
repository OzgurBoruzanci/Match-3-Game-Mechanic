using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameScriptable gameScriptable;
    void Update()
    {
        IsItHealthy();
    }

    private void MouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();
                if (clickable != null)
                {
                    clickable.Click();
                }
            }
        }
    }

    void IsItHealthy()
    {
        if (gameScriptable.remainingHealth>0)
        {
            MouseDown();
        }
        else
        {
            Debug.Log("****GAME OVER****");
        }
    }
}
