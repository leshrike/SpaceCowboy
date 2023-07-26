using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    public Transform cannon;
    public GameObject fireballPrefab;
    Animator anim;
    [SerializeField] private AudioSource fireballSound;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fireball", 1f, 3f);

    }   

    void Fireball(){
    
       

        if(this.gameObject != null && this.gameObject.tag == "Salamander"){

            anim = GetComponent<Animator>();
            anim.SetTrigger("isShooting");
           
           // Invoke("Fire", 1f);
            Invoke("ResetTrigger", 1);
        }
        
        else{
            
            fireballSound.Play();
            Instantiate(fireballPrefab, cannon.position, cannon.rotation);

        }
    }

    void Fire(){
        
        fireballSound.Play();
        Instantiate(fireballPrefab, cannon.position, cannon.rotation);
    }

    void ResetTrigger(){

        anim = GetComponent<Animator>();
        anim.ResetTrigger("isShooting");

    }
}
