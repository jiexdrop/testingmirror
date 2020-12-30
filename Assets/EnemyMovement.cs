using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
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
        if(Vector3.Distance(transform.position, destination) < 1)
        {
            destination = GetRandomPosition();
        }
        transform.position = Vector3.MoveTowards(transform.position, destination,  5 * Time.fixedDeltaTime);
    }
}
