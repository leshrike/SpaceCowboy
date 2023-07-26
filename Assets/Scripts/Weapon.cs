using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject bulletPrefab;
    private Animator animator;
    [SerializeField] AudioSource bulletSound;
    void Awake(){

        animator = GetComponent<Animator>();
    }
   
   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
 
            Shoot();
       
        }else {

            //animator.SetBool("isShooting", false);
        }
    }

    public void Test(){

        print("Chingo Mototruco");

    }
    public void Shoot(){
        
        print("pingo");
        animator.SetBool("isShooting", true);
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletSound.Play();
        animator.SetBool("isShooting", false);
    }
}
