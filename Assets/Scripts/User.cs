using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    private string name;
    private int score;
    private int rank;

    public void SetName(string _name) { name = _name; }
    public void SetScore(int _score) {  score = _score; }
    public void SetRank(int _rank) { rank = _rank; }


    public string GetName() { return name; }
    public int GetScore() { return score;}
    public int GetRank() { return rank;}
}
