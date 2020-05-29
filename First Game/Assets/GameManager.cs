using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameHasEnded = false; //to make sure the game only ends once
    public float restartDelay = 2f; //time it takes to restart the game after gameover
    public GameObject completeLevelUI; //stores the reference to the panel that shows level complete

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gameOver () { //when game ends it is called
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Debug.Log(gameHasEnded);
            FindObjectOfType<Score>().youDied();
            Invoke("restart", restartDelay);
        }
    }

    void restart () { //restarts the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void completeLevel () {
        Debug.Log("Level Done!");
        completeLevelUI.SetActive(true);
    }
}
