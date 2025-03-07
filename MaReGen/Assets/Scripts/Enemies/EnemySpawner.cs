using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<EnemyScript> AllEnemies = new List<EnemyScript>();

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(AllEnemies[0], transform.position, Quaternion.identity);
        Instantiate(AllEnemies[1], transform.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
