using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(die());

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(1, 0, 0) * Time.deltaTime;
        transform.Rotate(0, 1, 0);
    }
    IEnumerator die()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
