using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseComponent : MonoBehaviour
{
    bool isPaused = false;
    TextMeshProUGUI m_meshProUGUI;

    void Start()
    {
        //m_meshProUGUI = this.GetComponent<TextMeshProUGUI>();
        //m_meshProUGUI = this.transform.Find("PauseButtonText").GetComponent<TextMeshProUGUI>();
        m_meshProUGUI = this.GetComponentInChildren<TextMeshProUGUI>();
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
            m_meshProUGUI.text = "Resume";
        }
        else
        {
            Time.timeScale = 1;
            m_meshProUGUI.text = "Pause";
        }
        //Time.timeScale = isPaused ? 0 : 1;
    }
}
