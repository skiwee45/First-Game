using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo) { //When the player collides, it does this:
        if (collisionInfo.collider.tag == "Obstacle") //check if the object it hits is an obstacle
        {
            Debug.Log("We Hit An Obstacle");
            movement.enabled = false; //makes the player stop moving
            FindObjectOfType<GameManager>().gameOver();
        }
    }
}
