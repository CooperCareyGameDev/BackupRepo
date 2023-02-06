using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadLevelOne()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LoadLevelThree()
    {
        SceneManager.LoadScene("Level3");
    }
    public void LoadTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
