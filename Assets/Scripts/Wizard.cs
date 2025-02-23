using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Wizard : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] protected float speed = 5f;

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

    public void Die() {
        Debug.Log(name + " has died!");
        
        if (gameObject.CompareTag("Player")) {
            
        }
        else {
            
        }
        GameManager.GameOver();
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
