using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Elements;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private Transform playerLocation;
    [SerializeField] private float speed;

    [SerializeField] public int health;

    [SerializeField] public TipoElemento element;

    [SerializeField] private TipoElemento weakness;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerLocation.position, speed*Time.deltaTime);
    }

    public void healthDown(TipoElemento bulletElement)
    {
        Debug.Log(bulletElement.ToString());
        if (bulletElement == weakness)
        {
            health -= 2;
        }else
        {
            health -= 1;
        }
        Debug.Log("New health is " + health);
        if (health == 0)
        {
            Debug.Log("Oh no im dying ");

            Destroy(gameObject);
        }
    }
}
