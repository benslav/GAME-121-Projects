using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    public TMP_Text PLAYER_POINTS_TXT;
    

    public Animator anim;

    public float maxPoints = 50;
    public float curPoints;

    void Start()
    {
        anim = GetComponent<Animator>();

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Point")
        {
            StartCoroutine(PointUpdate());
        }
    }

    IEnumerator PointUpdate()
    {
        PLAYER_POINTS_TXT.text = curPoints.ToString();
        yield return curPoints;
    }
}
