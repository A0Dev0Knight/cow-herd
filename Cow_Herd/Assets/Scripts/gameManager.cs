using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public const float SPAWN_TIMER = 10f;

    [SerializeField] Transform grassPrefab;

    float spawnTimer = SPAWN_TIMER; // after 10 seconds the game spawns a grass :))

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        else
        {
            Instantiate(grassPrefab);
            spawnTimer = SPAWN_TIMER;
        }
    }
}
