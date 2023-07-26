using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InterfaceGame : MonoBehaviour
{
   public TMP_Text textScore;

   void Update(){

    textScore.text = "Score: " + GameManager.currentScore.ToString();

   }
}
