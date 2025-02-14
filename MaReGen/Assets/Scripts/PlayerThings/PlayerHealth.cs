using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int MaxHealth;
    [SerializeField] private int CurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        Debug.Log("Salud actual = " + CurrentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            CurrentHealth--;
            Debug.Log("Chocó y le hizo daño");
            Debug.Log("Salud actual = " + CurrentHealth);
            Destroy(collision.gameObject);

        }
    }
}
