using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    private GameObject playerInstance;
    private float respawnTimer;

    void Start()
    {
        SpawnPlayer();
    }

    void SpawnPlayer()
    {
        respawnTimer = 1;
        playerInstance = (GameObject)Instantiate(playerPrefab, transform.position, Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (playerInstance == null)
        {
            respawnTimer -= Time.deltaTime;
            if (respawnTimer <= 0)
            {
                SpawnPlayer();
            }
        }
    }
}
