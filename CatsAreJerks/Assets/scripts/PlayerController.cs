using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    
    private float speed = 10.0f;
    private float turnSpeed = 85.0f;
    private float horizontalInput;
    private float forwardInput;
    public scorelogic gameOver;
   


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // move the vehicle left and right
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            gameOver.gameOver();
        }
             

    }

    }
