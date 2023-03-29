using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class EqualityCheck : MonoBehaviour
{
    public int amountOfObjectsToMatch = 3;
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
        
        if (shapeObjects.Count< amountOfObjectsToMatch)
        {
            for (int i = 0; i < shapeObjects.Count; i++)
            {
                if (!EqualityCondition(i))
                {
                    EventManager.NotMatched();
                    shapeObjects.Clear();
                    shapeEqualityCheck = 0;
                }
            }
        }
        else if (shapeObjects.Count==amountOfObjectsToMatch)
        {
            for (int i = 0; i < shapeObjects.Count; i++)
            {
                if (EqualityCondition(i))
                {
                    shapeEqualityCheck++;
                }
                else
                {
                    EventManager.NotMatched();
                    shapeObjects.Clear();
                    shapeEqualityCheck = 0;
                }
            }
        }

        if (shapeEqualityCheck == amountOfObjectsToMatch)
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

    bool EqualityCondition(int i)
    {
        if (shapeObjects[0].transform.GetComponent<BaseShape>().shapeInfo.shapeColor == shapeObjects[i].transform.GetComponent<BaseShape>().shapeInfo.shapeColor &&
                    shapeObjects[0].transform.GetComponent<BaseShape>().shapeInfo.objectShape == shapeObjects[i].transform.GetComponent<BaseShape>().shapeInfo.objectShape)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
