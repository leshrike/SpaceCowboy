using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToVictory : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider){

        if(collider.gameObject.tag == "Player"){
            
            GameManager.sharedInstance.victory();
        }
    }
}
