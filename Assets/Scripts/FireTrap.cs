using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrap : MonoBehaviour
{
    public Transform cannon;
    public GameObject fireballPrefab;
    
    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Fireball", 2f, 2f);

    }

    void Fireball(){

        Instantiate(fireballPrefab, cannon.position, cannon.rotation);

    }
}
