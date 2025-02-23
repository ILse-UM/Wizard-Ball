using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWizard : Wizard
{
    public Transform player;
    public GameObject ballPrefab;
    public float attackSpeed = 3f;
    public float moveDuration = 2f;
    public float yMin = -3.5f;
    public float yMax = 3.5f;
    private float moveTimer;
    private float moveDirection;

    void Start()
    {
        SetRandomDirection();
        InvokeRepeating("Attack", 0f, attackSpeed);
    }
    void Update()
    {
        Move(moveDirection);

        // Ubah arah gerakan setiap moveDuration habis
        moveTimer -= Time.deltaTime;
        if (moveTimer <= 0)
        {
            SetRandomDirection();
        }
    }
    public override void Attack()
    {
        ShootProjectile();
    }

    void ShootProjectile()
    {
        GameObject ball = Instantiate(ballPrefab, transform.position - new Vector3(1.8f, 0), Quaternion.identity);
        Vector2 shootDirection = (player.position - transform.position).normalized;
        ball.GetComponent<Rigidbody2D>().velocity = shootDirection * speed;
        Debug.Log("Enemy Wizard attacks!");
    }

    void SetRandomDirection()
    {
        moveDirection = Random.Range(-1f, 1f);
        moveTimer = moveDuration;
    }
}
