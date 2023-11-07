using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class CounterManager : MonoBehaviour
{
    public static CounterManager Instance { get; private set; }
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private TextMeshProUGUI text2;
    public float sum = 0;

    void Awake()
    {
        Instance = this;
    }
    public void AddPoints(float xp)
    {
        sum += xp;
        text.text = sum.ToString();
    }
    
    public void SetExerciseName(string exName)
    {
        text2.text = exName;
    }

    public void ResetCounter()
    {
        sum = 0;
        text.text = "0";
    }

}
