using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterManager : MonoBehaviour
{
    private TextMeshProUGUI text;
    private TextMeshProUGUI textCounter;
    public GameObject exceriseName;
    public GameObject counterSum;
    public GameObject exceriseButton;
    public void BeginCounter()
    {
        // I want to basically change the text on Name and Counter sum gameobjects
        //text = exceriseButton.GetComponent<TextMeshProUGUI>();
        textCounter = exceriseName.GetComponent<TextMeshProUGUI>();
        textCounter.text = "Pog";
        text = counterSum.GetComponent<TextMeshProUGUI>();
        text.text = "0";
    }

    public void AddPoints(float xp)
    {
        text = counterSum.GetComponent<TextMeshProUGUI>();
        text.text += xp.ToString();
        UpdateScore();
    }

    void UpdateScore()
    {

    }

}
