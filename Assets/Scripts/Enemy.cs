using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp;
    private GameObject explosion;
    public Transform deathPoint;
    public GameObject deathExplosion;

    public void TakeDamage(int hpDeducted){

        hp = hp - hpDeducted;
        print(hp); 

        if (hp < 0 || hp == 0 ){
            
            print("ded");
            Die();
        }
    }

    void Die(){

        explosion = Instantiate(deathExplosion, deathPoint.position, deathPoint.rotation);    
        
        Destroy(gameObject);
        Destroy(explosion, 0.7f);

    }
}
