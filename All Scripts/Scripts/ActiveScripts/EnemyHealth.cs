using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    public GameObject enemy;
    public static int damageAmount = 2;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "PlayerBullet")
        {
            health -= damageAmount;
            if (health <= 0)
            {
                Destroy(enemy);
                Debug.Log("Enemy Killed");
            }
        }
    }
}
