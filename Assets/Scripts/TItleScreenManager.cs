using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TItleScreenManager : MonoBehaviour
{
    public TextMeshProUGUI winText;
    public TextMeshProUGUI loseText;
    // Start is called before the first frame update
    void Start()
    {
        winText.text = "Wins : " + GameDataManager.instance.winCount;
        loseText.text = "Loses : " + GameDataManager.instance.loseCount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Scene");
    }

    public void QuitGame() {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        
        #else
        Application.Quit();
        #endif

    }
}
