using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ExceriseButton : MonoBehaviour
{
    private GameObject counter;
    private TextMeshProUGUI text;
    private void Awake()
    {
        // set the counter gameobject to the counter upon instaniation
        //counter = 

    }
    public void EnableCounter()
    {
        counter.SetActive(true);
    }

    void OnClick()
    {
        EnableCounter();
    }

}
