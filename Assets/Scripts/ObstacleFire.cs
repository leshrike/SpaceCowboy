using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFire : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;    
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
