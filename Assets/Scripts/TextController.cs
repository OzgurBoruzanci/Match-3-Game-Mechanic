using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text pointText;
    int shapePoint = 0;

    private void OnEnable()
    {
        EventManager.ShapePoint += ShapePoint;
    }
    private void OnDisable()
    {
        EventManager.ShapePoint -= ShapePoint;
    }
    void ShapePoint(int shapePt)
    {
        shapePoint += shapePt;
    }

    void Update()
    {
        pointText.text="Point : "+ shapePoint;
    }
}
