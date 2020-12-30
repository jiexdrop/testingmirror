using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class EnemyMovement : NetworkBehaviour
{

    Vector3 destination;
    // Start is called before the first frame update
    void Start()
    {
        destination = transform.position;
    }


    private Vector2 GetRandomPosition()
    {
        return Random.insideUnitCircle * 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (isServer)
        {
            if (Vector3.Distance(transform.position, destination) < 1)
            {
                destination = GetRandomPosition();
            }
            transform.position = Vector3.MoveTowards(transform.position, destination, Time.fixedDeltaTime);
        }
    }
}
