using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    bool ifPaused = false;
    public Button theButton;

    void Start()
    {
        Button btn = theButton.GetComponent<Button>();
        btn.onClick.AddListener(Restart);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Pause();
        Pause();
    }

    public void Pause()
    {
        if (ifPaused)
        {
            Time.timeScale = 1;
            ifPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            ifPaused = true;
        }
    }
}
