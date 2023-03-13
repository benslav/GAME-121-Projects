using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    PlayerHealth health;
    PlayerPoints points;

    public GameObject losePanel;
    public GameObject winPanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health.curHealth == 0)
        {
            Time.timeScale = 0;
            losePanel.SetActive(true);
        }

        if (points.curPoints == 50)
        {
            Time.timeScale = 0;
            winPanel.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetTheGame();
        }
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
