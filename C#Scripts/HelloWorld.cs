using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        // Naming a varible is called declaring
        // Begin with the data type
        string name = "Cooper Carey";
        int health = 5;
        // These next two lines have the same effect
        health = health - 2;
        health -= 2;

        health++;
        // float is a decimal value
        // rounds off eventually if too many decimal digits
        // f is required after setting the value
        float critChance = 0.6f;
        critChance += 0.2f;
        bool alive = true;
        // Debug.Log(alive);
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
