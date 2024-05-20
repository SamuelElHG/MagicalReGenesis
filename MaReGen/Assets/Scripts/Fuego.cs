using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuego : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(morir());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= transform.position+new Vector3(0,1,0)*Time.deltaTime;
    }

    IEnumerator morir()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
