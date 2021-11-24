using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public GameObject first, second, last;
    void Start()
    {
        first.SetActive(true);
        second.SetActive(true);
        last.SetActive(true);
    }

    public void Lifes(int s)
    {
        if(s == 3)
        {
            first.SetActive(true);
            second.SetActive(true);
            last.SetActive(true);
        }
        if(s == 2)
        {
            first.SetActive(false);
            second.SetActive(true);
            last.SetActive(true);
        }
        if(s == 1)
        {
            first.SetActive(false);
            second.SetActive(false);
            last.SetActive(true);
        }
        if(s == 0)
        {
            first.SetActive(false);
            second.SetActive(false);
            last.SetActive(false);
        }
    }
}
