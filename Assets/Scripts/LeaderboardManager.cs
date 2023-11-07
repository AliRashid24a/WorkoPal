using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class LeaderboardManager : MonoBehaviour
{

    public TextAsset leaderboardData;
    public GameObject leaderboardDisplay;
    public GameObject entrySlot;

    private Dictionary<string, int> unsortedEntries = new Dictionary<string, int>();
    private User[] sortedEntries;
    private string[] entryData;
    private int entryCount;

    private void Start()
    {
        ReadFile(leaderboardData);
        DisplayData();
    }

    private void ReadFile(TextAsset file)
    {
        // Turn the file into a set of strings
        string text = file.text;
        entryData = text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

        // Parse strings into names and point values, then add to dictionary.
        foreach (string entry in entryData)
        {
            string name = "";
            string points = "";

            bool readingName = true;
            foreach (char c in entry)
            {
                if (readingName)
                {
                    if (c == '/')
                    { readingName = false; }
                    else
                    { name += c; }
                }
                else
                { points += c; }
            }
            unsortedEntries.Add(name, int.Parse(points));
            entryCount++;
        }

        // Sort the data
        sortedEntries = new User[entryCount];
        int i = 0;
        while (unsortedEntries.Count > 0)
        {
            int currentScore;
            int greatestScore = 0;
            string greatestKey = "bob";

            foreach (var entry in unsortedEntries)
            {
                currentScore = entry.Value;
                if (currentScore > greatestScore) 
                {
                    greatestKey = entry.Key; 
                    greatestScore = entry.Value;
                }
            }

            User currentUser = new User();
            currentUser.SetName(greatestKey);
            currentUser.SetScore(greatestScore);
            currentUser.SetRank(i + 1);
            sortedEntries[i] = currentUser;
            unsortedEntries.Remove(greatestKey);
            i++;
        }
    }

    private void DisplayData()
    {
        foreach (User entry in sortedEntries)
        {
            GameObject newSlot = Instantiate(entrySlot, leaderboardDisplay.transform);
            string displayText = " " + entry.GetRank() + " " + entry.GetName() + " : " + entry.GetScore();
            newSlot.GetComponentInChildren<TextMeshProUGUI>().text = displayText;
        }
    }
}
