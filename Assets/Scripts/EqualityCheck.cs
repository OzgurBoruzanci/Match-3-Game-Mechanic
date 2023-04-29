using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public class EqualityCheck : MonoBehaviour, IEqualityCheck
{
    public int amountOfObjectsToMatch = 3;
    List<BaseShape> shapeObjects;
    int totalScore;
    public GameScriptable gameScriptable;
    private void OnEnable()
    {
        EventManager.OnClick += OnClick;
    }
    private void OnDisable()
    {
        EventManager.OnClick -= OnClick;
    }

    void OnClick(BaseShape baseShape)
    {
        if (!shapeObjects.Contains(baseShape))
        {
            shapeObjects.Add(baseShape);
            totalScore = baseShape.shapeScriptable.shapePoint;
        }
        ShapeEqualityCheck();
    }
    private void Start()
    {
        shapeObjects = new List<BaseShape>();
    }

    public void ShapeEqualityCheck()
    {
        if (shapeObjects.Count < amountOfObjectsToMatch)
        {
            if (!EqualityCondition())
            {
                NotMatched();
            }
        }
        else if (shapeObjects.Count == amountOfObjectsToMatch)
        {
            if (EqualityCondition())
            {
                Matched();
            }
            else
            {
                NotMatched();
            }
        }
    }

    void Matched()
    {
        EventManager.ShapePoint(totalScore * amountOfObjectsToMatch);
        for (int i = 0; i < shapeObjects.Count; i++)
        {
            shapeObjects[i].gameObject.SetActive(false);
        }
        shapeObjects.Clear();
    }

    void NotMatched()
    {
        EventManager.NotMatched();
        EventManager.HealthDecreased();
        shapeObjects.Clear();

    }

    public bool EqualityCondition()
    {
        bool isItEqual = false;
        foreach (BaseShape baseShape in shapeObjects)
        {
            isItEqual = shapeObjects[0].shapeInfo.shapeColor == baseShape.shapeInfo.shapeColor &&
           shapeObjects[0].shapeInfo.objectShape == baseShape.shapeInfo.objectShape;            
        }
        return isItEqual;
    }

}
