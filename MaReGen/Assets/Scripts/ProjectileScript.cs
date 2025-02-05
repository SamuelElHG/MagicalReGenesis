using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    //[SerializeField] private float
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(die());
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime* GlobalVariables.Instance.projectileSpeed;
        // transform.Rotate(0, 1, 0);
    }
    IEnumerator die()
    {
        yield return new WaitForSeconds(GlobalVariables.Instance.projectileLifeTime);
        Destroy(gameObject);
    }
}
