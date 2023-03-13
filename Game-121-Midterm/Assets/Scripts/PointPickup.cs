using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointPickup : MonoBehaviour
{
    PlayerPoints playerPoints;

    public float pointBonus = 15;

    void Awake()
    {
        playerPoints = FindObjectOfType<PlayerPoints>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy (gameObject);
        playerPoints.curPoints += pointBonus;
    }
}
