using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float close = 10.0f;
    public float speed = 3.0f;
    // Update is called once per frame
    void Update()
    {
        // Gets player direction 
        Vector3 playerDirection = player.transform.position - transform.position;
        float playerDist = playerDirection.magnitude;
        playerDirection.Normalize();
        
        // Checks if player is close enough to enemy, then sets the velocity of the enemy
        if (playerDist <= close)
        {
            
            GetComponent<Rigidbody2D>().velocity = playerDirection * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }
        // Animates the enemy
        GetComponent<Animator>().SetFloat("xInput", playerDirection.x);
        GetComponent<Animator>().SetFloat("yInput", playerDirection.y);
        
    }
}
