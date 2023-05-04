using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using System;

public class BaseShape : MonoBehaviour,IClickable
{
    public ShapeInfo shapeInfo;

    bool clicked = false;
    Vector3 firstPosition;
    public ShapeScriptableOnject shapeScriptable;

    private void OnEnable()
    {
        EventManager.NotMatched += NotMatched;
    }
    private void OnDisable()
    {
        EventManager.NotMatched -= NotMatched;
    }
    
    void NotMatched()
    {
        transform.position= firstPosition;
        clicked = false;
    }

    void Start()
    {
        firstPosition= transform.position;
        transform.GetComponent<Renderer>().material.color = shapeInfo.shapeColor;
    }

    //private void OnMouseDown()
    //{
    //    Click();
    //}

    public void Click()
    {
        if (!clicked)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y-0.25f, transform.position.z - 3);
            clicked = true;
            EventManager.OnClick(transform.GetComponent<BaseShape>());
        }
        else
        {
            transform.position = firstPosition;
            clicked = false;
        }
    }
}

[Serializable]
public struct ShapeInfo
{
    public Color shapeColor;
    public enum ObjectShape { Cube, Cylinder, Sphere, Capsule };
    public ObjectShape objectShape;
}