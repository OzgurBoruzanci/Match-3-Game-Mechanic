using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

public class BaseShape : MonoBehaviour
{
    
    public Color shapeColor;
    public int shapePoint;

    public enum ObjectShape { Cube,Cylinder,Sphere,Capsule};
    public ObjectShape objectShape;
    GameObject createShape;
    bool clicked = false;
    bool matched = false;
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
            EventManager.OnClick(transform.gameObject,shapePoint);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
            clicked = false;
        }
    }

    

    private void ObjectShapeChoice()
    {
        switch (objectShape) 
        {
            case ObjectShape.Cube:
                createShape = GameObject.CreatePrimitive(PrimitiveType.Cube);
                transform.GetComponent<MeshFilter>().mesh = createShape.GetComponent<MeshFilter>().sharedMesh;
                transform.GetComponent<Renderer>().material.color = shapeColor;
                Destroy(createShape);
                break;
            case ObjectShape.Cylinder:
                createShape = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                transform.GetComponent<MeshFilter>().mesh = createShape.GetComponent<MeshFilter>().sharedMesh;
                transform.GetComponent<Renderer>().material.color = shapeColor;
                Destroy(createShape);
                break;
            case ObjectShape.Sphere:
                createShape = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                transform.GetComponent<MeshFilter>().mesh = createShape.GetComponent<MeshFilter>().sharedMesh;
                transform.GetComponent<Renderer>().material.color = shapeColor;
                Destroy(createShape);
                break;
            case ObjectShape.Capsule:
                createShape = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                transform.GetComponent<MeshFilter>().mesh = createShape.GetComponent<MeshFilter>().sharedMesh;
                transform.GetComponent<Renderer>().material.color = shapeColor;
                Destroy(createShape);
                break;
        }
    }
}
