using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class EqualityCheck : MonoBehaviour
{

    List<GameObject> shapeObjects;
    int shapeEqualityCheck;
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
        if (!shapeObjects.Contains(onClickObject))
        {
            shapeObjects.Add(onClickObject);
            totalScore = point;
        }
        ShapeEqualityCheck();

    }
    private void Start()
    {
        shapeObjects = new List<GameObject>();
    }


    void ShapeEqualityCheck()
    {
        Debug.Log(shapeObjects.Count + " liste");
        if (shapeObjects.Count>=2)
        {
            for (int i = 0; i < shapeObjects.Count; i++) 
            {
                if (shapeObjects[0].transform.GetComponent<BaseShape>().shapeColor == shapeObjects[i].transform.GetComponent<BaseShape>().shapeColor &&
                    shapeObjects[0].transform.GetComponent<BaseShape>().objectShape == shapeObjects[i].transform.GetComponent<BaseShape>().objectShape)
                {
                    shapeEqualityCheck++;
                    Debug.Log(shapeEqualityCheck);
                }
                else
                {
                    EventManager.NotMatched();
                    shapeObjects.Clear();
                    shapeEqualityCheck = 0;
                }
            }
        }
        
        if (shapeEqualityCheck == 3)
        {
            EventManager.ShapePoint(totalScore * 3);
            for (int i = 0; i < shapeObjects.Count; i++)
            {
                shapeObjects[i].gameObject.SetActive(false);
            }
            shapeObjects.Clear();
            shapeEqualityCheck = 0;
        }
    }
}
