using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int maxLives = 3;
    public int lives;
    public int width; // current size of the paddle
    public int enlarges; // number of enlarge powerups acquired

    // fields for getting mouse controls

    // Start is called before the first frame update
    void Start()
    {
        lives = maxLives;
    }

    // Update is called once per frame
    void Update()
    {
        // mouse controls
    }

    public void LoseLife()
    {
        if (lives - 1 <= 0)
        {
            lives--;
            // reset paddle position
        }
        else
        {
            // GameManager.GameOver();
        }
    }
    public void LifeUp()
    {
        lives++;
    }

    public void WidthUp()
    {
        //enlarges++ and recalculate width, re - scale paddle
    }

    public void DoubleUp()
    {
        //GameManager.DoubleScore();
    }
    
    public void CloneUp()
    {
        //GameManager.CreateClone();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // if get widthup, call WidthUp
        // if get lifeup, call LifeUp
        // if get doubleup, call DoubleUp
        // if get cloneup, call CloneUp
    }
}
