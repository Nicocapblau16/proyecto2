using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveForward : MonoBehaviour
{
    public float speed = 40f;
    private float zRange = 35f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(translation: Vector3.forward * Time.deltaTime * speed);

        /*if (transform.position.z >= zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
            Destroy()
        }
        if (transform.position.z <= -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        */
    }
}
