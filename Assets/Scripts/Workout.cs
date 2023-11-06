using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Workout
{
    public string Name;
    public DateTime Date;  
    public List<Exercise> Exercises;

    public Workout(string name, System.DateTime date, List<Exercise> exercises)
    {
        Name = name;
        Date = date;
        Exercises = exercises;
    }
}
