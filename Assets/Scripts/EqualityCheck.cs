using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class EqualityCheck : MonoBehaviour
{
    GameObject firstObject;
    GameObject secondObject;
    GameObject thirdObject;

    int totalScore;

    private void OnEnable()
    {
        EventManager.OnClick += OnClick;
    }
    private void OnDisable()
    {
        EventManager.OnClick -= OnClick;
    }

    void OnClick(GameObject onClickObject,int point)
    {
        if (firstObject==null && secondObject==null)
        {
            firstObject = onClickObject;
            totalScore += point;
        }
        else if(secondObject==null) 
        {
            secondObject= onClickObject;
            totalScore += point;
        }
        else
        {
            thirdObject=onClickObject;
            totalScore += point;
        }
    }

    
    void Update()
    {
        if (firstObject != null && secondObject != null && thirdObject != null)
        {
            if (firstObject.GetComponent<Renderer>().material.color == secondObject.GetComponent<Renderer>().material.color &&
                firstObject.GetComponent<Renderer>().material.color  == thirdObject.GetComponent<Renderer>().material.color && 
                firstObject.GetComponent<MeshFilter>().sharedMesh == secondObject.GetComponent<MeshFilter>().sharedMesh && 
                firstObject.GetComponent<MeshFilter>().sharedMesh == thirdObject.GetComponent<MeshFilter>().sharedMesh)
            {
                EventManager.ShapePoint(totalScore);
                firstObject.SetActive(false);
                secondObject.SetActive(false);
                thirdObject.SetActive(false);
                firstObject = null;
                secondObject = null;
                thirdObject = null;
                totalScore = 0;
            }
            else
            {
                firstObject = null;
                secondObject = null;
                thirdObject = null;
                totalScore= 0;
                EventManager.NotMatched();
            }
            
        }
    }
}
