using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ABSTRACTION
public abstract class Wizard : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] protected float speed = 5f;

// ABSTRACTION
    public abstract void Attack();

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(gameObject.name + " took " + damage + " damage! Remaining HP: " + health);

        FindObjectOfType<UIManager>().UpdateHealthText();

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
{
    if (gameObject.CompareTag("Player"))
    {
        GameDataManager.instance.Lose();
        Debug.Log("Player kalah! Lose Count: " + GameDataManager.instance.loseCount);
    }
    else if (gameObject.CompareTag("Enemy"))
    {
        GameDataManager.instance.Win();
        Debug.Log("Enemy kalah! Win Count: " + GameDataManager.instance.winCount);
    }

    Destroy(gameObject);
    UnityEngine.SceneManagement.SceneManager.LoadScene("Title Screen"); // Pindah ke scene Game Over
}

    public void Move(float direction) {
        float newY = transform.position.y + (direction * speed * Time.deltaTime);
        newY = Mathf.Clamp(newY, -3.5f, 6f); // Pastikan tidak keluar batas
        transform.position = new Vector2(transform.position.x, newY);
    }

    public int GetHealth() {
        return health;
    }

}
