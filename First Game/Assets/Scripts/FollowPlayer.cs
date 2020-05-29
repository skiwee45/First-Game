using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;//creates a transform, which records the player's position and rotation
    public Vector3 offset;//creates a Vector3, which holds 3 floats, perfect for positioning the camera.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
