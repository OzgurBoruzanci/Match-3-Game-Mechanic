using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : BaseObject
{
    bool onClick = false;
    bool secondObjectOnClick = false;
    private void Start()
    {
        derivedObject = transform.gameObject;
        firstPosition = transform.position;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                derivedObject = hit.transform.gameObject;
                if (!onClick && !secondObjectOnClick)
                {
                    ObjectFirstClick();
                    onClick = true;
                    //secondObjectOnClick = true;
                }
                else if (onClick && !secondObjectOnClick)
                {
                    ObjectLastClick();
                    onClick = false;
                }
                if (secondObjectOnClick && onClick)
                {
                    SecondObjectClick();
                    onClick = false;
                    secondObjectOnClick = false;
                }
            }
        }
    }
}
