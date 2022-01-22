using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    public float startDelay = 2;
    public float spawnInterval = 2;
    Vector3 sponPos = new Vector3(0,20,9);

    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[obstacleIndex], sponPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
    }
}
