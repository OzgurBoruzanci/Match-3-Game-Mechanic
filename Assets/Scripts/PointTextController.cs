using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointTextController : MonoBehaviour
{
    Text pointText;
    int shapePoint = 0;
    public GameScriptable gameScriptable;
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
        gameScriptable.highScore += shapePt;
    }
    private void Start()
    {
        pointText = GetComponent<Text>();
    }
    void Update()
    {
        pointText.text = $"Point : {shapePoint} HS : {gameScriptable.highScore}";
    }
}
