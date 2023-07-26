using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Vector3 destination;
    public Vector3 startPosition;
    public Transform fireBreath;
    public float time;
    
    // Start is called before the first frame update
    void Start()
    {

        iTween.MoveTo(gameObject, iTween.Hash("position", destination,
                        "time", time,
                        "easetype", iTween.EaseType.easeInOutSine,
                        "looptype", iTween.LoopType.pingPong,
                        "islocal", true));

    }

    // Update is called once per frame
    void Update()
    {
        
        if(this.gameObject.tag == "Salamander"){

            // cuando llegue a un tope, girara 180º
            if(gameObject.transform.position == destination){

                gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f,180f,0f));
                fireBreath.position = new Vector3(0.55f,0.5f,0f);
                fireBreath.transform.rotation = Quaternion.Euler(new Vector3(0f,180f,0f));

            }

            if (startPosition == gameObject.transform.position){
            
                gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
                fireBreath.position = new Vector3(7.50f,0.5f,0f);
                fireBreath.transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));
            }

        }else {

                    // cuando llegue a un tope, girara 180º
                if(gameObject.transform.position == destination){

                    gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f,180f,0f));

                }

                if (startPosition == gameObject.transform.position){
                    
                    gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));

                }

        }
    }
}
