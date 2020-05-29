using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void loadNextLevel () {
        Debug.Log("Load Next Level");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
