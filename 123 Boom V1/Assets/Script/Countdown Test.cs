using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTest : MonoBehaviour
{
    public float timer;
    public float countdown = 3f;
    public int flag = 0;
    public int flag2 = 0;
    public int rounds = 0;
    public Vector3 curPos, lastPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rounds < 3)
        {
            countdown = 3.5f;
        }
        else if (rounds < 6)
        {
            countdown = 3f;
        }
        else
        {
            countdown = 2f;
        }
        if (flag2 == 0)
        {
            timer += Time.deltaTime;
            checkifmoving();
            if (timer > countdown)
            {
                Debug.Log("woadbsodiuhbasd");
                if (flag == 1)
                {
                    Kill();
                }
                timer = 0;
                rounds++;
            }
        }
    }

    void Kill()
    {
        Destroy(gameObject);
        Debug.Log("Destroy");
    }

    void checkifmoving()
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("SafeZone"))
        {
            flag2 = 1;
        }
    }
}
