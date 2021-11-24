using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int curHealth = 3;
    public GameObject gameOverText, restartButton;
    bool ifPaused = false;
    public float t = 0;
    public Life life;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Harm(int damage)
    {
        curHealth -= damage;
        life.Lifes(curHealth);
        if (curHealth <= 0)
        {
            GameOver();
        }
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
        if(ifPaused)
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
