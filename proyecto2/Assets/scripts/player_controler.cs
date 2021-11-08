using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controler : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10f;
    private float horizontalInput;
    private float xRange = 17;

    public GameObject proyectilPrefab;

    
    void Start()
    {
        transform.position = initialPos;  //posicion inicial del player

    }

    
    void Update()
    {
        //movimiento horizontal player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(translation: Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (transform.position.x >= xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //disparo de proyectil
            Instantiate(original: proyectilPrefab, transform.position, proyectilPrefab.transform.rotation);
        }
    }
}
