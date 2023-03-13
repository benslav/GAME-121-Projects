using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthBar;

    public Animator anim;

    public float maxHealth = 50;
    public float curHealth;

    void Start()
    {
        anim = GetComponent<Animator>();

        healthBar.value = maxHealth;
        curHealth = healthBar.value;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DeathPit")
        {
            healthBar.value -= 50f;
            curHealth = healthBar.value;
        }

        if (other.gameObject.tag == "Enemy")
        {
            healthBar.value -= 10f;
            curHealth = healthBar.value;
        }
    }

    void Update()
    {
       
    }
}
