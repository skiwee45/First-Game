using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public GameManager manager;
    public Font newFont;
    bool runUpdate = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() {
        Debug.Log("FixedUpdate run = " + runUpdate);
        if (runUpdate)
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }

    public void youDied() { //used when player dies
        runUpdate = false;
        scoreText.text = "YOU DIED!";
        scoreText.color = Color.red;
        scoreText.fontStyle = FontStyle.Normal;
        scoreText.font = newFont;
        Debug.Log("youDied function run = " + runUpdate);
    }
}
