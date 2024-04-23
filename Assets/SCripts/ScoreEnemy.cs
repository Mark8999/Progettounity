using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScoreEnemy : MonoBehaviour
{
    public UnityEvent OnScoreChanged;
    public int Score {  get; private set; }

    public void AddScore (int amount)
    {
        Score += amount;
        OnScoreChanged.Invoke ();
    }
    

}
