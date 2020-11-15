using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroMove : MonoBehaviour
{
    public Animator animator;
    public float speed1 = 5f;
    public bool isGrounded = false;
    public bool canMoveLeft = true;
    public bool canMoveRight = true;
    public bool facingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true)
        animator.SetBool("isJumping", false);
        move();
        jump();
        
    }
    void jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true) 
        {
            animator.SetBool("isJumping", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);

        }
    }

    void move() {
        float i = Input.GetAxis("Horizontal");
        animator.SetFloat("playerSpeed", Mathf.Abs(i)); 
        if (i < 0 && canMoveLeft == true) {
            if (facingRight == true) Flip();
        Vector3 movement = new Vector3(i, 0f, 0f);
        transform.position += movement * Time.deltaTime * speed1; }
        else if ( i > 0 && canMoveRight == true){
            if (facingRight == false) Flip();
            Vector3 movement = new Vector3(i, 0f, 0f);
          transform.position += movement* Time.deltaTime * speed1;
        } 
    }

    void Flip() {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
