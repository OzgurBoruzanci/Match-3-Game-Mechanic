using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShape : MonoBehaviour
{
    
    public Color shapeColor;
    public int shapePoint;

    public enum ObjectShape { Cube,Cylinder,Sphere,Capsule};
    public ObjectShape objectShape;
    GameObject createShape;
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

    
    void Update()
    {
        //RaycastHit ates;
        //if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), out ates, Mathf.Infinity))
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up) * ates.distance, Color.green);
            
        //}
    }

    private void OnMouseDown()
    {
        if (!clicked)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 2);
            clicked = true;
            EventManager.OnClick(transform.gameObject);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);
            clicked = false;
        }
    }
    
    void FragmentationControl()
    {

    }
    private void ObjectShapeChoice()
    {
        switch (objectShape) 
        {
            case ObjectShape.Cube:
                createShape = GameObject.CreatePrimitive(PrimitiveType.Cube);
                transform.GetComponent<MeshFilter>().mesh = createShape.GetComponent<MeshFilter>().mesh;
                transform.GetComponent<Renderer>().material.color = shapeColor;
                Destroy(createShape);
                break;
            case ObjectShape.Cylinder:
                createShape = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                transform.GetComponent<MeshFilter>().mesh = createShape.GetComponent<MeshFilter>().mesh;
                transform.GetComponent<Renderer>().material.color = shapeColor;
                Destroy(createShape);
                break;
            case ObjectShape.Sphere:
                createShape = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                transform.GetComponent<MeshFilter>().mesh = createShape.GetComponent<MeshFilter>().mesh;
                transform.GetComponent<Renderer>().material.color = shapeColor;
                Destroy(createShape);
                break;
            case ObjectShape.Capsule:
                createShape = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                transform.GetComponent<MeshFilter>().mesh = createShape.GetComponent<MeshFilter>().mesh;
                transform.GetComponent<Renderer>().material.color = shapeColor;
                Destroy(createShape);
                break;
        }
    }
}
