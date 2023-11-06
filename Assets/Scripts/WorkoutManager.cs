using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;

public class WorkoutManager : MonoBehaviour
{
    private SaveData saveData;
    //private Workout currentWorkout;
    public List<Exercise> allExercises;
    public List<Transform> buttonParent;
    public GameObject buttonPrefab;
    private TextMeshProUGUI text;
    private int count = 0;

    //Saves User data in playerprefs and loads user data from playerprefs
    private void Awake()
    {
        if (PlayerPrefs.HasKey("save"))
        {
            string saveDataAsString = PlayerPrefs.GetString("save");
            saveData = JsonUtility.FromJson<SaveData>(saveDataAsString);
        }
        else
        {
            saveData = new SaveData();
        }
    }

    public void AddExcerise(Exercise ex)
    {
        saveData.allExcercises.Add(ex);
        CreateExerciseButton();
    }

    void UpdateExercises()
    {
        string msg = "";
        foreach (Exercise ex in saveData.allExcercises)
        {
            msg += ex.exerciseName;
        }
        Debug.Log(msg);
        CreateExerciseButton();
    }

    void CreateExerciseButton()
    {
        int rowID = Mathf.FloorToInt(count / 4f);

        GameObject exerciseButton = Instantiate(buttonPrefab, buttonParent[rowID]); 

        text = exerciseButton.GetComponentInChildren<TextMeshProUGUI>();
        text.text = saveData.allExcercises[count].exerciseName;

        count++;
    }

    void RemoveExercise()
    {
        //int rowID = Mathf.FloorToInt(count / 4f);
        //GameObject exerciseButton = GameObject.Destroy(exerciseButton);
    }

    public void endSession()
    {
        if (PlayerPrefs.HasKey("save"))
        {
            string saveDataAsString = PlayerPrefs.GetString("save");
            saveData = JsonUtility.FromJson<SaveData>(saveDataAsString);
        }
        else
        {
            saveData = new SaveData();
        }
    }
}