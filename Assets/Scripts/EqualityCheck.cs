using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class EqualityCheck : MonoBehaviour
{
    GameObject firstObject;
    GameObject secondObject;

    private void OnEnable()
    {
        EventManager.OnClick += OnClick;
    }
    private void OnDisable()
    {
        EventManager.OnClick -= OnClick;
    }

    void OnClick(GameObject onClickObject)
    {
        if (firstObject==null)
        {
            firstObject = onClickObject;
        }
        else
        {
            secondObject= onClickObject;
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        if (firstObject!=null && secondObject!=null)
        {
            if (firstObject.GetComponent<Renderer>().material.color == secondObject.GetComponent<Renderer>().material.color/* && firstObject.GetComponent<MeshFilter>().mesh == secondObject.GetComponent<MeshFilter>().mesh*/)
            {
                firstObject.SetActive(false);
                secondObject.SetActive(false);
                firstObject = null;
                secondObject = null;
            }
            else
            {
                firstObject = null;
                secondObject = null;
                EventManager.NotMatched();
            }
        }
    }
}
