using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody2D rb;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;    
    }

    void OnTriggerEnter2D(Collider2D hitInfo){

        PlayerController player = hitInfo.GetComponent<PlayerController>();

        if(player){

            // Player or Enemy Take damage 
            print("Git gud");

        }

        Destroy(gameObject);

    }
}
