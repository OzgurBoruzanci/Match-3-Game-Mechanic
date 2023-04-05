using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class EqualityCheck : MonoBehaviour
{
    public int amountOfObjectsToMatch = 3;
    List<BaseShape> shapeObjects;
    int totalScore;

    private void OnEnable()
    {
        EventManager.OnClick += OnClick;
    }
    private void OnDisable()
    {
        EventManager.OnClick -= OnClick;
    }

    void OnClick(BaseShape baseShape,int point)
    {
        if (!shapeObjects.Contains(baseShape))
        {
            shapeObjects.Add(baseShape);
            totalScore = point;
        }
        ShapeEqualityCheck();

    }
    private void Start()
    {
        shapeObjects = new List<BaseShape>();
    }

    void ShapeEqualityCheck()
    {
        if (shapeObjects.Count < amountOfObjectsToMatch)
        {
            if (!EqualityCondition())
            {
                EventManager.NotMatched();
                shapeObjects.Clear();
            }
        }
        else if (shapeObjects.Count == amountOfObjectsToMatch)
        {
            if (EqualityCondition())
            {
                EventManager.ShapePoint(totalScore * amountOfObjectsToMatch);
                for (int i = 0; i < shapeObjects.Count; i++)
                {
                    shapeObjects[i].gameObject.SetActive(false);
                }
                shapeObjects.Clear();
            }
            else
            {
                EventManager.NotMatched();
                shapeObjects.Clear();
            }
        }
    }

    bool EqualityCondition()
    {
        bool isItEqual = false;
        foreach (BaseShape baseShape in shapeObjects)
        {
            if (shapeObjects[0].shapeInfo.shapeColor == baseShape.shapeInfo.shapeColor &&
           shapeObjects[0].shapeInfo.shapeMesh == baseShape.shapeInfo.shapeMesh)
            {
                isItEqual = true;
            }
            else
            {
                isItEqual = false;
            }
        }
        return isItEqual;
    }
}
