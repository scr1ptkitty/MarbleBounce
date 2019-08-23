using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Canvas levelUi;
    public List<GameObject> blocks = new List<GameObject>();
    public List<GameObject> marbles = new List<GameObject>();
    public GameObject player;
    // nextLevel
    // previousLevel
    // mainMenuLevel

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoubleScore()
    {
        // double the current score when the player gets a doubleup
    }

    public void CreateClone()
    {
        // create a clone marble when the player gets a cloneup
    }

    public void GameOver()
    {
        // game over screen
    }
}
