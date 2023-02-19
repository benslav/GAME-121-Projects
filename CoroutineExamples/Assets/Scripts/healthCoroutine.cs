using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthCoroutine : MonoBehaviour
{
    int maxHP = 100;
    int currentHP = 0;


    void Start()
    {
        Debug.Log("Start Increasing Health");
        StartCoroutine(HealthIncrease());
        Debug.Log("Finish start event");
    }

    IEnumerator HealthIncrease()
    {
        Debug.Log("Start Coroutine");
        for (int x = 1; x <= maxHP; x++)
        {
            currentHP = x;
            //Increase or decrease the parameter of WaitForSeconds
            //to test different speeds.
            yield return new WaitForSeconds(0.2f);
            Debug.Log("HP: " + currentHP + " / " + maxHP);
        }
        Debug.Log("Current health is " + maxHP);
        Debug.Log("End Coroutine");
    }
}
