using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public static GameDataManager instance;
    public int winCount = 0;
    public int loseCount = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void Win() {
        winCount++; // Increment the win count
    }

    public void Lose() {
        loseCount++; // Increment the lose count
    }
}
