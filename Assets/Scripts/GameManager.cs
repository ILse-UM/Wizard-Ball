using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void StartGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Scene");
        Debug.Log("Game Loaded!");
    }

    public static void GameOver() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Title Screen");
        Debug.Log("Game Ended!");
    }

}
