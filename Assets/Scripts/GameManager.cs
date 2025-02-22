using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnPoint;
    public float spawnRate = 2.0f;
    public float minAngle = -9.0f;
    public float maxAngle = 10.0f;
    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBall", 0.0f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBall()
    {
        GameObject newBall = Instantiate(ball, spawnPoint.position, Quaternion.identity);

        Rigidbody2D rb = newBall.GetComponent<Rigidbody2D>();

        if(rb != null)
        {
            float angle = Random.Range(minAngle, maxAngle);
            float radian = angle * Mathf.Deg2Rad;

            Vector2 direction = new Vector2(Mathf.Sin(radian), -Mathf.Cos(radian)).normalized;

            rb.velocity = direction * speed;
        }
    }
}
