using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class TestNetworkManager : NetworkManager
{
    public GameObject enemySpawnerPrefab;

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);
    }

    public override void OnServerReady(NetworkConnection conn)
    {
        base.OnServerReady(conn);
    }

    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);
    }


    public override void OnStartServer()
    {
        base.OnStartServer();
        GameObject enemySpawnerInstance = Instantiate(enemySpawnerPrefab);
        NetworkServer.Spawn(enemySpawnerInstance);
    }

}
