using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ExceriseCreator : MonoBehaviour
{
    public TMP_InputField exName;
    public TMP_InputField exScore;
    public WorkoutManager exManager;
    private Exercise excerise;
    private void Awake()
    {
        exManager = FindObjectOfType<WorkoutManager>();
    }

    public void CreateExcerise()
    {
        Exercise ex = new Exercise(exName.text,float.Parse(exScore.text),0);
        exManager.AddExcerise(ex);
    }

}
