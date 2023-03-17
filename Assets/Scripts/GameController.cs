using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Color rightColor;
    Color leftColor;
    Mesh rightMesh;
    Mesh leftMesh;

    bool objectCome=false;

    private void OnEnable()
    {
        EventManager.LeftObject += LeftObject;
        EventManager.RightObject += RightObject;
    }
    private void OnDisable()
    {
        EventManager.LeftObject-= LeftObject;
        EventManager.RightObject -= RightObject;
    }

    void RightObject(Mesh mesh,Color color)
    {
        rightColor= color;
        rightMesh= mesh;
    }

    void LeftObject(Mesh mesh, Color color)
    {
        leftColor= color;
        leftMesh= mesh;
        objectCome = true;
    }

    void Start()
    {

    }

    
    void Update()
    {
        if (rightMesh==leftMesh && rightColor==leftColor && objectCome)
        {
            EventManager.Matched();
            Debug.Log("sol " + leftColor + leftMesh + "  sað  " + rightColor + rightMesh);
        }
    }
}
