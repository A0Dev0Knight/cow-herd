using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grass : MonoBehaviour
{
    public const float HEALTH_POINTS = 100;
    public const float REVIVE_POINTS = 10;
    public const float MILK_POINTS = 5;
    public const float GROW_MULTIPLIER = 2;
    public const float MAX_GRASS_LEVEL = 3;
    
    float health = HEALTH_POINTS;
    float revivePoints = REVIVE_POINTS;
    float milkPoints = MILK_POINTS;
    bool isBeingConsumed = false;

    int grassSize = 0; // by default grass is the smallest, by time it grows

    float growTimer = 10f; //after 10 seconds the grass grows

    void Grow()
    {
        if (grassSize < MAX_GRASS_LEVEL && !isBeingConsumed)
        {

            grassSize++;

            health *= GROW_MULTIPLIER;
            revivePoints *= GROW_MULTIPLIER;
            milkPoints *= GROW_MULTIPLIER;
        }
    }

    void TakeDamage(float damage)
    {
        isBeingConsumed = true;
        health -= damage;
        if (health <= 0) Destroy(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            float baseDamage = 10;
            TakeDamage(baseDamage);
            Debug.Log(health);
            Debug.Log("+ " + milkPoints);
            Debug.Log("+ " + revivePoints);

        }
        // after timer
        //Grow()
        // Grow() must not be applyed when grass is consumed
        // isBeingConsumed = false; // by this i hope to catch the moment a cow stops eating away a grass
    }
}
