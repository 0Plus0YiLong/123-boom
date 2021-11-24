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
            flag3 = 0;
        }
        if (other.gameObject.CompareTag("SafeZoneStart"))
        {
            flag3 = 1;
        }
    }


    void Kill()/*to destroy the game object*/
    {
        gameObject.SetActive(false);
    }

    
}
