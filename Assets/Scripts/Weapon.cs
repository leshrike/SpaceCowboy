using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject bulletPrefab;
    private Animator animator;

    void Awake(){

        animator = GetComponent<Animator>();
    }
   
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){

            animator.SetBool("isShooting", true);
            Shoot();
       
        }else {

            animator.SetBool("isShooting", false);
        }
    }


    void Shoot(){

        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

    }
}
