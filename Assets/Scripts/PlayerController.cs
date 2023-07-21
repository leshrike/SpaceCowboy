using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 
    public float Speed = 0.0f;
    public float lateralMovement = 2.0f;
    public float jumpMovement = 400.0f;
    public Transform groundCheck;
    private Animator animator;
    private Rigidbody2D rigidbody2d;
    private Collider2D standingCollider;

    // sounds

    public bool grounded = true;

    void Awake(){

        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, LayerMask.GetMask("Ground"));

        if(grounded && Input.GetButtonDown("Jump")){
            
            animator.SetBool("Jumping", true);
            rigidbody2d.AddForce(Vector2.up * jumpMovement);

        }

        if(grounded){

            animator.SetTrigger("Grounded");
            animator.SetBool("Jumping", !grounded);

        }else {

            animator.SetTrigger("Jumping");
        }


        // controles (PC)
        Speed = lateralMovement * Input.GetAxis("Horizontal");

        //controls mobile
        // Speed = lateralMovement * movementButton;
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
        animator.SetFloat("Speed", Mathf.Abs(Speed));

        if(Speed < 0){

            transform.localScale = new Vector3(-1,1,1);
        
        }else {

            transform.localScale = new Vector3(1,1,1);
        }

        animator.SetFloat("Height", rigidbody2d.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D collider){

        // collectible

        // enemy
        if(collider.gameObject.tag == "Enemy" || collider.gameObject.tag == "Boss"){

            // animator
            animator.SetTrigger("Damaged");    
            //perder vida
        }
    }

    public void Die(){
        //this.animator.SetBool("Alive",false);
        GameManager.sharedInstance.gameOver();

    }

}
