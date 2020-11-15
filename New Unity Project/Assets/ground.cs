using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    GameObject hero;
    // Start is called before the first frame update
    void Start()
    {
        hero = gameObject;
    }

    // Update is called once per frame
    void Update()
    {   
        
    }

    private void OnCollisionEnter2D(Collision2D coll) {
        if (coll.collider.tag == "ground")
            hero.GetComponent<heroMove>().isGrounded = true;
        else if (coll.collider.tag == "wall") {
            if (coll.contacts[0].normal.y < 0) hero.GetComponent<heroMove>().canMoveLeft = false;
            else if (coll.contacts[0].normal.y > 0) hero.GetComponent<heroMove>().canMoveRight = false;

        } 
              
                 
    }
    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.collider.tag == "ground")
            hero.GetComponent<heroMove>().isGrounded = false;
        else if (coll.collider.tag == "wall")
        {
             hero.GetComponent<heroMove>().canMoveLeft = true;
             hero.GetComponent<heroMove>().canMoveRight = true;

        }


    }
}
