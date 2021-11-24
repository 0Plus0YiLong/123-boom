using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving2 : MonoBehaviour
{
    public Rigidbody2D rb;
    public int enemyDamage = 1;
    bool ifPaused = false;
    public GameObject gameOverText, restartButton, player;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.CompareTag("Player") == true)
        {
            Kill();
        }
    }

    void Kill()
    {
        player.SetActive(false);
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