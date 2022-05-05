using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState _gameState;
    public static event Action<GameState> OnGameStateChanged; 

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateGameState(GameState newState)
    {
        _gameState = newState;

        OnGameStateChanged?.Invoke(newState);
    }
}
public enum GameState
{
    DrawPhase,
    MulliganPhase,
    GameStart,
    RoundStart,
    OnPlay,
    OnSummon,
    RoundEnd,
    PlayerTurn,
    EnemyTurn
}
