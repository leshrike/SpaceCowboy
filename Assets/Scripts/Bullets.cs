using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
   
   public float speed = 20f;
   public Rigidbody2D rb;
   public int damage = 40;
   public GameObject blasterImpact;
   public GameObject impactEffect;
   
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo){

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        
        if (enemy != null){

            enemy.TakeDamage(40);
        }

        blasterImpact = Instantiate(impactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(blasterImpact, 0.3f);

    }
}
