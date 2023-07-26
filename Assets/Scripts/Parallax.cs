using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

   [SerializeField] private Vector2 velocidadMovimiento;
   private Vector2 offset;
   private Material material;

    void Awake(){

        material = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
        offset = velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;

    }
}
