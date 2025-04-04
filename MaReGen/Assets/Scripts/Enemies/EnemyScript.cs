using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using static Elements;

public class EnemyScript : MonoBehaviour
{
     

    [SerializeField] private float speed;
    [SerializeField] private float maxHealth;
    [SerializeField] public float health;

    [SerializeField] public TipoElemento element;

    [SerializeField] private TipoElemento weakness;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, GlobalVariables.Instance.centerLane, speed*Time.deltaTime);
        transform.position = transform.position + new Vector3 (0,0,-1*speed*Time.deltaTime);
    }

    public void healthDown(TipoElemento bulletElement, float damage)
    {
        Debug.Log(bulletElement.ToString());
        if (bulletElement == weakness)
        {
            health -= damage*2;
        }else
        {
            health -= damage;
        }
        Debug.Log("New health is " + health);
        if (health <= 0)
        {
            Debug.Log("Oh no im dying ");

            //Destroy(gameObject);
            gameObject.SetActive(false);
            health = maxHealth;

        }
    }
}
