using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float timer;
    public int countdown = 3;
    public int flag = 0;
    public int flag2 = 0;
    public int flag3 = 0;
    public int rounds = 0;
    public Vector3 curPos, lastPos;
    bool ifPaused = false;
    public GameObject gameOverText, restartButton, number3, number2, number1;

    void Start()
    {
        number3.SetActive(false);
        number2.SetActive(false);
        number1.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (flag2 == 0 && flag3 == 1)
        {
            timer += Time.deltaTime;
            checkifmoving();//call function to check position
            if (timer > countdown)
            {
                if (flag == 1)
                {
                    Kill();/*if flag is 1 the player is moving so destroy object*/
                }
                timer = 0;
                rounds++;
            }
        }

        if (timer >= 2.9)
        {
            number3.SetActive(true);
            number2.SetActive(false);
            number1.SetActive(false);
        }
        else if (timer > 1.95 && timer < 2.9)
        {
            number3.SetActive(false);
            number2.SetActive(true);
            number1.SetActive(false);
        }
        else if (timer > 0.9 && timer < 1.95)
        {
            number3.SetActive(false);
            number2.SetActive(false);
            number1.SetActive(true);
        }
    }

    void checkifmoving()/*check per frame if the player has moved or not*/
    {
        curPos = transform.position;
        if (curPos == lastPos)
        {
            flag = 0;
        }
        else
        {
            flag = 1;
        }
        lastPos = curPos;
    }

    private void OnTriggerEnter2D(Collider2D other)/*to check if the player has collided with the lines*/
    {
        if (other.gameObject.CompareTag("SafeZone"))
        {
            Win();
        }
        if (other.gameObject.CompareTag("SafeZoneStart"))
        {
            flag3 = 1;
        }
    }

    void Win()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void Kill()/*to destroy the game object*/
    {
        gameObject.SetActive(false);
        GameOver();
    }

    void GameOver()
    {
        Pause();
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        gameObject.SetActive(false);
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
