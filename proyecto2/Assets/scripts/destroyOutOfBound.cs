using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBound : MonoBehaviour
{
    private float upperLim = 30f;
    private float lowerLim = -5f;
    public GameObject player;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        //detruir animals/projectils quan surten dels limits de pantalla
        if (transform.position.z >= upperLim)
        {
            Destroy(gameObject);
        }
        if (transform.position.z <= lowerLim)
        {
            player = GameObject.Find("Player");
            Destroy(player);
            Destroy(gameObject);
            Debug.Log(message: "GAME OVER");
            Time.timeScale = 0;
        }
    }
}
