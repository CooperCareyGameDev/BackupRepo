using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject player;
    public float close = 10.0f;
    public float speed = 3.0f;
    bool isPlaying = false;
    // Update is called once per frame
    void Update()
    {
        // Gets player direction 
        Vector2 playerDirection = player.transform.position - transform.position;
        // use vector2 if it only moves left and right, use vector3 if you want it to move in any direction
        float playerDist = playerDirection.magnitude;
        playerDirection.Normalize();
        
        // Checks if player is close enough to enemy, then sets the velocity of the enemy
        if (playerDist <= close)
        {
            
            GetComponent<Rigidbody2D>().velocity = playerDirection * speed;
            GetComponent<Animator>().SetFloat("xInput", playerDirection.x);
            GetComponent<Animator>().SetFloat("yInput", playerDirection.y);
            if (isPlaying == false)
            {
                GetComponent<AudioSource>().Play();
                isPlaying = true;
            }
        }
        else
        {

            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            // use vector2 for left and right, use vector3 for any direction
            GetComponent<Animator>().SetFloat("xInput", 0);
            GetComponent<Animator>().SetFloat("yInput", 0);
            GetComponent<AudioSource>().Stop();
            isPlaying = false;
        }
        // Animates the enemy
        
    }
}
