using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseComponent : MonoBehaviour
{
    public GameObject pausePanel;
    bool isPaused = false;
    //TextMeshProUGUI m_meshProUGUI;

    void Start()
    {
        //m_meshProUGUI = this.GetComponent<TextMeshProUGUI>();
        //m_meshProUGUI = this.transform.Find("PauseButtonText").GetComponent<TextMeshProUGUI>();
        //m_meshProUGUI = this.GetComponentInChildren<TextMeshProUGUI>(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
            //m_meshProUGUI.text = "Resume";
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            //m_meshProUGUI.text = "Pause";
            pausePanel.SetActive(false);
        }
        //Time.timeScale = isPaused ? 0 : 1;
    }
}
