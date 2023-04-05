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
        shapeInfo.shapeMesh = transform.GetComponent<MeshFilter>().sharedMesh;
        transform.GetComponent<Renderer>().material.color = shapeInfo.shapeColor;
    }


    private void OnMouseDown()
    {
        if (!clicked)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);
            clicked = true;
            EventManager.OnClick(transform.GetComponent<BaseShape>(), shapeInfo.shapePoint);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
            clicked = false;
        }
    }

}

[Serializable]
public struct ShapeInfo
{
    public Mesh shapeMesh;
    public Color shapeColor;
    
    public int shapePoint;

}