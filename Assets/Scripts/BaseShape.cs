using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;
using System;

public class BaseShape : MonoBehaviour
{
    public ShapeInfo shapeInfo;

    bool clicked = false;
    Vector3 firstPosition;

    [SerializeField]
    PositionWhenSelected positionWhenSelected;
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
        transform.position=firstPosition;
        clicked = false;
    }

    void Start()
    {
        firstPosition= transform.position;
        transform.GetComponent<Renderer>().material.color = shapeInfo.shapeColor;
    }


    private void OnMouseDown()
    {
        if (!clicked)
        {
            positionWhenSelected.PositionOnClicked(transform.GetComponent<BaseShape>());
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
    
    public int shapePoint;

    public enum ObjectShape { Cube, Cylinder, Sphere, Capsule };
    public ObjectShape objectShape;
}