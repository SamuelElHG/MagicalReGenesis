using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private Transform playerLocation;
    [SerializeField] private float speed;

    [SerializeField] private int health;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerLocation.position, speed*Time.deltaTime);

        // transform.position = Vector3.Lerp(transform.position, playerLocation.position, speed);
    }
}
