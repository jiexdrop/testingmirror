using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : NetworkBehaviour
{

    public GameObject enemyPrefab;

    public int enemies; 

    public override void OnStartServer()
    {
        base.OnStartServer();
        //if (isClient) return;

    }

    // Update is called once per frame
    void Start()
    {
        if (!isLocalPlayer)
        {
            Spawn();
        }
    }

    [ServerCallback]
    private void Spawn()
    {
        Debug.Log($"Spawn && isServer: {isServer}");

        for (int i = 0; i < enemies; i++)
        {
            GameObject enemyInstance = Instantiate(enemyPrefab, Random.insideUnitCircle * 5, Quaternion.identity);
            NetworkServer.Spawn(enemyInstance);
        }
    }
}
