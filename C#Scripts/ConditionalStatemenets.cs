using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatemenets : MonoBehaviour
{
    int lvl = 3;
    public int xp = 10;
    public int levelUpXp = 15;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (xp >= levelUpXp)
        {
            lvl++;
            xp -= levelUpXp;
            levelUpXp += 5;
            Debug.Log($"Level Up! You are now level {lvl}!");
            
        }
        
    }
}
