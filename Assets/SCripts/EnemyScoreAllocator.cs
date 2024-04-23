using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoreAllocator : MonoBehaviour
{
    [SerializeField]
    private int _killScore;

    private ScoreEnemy _scoreController;

    private void Awake()
    {
        _scoreController = FindObjectOfType<ScoreEnemy>();
    }

    public void AllocateScore()
    {
        _scoreController.AddScore(_killScore);
    }
}
