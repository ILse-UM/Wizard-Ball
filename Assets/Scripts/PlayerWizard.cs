using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWizard : Wizard
{
    public GameObject ballPrefab;
    public float attackSpeed = 2f;
    private float attackTimer;
    private Vector2 shootDirection = Vector2.right;
    void Update()
    {
        float moveInput = Input.GetAxis("Vertical");

        if (moveInput != 0)
        {
            shootDirection = new Vector2(1, Mathf.Clamp(moveInput, -1, 1)).normalized;
        }

        Move(moveInput);

        if (attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && attackTimer <= 0)
        {
            attackTimer = 1 / attackSpeed;
            Attack();
        }

    }
    public override void Attack()
    {
        ShootProjectile();
    }

    void ShootProjectile()
    {
        GameObject ball = Instantiate(ballPrefab, transform.position + new Vector3(1.8f,0), Quaternion.identity);
        ball.GetComponent<Rigidbody2D>().velocity = shootDirection * speed;

        float angle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg;
        ball.transform.rotation = Quaternion.Euler(0,0,angle);

        Debug.Log("Player attack at " + angle + " degree");
    }
}
