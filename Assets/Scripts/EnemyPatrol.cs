using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Vector3 destination;
    public Vector3 startPosition;

    public float time;
    
    // Start is called before the first frame update
    void Start()
    {

        iTween.MoveTo(gameObject, iTween.Hash("position", destination,
                        "time", time,
                        "easetype", iTween.EaseType.easeInOutSine,
                        "looptype", iTween.LoopType.pingPong));

    }

    // Update is called once per frame
    void Update()
    {
        // cuando llegue a un tope, girara 180º
        if(gameObject.transform.position == destination){

            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f,180f,0f));

        }

         if (startPosition == gameObject.transform.position){
            
           gameObject.transform.rotation = Quaternion.Euler(new Vector3(0f,0f,0f));

        }
    }
}
