using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public Vector3 spawnpos;
    public GameObject obstacle;
    private PlayerController playerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", 1.5f, 1.5f);
    }
    void SpawnObstacle()
    {
        if (!playerScript.gameOver)
        {
            Instantiate(obstacle, spawnpos, obstacle.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
