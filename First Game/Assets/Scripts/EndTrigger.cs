using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter() { //will enter after it hits the trigger (End Cube)
        gameManager.completeLevel();
    }
}
