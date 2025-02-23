using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

        void OnTriggerEnter2D(Collider2D collision)
    {
        Wizard wizard = collision.GetComponent<Wizard>();
        if (wizard != null)
        {
            wizard.TakeDamage(damage);
            Destroy(gameObject); // Hancurkan fireball setelah terkena target
        }
    }
}
