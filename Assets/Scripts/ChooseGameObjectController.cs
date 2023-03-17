using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ChooseGameObjectController;

public class ChooseGameObjectController : MonoBehaviour
{
    public enum ObjectType { capsule, cube, cylinder, sphere };
    public ObjectType objectOne;
    public ObjectType objectTwo;
    public ObjectType objectThree;
    public ObjectType objectFour;

    public enum ObjectPoint { five,ten,fifteen,twenty};
    public ObjectPoint objecPointOne;
    public ObjectPoint objecPointTwo;
    public ObjectPoint objecPointThree;
    public ObjectPoint objecPointFour;

    public enum ObjectColor { black, blue, gray, green, red, white, yellow };
    public ObjectColor objectColorOne;
    public ObjectColor objectColorTwo;
    public ObjectColor objectColorThree;
    public ObjectColor objectColorFour;

    List<GameObject> createdObjects;
    GameObject createdObjectOne;
    GameObject createdObjectTwo;
    GameObject createdObjectThree;
    GameObject createdObjectFour;

    GameObject createdObjecClone;

    float distance = 0;
    void Start()
    {
        createdObjects = new List<GameObject>();
        ObjectTypeChoiceAndCreate();
        ObjectColorChoice();
        ObjectPointChoice();
        for (int i = 0; i < createdObjects.Count; i++)
        {
            createdObjects[i].transform.position = new Vector3(-4 + distance, 4, 0);
            distance += 2.5f;
        }
        distance = 0;
        createdObjects.Reverse();
        for (int i = 0; i < createdObjects.Count; i++)
        {
            createdObjecClone= Instantiate(createdObjects[i], new Vector3(-4 + distance, -2, 0), Quaternion.identity);
            createdObjecClone.transform.tag = "CloneObject";
            distance += 2.5f;
        }
    }

    
    void Update()
    {

    }

