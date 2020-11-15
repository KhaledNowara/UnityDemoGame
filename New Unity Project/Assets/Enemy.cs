using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 100;
    public Animator animator;
    public GameObject deathEffect; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int damage) {
        health -= damage;
        animator.SetBool("hurt",true);
        if (health <= 0) {
            animator.SetBool("dead", true);
        }
    }

    
}
