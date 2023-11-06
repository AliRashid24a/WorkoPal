using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    public List<Exercise> allExcercises = new List<Exercise>();
    public List<Workout> workouts = new List<Workout>();
    public float playerXP = new float();
}
