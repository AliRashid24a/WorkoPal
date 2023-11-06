using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Exercise
{
    public string exerciseName;
    public float score;
    public int iD;

    public Exercise()
    {

    }
    public Exercise(string name, float score, int id)
    {
        this.exerciseName = name;
        this.score = score;
        this.iD = id;
    }
}
