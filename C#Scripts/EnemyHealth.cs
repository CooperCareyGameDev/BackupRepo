using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 10;
    public GameObject slime;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "BulletTag")
        {
            health -= 2;
            if (health <= 0)
            {
                Destroy(slime);
                Debug.Log("Slime Killed");
            }
        }
    }
}
