using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI playerHealthText;
    public TextMeshProUGUI enemyHealthText;
    private Wizard player;
    private Wizard enemy;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerWizard>();
        enemy = FindObjectOfType<EnemyWizard>();
        UpdateHealthText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateHealthText() {
        playerHealthText.text = "Health: " + player.GetHealth();
        enemyHealthText.text = "Health: " + enemy.GetHealth();
    }
}
