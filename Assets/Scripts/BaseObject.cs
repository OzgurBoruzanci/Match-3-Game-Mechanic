using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseObject : MonoBehaviour
{
    protected Vector3 firstPosition;
    protected GameObject derivedObject;

    protected virtual void ObjectFirstClick()
    {
        derivedObject.transform.position = new Vector3(-2, Camera.main.transform.position.y, Camera.main.transform.position.z + 7);
    }
    protected virtual void ObjectLastClick() 
    {
        transform.position = firstPosition;
    }

    protected virtual void SecondObjectClick()
    {
        derivedObject.transform.position = new Vector3(2, Camera.main.transform.position.y, Camera.main.transform.position.z + 7);
    }

    //protected virtual void MouseClickPosition()
    //{
    //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //    RaycastHit hit;
    //    if (Physics.Raycast(ray, out hit))
    //    {
    //        derivedObject = hit.transform.gameObject;
    //        if (!onClick)
    //        {
    //            ObjectFirstClick();
    //            onClick = true;
    //        }
    //        else
    //        {
    //            ObjectLastClick();
    //            onClick = false;
    //        }
    //    }
    //}

}
