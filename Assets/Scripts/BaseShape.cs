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
        ObjectShapeChoice();
    }


    private void OnMouseDown()
    {
        if (!clicked)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);
            clicked = true;
            EventManager.OnClick(transform.gameObject, shapeInfo.shapePoint);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
            clicked = false;
        }
    }

    

    private void ObjectShapeChoice()
    {
        switch (shapeInfo.objectShape) 
        {
            case ShapeInfo.ObjectShape.Cube:
                transform.GetComponent<MeshFilter>().mesh = shapeInfo.Cube.GetComponent<MeshFilter>().sharedMesh;
                transform.GetComponent<Renderer>().material.color = shapeInfo.shapeColor;
                break;
            case ShapeInfo.ObjectShape.Cylinder:
                transform.GetComponent<MeshFilter>().mesh = shapeInfo.Cylinder.GetComponent<MeshFilter>().sharedMesh;
                transform.GetComponent<Renderer>().material.color = shapeInfo.shapeColor;
                break;
            case ShapeInfo.ObjectShape.Sphere:
                transform.GetComponent<MeshFilter>().mesh = shapeInfo.Sphere.GetComponent<MeshFilter>().sharedMesh;
                transform.GetComponent<Renderer>().material.color = shapeInfo.shapeColor;
                break;
            case ShapeInfo.ObjectShape.Capsule:
                transform.GetComponent<MeshFilter>().mesh = shapeInfo.Capsule.GetComponent<MeshFilter>().sharedMesh;
                transform.GetComponent<Renderer>().material.color = shapeInfo.shapeColor;
                break;
        }
    }
}

[Serializable]
public struct ShapeInfo
{
    public GameObject Cube;
    public GameObject Cylinder;
    public GameObject Sphere;
    public GameObject Capsule;

    public Color shapeColor;
    
    public int shapePoint;
    
    public enum ObjectShape { Cube, Cylinder, Sphere, Capsule };
    public ObjectShape objectShape;
}