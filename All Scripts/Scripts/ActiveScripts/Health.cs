using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Health : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public TextMeshProUGUI healthText;
    public int healing = 4;
    // name of the lose screen
    public string sceneName;
    // Start is called before the first frame update
    public AudioClip potionDrink;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        healthText.text = $"Health: {health}/{maxHealth}";
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "DamageTag")
        {
            health -= 2;
            if (health <= 0)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
        else if (otherTag == "HealingPowerUp")
        {
            health += healing;
            Destroy(collision.gameObject);
            GetComponent<AudioSource>().PlayOneShot(potionDrink);
            if (health > maxHealth)
            {
                health = maxHealth;
                
            }
        }
    }
}

