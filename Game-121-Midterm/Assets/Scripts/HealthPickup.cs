using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    PlayerHealth playerHealth;

    public float healthBonus = 15;

    void Awake()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (playerHealth.curHealth < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.curHealth += healthBonus;
            playerHealth.healthBar.value = playerHealth.healthBar.value + healthBonus;
        }
    }
    
}
