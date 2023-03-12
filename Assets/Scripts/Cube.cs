using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : ObjectProperties
{
    ObjectProperties objectProperties;
    Vector3 firstPosition;
    bool clicked = false;
    void Start()
    {
        firstPosition = transform.position;
        objectProperties = new ObjectProperties();
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !clicked)
        {
            objectProperties.ClicktTheObjectFirst();
            clicked = true;
        }
        if (Input.GetMouseButtonDown(0) && clicked)
        {
            objectProperties.ClicktTheObjectSecond(firstPosition);
            clicked = false;
        }
    }
}
