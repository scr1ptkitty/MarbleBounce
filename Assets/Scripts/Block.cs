using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Block : MonoBehaviour
{
    public int maxHp;
    public int hp;
    public GameObject powerup; // holds prefab of powerup, if this block drops anything

    // Start is called before the first frame update
    void Start()
    {
        hp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            DropPowerUp();
            Destroy(this.gameObject);
            // remove this object from the GM's blocks[] array
        }
    }

    public abstract void DropPowerUp();

    private void OnCollisionEnter(Collision collision)
    {
        // if collides with a marble, take damage
    }
}
