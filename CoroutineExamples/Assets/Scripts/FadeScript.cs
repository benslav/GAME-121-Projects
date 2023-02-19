using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    public Image image;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            StartCoroutine(PerformFadding(2.5f));
        }
    }

    IEnumerator PerformFadding(float time)
    {
        float i = 0;

        while (i <= 1)
        {
            image.color = new Color(0.0f, 0.0f, 0.0f, i);
            i += 0.2f;
            yield return new WaitForSeconds(time / 5);
        }
    }
}
