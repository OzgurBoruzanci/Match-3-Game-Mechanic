using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class Cylinder : BaseObject
{
    bool onClick = false;

    private void OnEnable()
    {
        EventManager.OnClick += OnClick;
        EventManager.Matched += Matched;
        //EventManager.LeftObject += LeftObject;
        //EventManager.RightObject += RightObject;
    }
    private void OnDisable()
    {
        EventManager.OnClick -= OnClick;
        EventManager.Matched -= Matched;
        //EventManager.LeftObject -= LeftObject;
        //EventManager.RightObject -= RightObject;
    }

    //void LeftObject(GameObject leftObject)
    //{

    //}
    //void RightObject(GameObject rightObject)
    //{

    //}

    void Matched()
    {
        transform.gameObject.SetActive(false);
    }

    void OnClick()
    {
        onClick = true;
    }

    private void Start()
    {
        derivedObject = transform.gameObject;
        firstPosition = transform.position;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                derivedObject = hit.transform.gameObject;
                if (!onClick && hit.transform.gameObject!=null)
                {
                    ObjectFirstClick();
                    EventManager.OnClick();
                    EventManager.LeftObject(transform.GetComponent<MeshFilter>().mesh, transform.GetComponent<Renderer>().material.color);
                }
                else if (onClick && hit.transform.gameObject==transform.gameObject)
                {
                    ObjectLastClick();
                    onClick= false;
                }
                if (!onClick && hit.transform.gameObject != null && hit.transform.tag == "CloneObject")
                {
                    SecondObjectClick();
                    EventManager.RightObject(transform.GetComponent<MeshFilter>().mesh,transform.GetComponent<Renderer>().material.color);
                }
            }
        }
    }
}
