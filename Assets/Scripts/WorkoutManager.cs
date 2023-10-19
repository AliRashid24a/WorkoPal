using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;

public class WorkoutManager : MonoBehaviour
{
    private List<Exercise> exercises = new List<Exercise>();
    private string jsonFilePath;

    private void Start()
    {
        // Set the JSON file path
        jsonFilePath = Path.Combine(Application.dataPath, "exercises.json");

        // Load existing exercises from the JSON file (if it exists)
        if (File.Exists(jsonFilePath))
        {
            string json = File.ReadAllText(jsonFilePath);
            exercises = JsonConvert.DeserializeObject<List<Exercise>>(json);
        }
    }

    public void AddExercise(string name, int reps)
    {
        Exercise newExercise = new Exercise(name, reps);
        exercises.Add(newExercise);

        // Save exercises to the JSON file
        SaveExercisesToJson();
    }

    public List<Exercise> GetExercises()
    {
        return exercises;
    }

    private void SaveExercisesToJson()
    {
        string json = JsonConvert.SerializeObject(exercises, Formatting.Indented);
        File.WriteAllText(jsonFilePath, json);
    }
}

