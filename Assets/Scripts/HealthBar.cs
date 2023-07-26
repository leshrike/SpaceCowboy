using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    
    public Image[] lives;
    public int livesRemaining;


    public void loseHP(){

        livesRemaining--;
        lives[livesRemaining].enabled = false;
    
        if(livesRemaining == 0){

           SceneManager.LoadScene("GameOver");

        }

    }

    public void gainHP(){

        if( livesRemaining < 5){

            livesRemaining ++;
            lives[livesRemaining-1].enabled = true;
        }
    
    }

}
