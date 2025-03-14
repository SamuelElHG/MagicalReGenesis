using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<EnemyScript> AllEnemies = new List<EnemyScript>();
    private float minEnemySpawnCD;
    private float maxEnemySpawnCD;
    private float cd;
    private int CurrentEnemyIndex;


    // Start is called before the first frame update
    void Start()
    {
        minEnemySpawnCD = EnemyGlobalVariables.Instance.minEnemySpawnCD;
        maxEnemySpawnCD = EnemyGlobalVariables.Instance.maxEnemySpawnCD;
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            CurrentEnemyIndex = Random.Range(0, AllEnemies.Count);
            Instantiate(AllEnemies[CurrentEnemyIndex], transform.position, Quaternion.identity);
            cd = Random.Range(minEnemySpawnCD, maxEnemySpawnCD);
            yield return new WaitForSeconds(cd);
        }
    }
}
