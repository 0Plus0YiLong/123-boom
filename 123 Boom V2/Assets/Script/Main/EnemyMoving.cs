using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    public Rigidbody2D rb;
    public int enemyDamage = 1;
    private void FixedUpdate()
    {
        float angle = 180f;
        rb.velocity = new Vector2(0f, -7f);
        rb.rotation = angle;
    }

    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Health health = hitInfo.GetComponent<Health>();
        if (health != null)
        {
            health.Harm(enemyDamage);
        }
        if (hitInfo.gameObject.CompareTag("Border") == true || hitInfo.gameObject.CompareTag("Player") == true)
        {
            Destroy(gameObject);
        }
    }
}