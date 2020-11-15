using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject bullet;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) shoot();
    }
    void shoot()
    {
        animator.SetBool("atc", true);
        Instantiate(bullet, Firepoint.position, Firepoint.rotation);
        
        
    }
}