    private void ObjectTypeChoiceAndCreate()
    {
        switch (objectOne)
        {
            case ObjectType.capsule:
                createdObjectOne = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                createdObjectOne.AddComponent<Capsule>();
                createdObjects.Add(createdObjectOne);
                break;
            case ObjectType.cube:
                createdObjectOne = GameObject.CreatePrimitive(PrimitiveType.Cube);
                createdObjectOne.AddComponent<Cube>();
                createdObjects.Add(createdObjectOne);
                break;
            case ObjectType.cylinder:
                createdObjectOne = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                createdObjectOne.AddComponent<Cylinder>();
                createdObjects.Add(createdObjectOne);
                break;
            case ObjectType.sphere:
                createdObjectOne = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                createdObjectOne.AddComponent<Sphere>();
                createdObjects.Add(createdObjectOne);
                break;
        }
        switch (objectTwo)
        {
            case ObjectType.capsule:
                createdObjectTwo = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                createdObjectTwo.AddComponent<Capsule>();
                createdObjects.Add(createdObjectTwo);
                break;
            case ObjectType.cube:
                createdObjectTwo = GameObject.CreatePrimitive(PrimitiveType.Cube);
                createdObjectTwo.AddComponent<Cube>();
                createdObjects.Add(createdObjectTwo);
                break;
            case ObjectType.cylinder:
                createdObjectTwo = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                createdObjectTwo.AddComponent<Cylinder>();
                createdObjects.Add(createdObjectTwo);
                break;
            case ObjectType.sphere:
                createdObjectTwo = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                createdObjectTwo.AddComponent<Sphere>();
                createdObjects.Add(createdObjectTwo);
                break;
        }
        switch (objectThree)
        {
            case ObjectType.capsule:
                createdObjectThree = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                createdObjectThree.AddComponent<Capsule>();
                createdObjects.Add(createdObjectThree);
                break;
            case ObjectType.cube:
                createdObjectThree = GameObject.CreatePrimitive(PrimitiveType.Cube);
                createdObjectThree.AddComponent<Cube>();
                createdObjects.Add(createdObjectThree);
                break;
            case ObjectType.cylinder:
                createdObjectThree = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                createdObjectThree.AddComponent<Cylinder>();
                createdObjects.Add(createdObjectThree);
                break;
            case ObjectType.sphere:
                createdObjectThree = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                createdObjectThree.AddComponent<Sphere>();
                createdObjects.Add(createdObjectThree);
                break;
        }
        switch (objectFour)
        {
            case ObjectType.capsule:
                createdObjectFour = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                createdObjectFour.AddComponent<Capsule>();
                createdObjects.Add(createdObjectFour);
                break;
            case ObjectType.cube:
                createdObjectFour = GameObject.CreatePrimitive(PrimitiveType.Cube);
                createdObjectFour.AddComponent<Cube>();
                createdObjects.Add(createdObjectFour);
                break;
            case ObjectType.cylinder:
                createdObjectFour = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                createdObjectFour.AddComponent<Cylinder>();
                createdObjects.Add(createdObjectFour);
                break;
            case ObjectType.sphere:
                createdObjectFour = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                createdObjectFour.AddComponent<Sphere>();
                createdObjects.Add(createdObjectFour);
                break;
        }
    }
    private void ObjectColorChoice()
    {
        switch (objectColorOne)
        {
            case ObjectColor.black:
                createdObjectOne.transform.GetComponent<Renderer>().material.color = Color.black;
                break;
            case ObjectColor.white:
                createdObjectOne.transform.GetComponent<Renderer>().material.color = Color.white;
                break;
            case ObjectColor.red:
                createdObjectOne.transform.GetComponent<Renderer>().material.color = Color.red;
                break;
            case ObjectColor.green:
                createdObjectOne.transform.GetComponent<Renderer>().material.color = Color.green;
                break;
            case ObjectColor.blue:
                createdObjectOne.transform.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case ObjectColor.gray:
                createdObjectOne.transform.GetComponent<Renderer>().material.color = Color.gray;
                break;
            case ObjectColor.yellow:
                createdObjectOne.transform.GetComponent<Renderer>().material.color = Color.yellow;
                break;
        }
        switch (objectColorTwo)
        {
            case ObjectColor.black:
                createdObjectTwo.transform.GetComponent<Renderer>().material.color = Color.black;
                break;
            case ObjectColor.white:
                createdObjectTwo.transform.GetComponent<Renderer>().material.color = Color.white;
                break;
            case ObjectColor.red:
                createdObjectTwo.transform.GetComponent<Renderer>().material.color = Color.red;
                break;
            case ObjectColor.green:
                createdObjectTwo.transform.GetComponent<Renderer>().material.color = Color.green;
                break;
            case ObjectColor.blue:
                createdObjectTwo.transform.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case ObjectColor.gray:
                createdObjectTwo.transform.GetComponent<Renderer>().material.color = Color.gray;
                break;
            case ObjectColor.yellow:
                createdObjectTwo.transform.GetComponent<Renderer>().material.color = Color.yellow;
                break;
        }
        switch (objectColorThree)
        {
            case ObjectColor.black:
                createdObjectThree.transform.GetComponent<Renderer>().material.color = Color.black;
                break;
            case ObjectColor.white:
                createdObjectThree.transform.GetComponent<Renderer>().material.color = Color.white;
                break;
            case ObjectColor.red:
                createdObjectThree.transform.GetComponent<Renderer>().material.color = Color.red;
                break;
            case ObjectColor.green:
                createdObjectThree.transform.GetComponent<Renderer>().material.color = Color.green;
                break;
            case ObjectColor.blue:
                createdObjectThree.transform.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case ObjectColor.gray:
                createdObjectThree.transform.GetComponent<Renderer>().material.color = Color.gray;
                break;
            case ObjectColor.yellow:
                createdObjectThree.transform.GetComponent<Renderer>().material.color = Color.yellow;
                break;
        }
        switch (objectColorFour)
        {
            case ObjectColor.black:
                createdObjectFour.transform.GetComponent<Renderer>().material.color = Color.black;
                break;
            case ObjectColor.white:
                createdObjectFour.transform.GetComponent<Renderer>().material.color = Color.white;
                break;
            case ObjectColor.red:
                createdObjectFour.transform.GetComponent<Renderer>().material.color = Color.red;
                break;
            case ObjectColor.green:
                createdObjectFour.transform.GetComponent<Renderer>().material.color = Color.green;
                break;
            case ObjectColor.blue:
                createdObjectFour.transform.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case ObjectColor.gray:
                createdObjectFour.transform.GetComponent<Renderer>().material.color = Color.gray;
                break;
            case ObjectColor.yellow:
                createdObjectFour.transform.GetComponent<Renderer>().material.color = Color.yellow;
                break;
        }
    }

    private void ObjectPointChoice()
    {
        switch(objecPointOne)
        {
            case ObjectPoint.five:
                break;
            case ObjectPoint.ten: 
                break;
            case ObjectPoint.fifteen:
                break;
            case ObjectPoint.twenty:
                break;
        }
        switch (objecPointTwo)
        {
            case ObjectPoint.five:
                break;
            case ObjectPoint.ten:
                break;
            case ObjectPoint.fifteen:
                break;
            case ObjectPoint.twenty:
                break;
        }
        switch (objecPointThree)
        {
            case ObjectPoint.five:
                break;
            case ObjectPoint.ten:
                break;
            case ObjectPoint.fifteen:
                break;
            case ObjectPoint.twenty:
                break;
        }
        switch (objecPointFour)
        {
            case ObjectPoint.five:
                break;
            case ObjectPoint.ten:
                break;
            case ObjectPoint.fifteen:
                break;
            case ObjectPoint.twenty:
                break;
        }
    }

}
