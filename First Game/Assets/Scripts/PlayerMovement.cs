using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; //used to control the rigidbody
    public float forwardForce = 1000f, sidewaysForce = 500f; //used to add different amounts of force
    private bool left = false, right = false; //checks if either key is being pressed

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0, 0, 300, ForceMode.Force);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //adds a forward force
        //checks for both buttons and adds sideways force   
        if (right == true)
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (left == true)
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //checks if they fall off the edge
        if (rb.position.y < -1f) {
            FindObjectOfType<GameManager>().gameOver();

        }
    }
    void Update()
    {
        if (Input.GetKey("d"))//checks if "d" key is being pressed
        {
            right = true;
        } else
        {
            right = false;
        }

        if (Input.GetKey("a"))//checks if "a" key is being pressed
        {
            left = true;
        } else
        {
            left = false;
        }
    }
}