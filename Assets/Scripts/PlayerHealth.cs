using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;

    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }

        Debug.Log(currentHealth);
    }

    private void Die()
    {
        Debug.Log("Dead");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}