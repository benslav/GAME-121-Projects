using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movementCoroutine : MonoBehaviour
{
    public GameObject squarePrefab1;
    public GameObject squarePrefab2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            StartCoroutine(BuildBoard(10));
        }
    }

    IEnumerator BuildBoard(int size)
    {
        for (int i = 0; i < size; i++) 
        {
            for (int j = 0; j < size; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    Instantiate(squarePrefab1,
                        new Vector3(i, 0, j),
                        Quaternion.identity);
                }
                else
                {
                    Instantiate(squarePrefab2,
                        new Vector3(i, -0.015f, j),
                        Quaternion.identity);
                }
                
                yield return new WaitForSeconds(0.1f);
            }
        }
    }
}
