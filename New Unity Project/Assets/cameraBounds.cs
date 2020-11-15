using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraBounds : MonoBehaviour
{
    [SerializeField] float leftLimit;
    [SerializeField] float rightLimit;
    [SerializeField] float downLimit;
    [SerializeField] float upLimit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, 0, 0),
            Mathf.Clamp(transform.position.y, 0, 0),
            transform.position.z

            );

    }
}
