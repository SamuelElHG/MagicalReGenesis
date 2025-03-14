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


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            LoseHealth();
            Debug.Log("Chocó y le hizo daño. Salud actual = " + CurrentHealth);
            Destroy(collision.gameObject);

        }
    }

    private void LoseHealth()
    {
        CurrentHealth--;
        if (CurrentHealth <= 0) {

            CharacterDeath();
        }

    }
    private void CharacterDeath()
    {
        Debug.Log("O no muero pa siempre por siempre y ceso de existir");
    }

}
