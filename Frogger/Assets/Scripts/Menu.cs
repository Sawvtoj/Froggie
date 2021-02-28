using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    void Start()
    {
        Score.CurrentScore = 0;
    }

    public void Play()
    {
        if (PlayerLives.lifeCheck == false)
        {
            LifeCounter.lifeScore = 3;
        }

        else
        {
            LifeCounter.lifeScore = PlayerLives.playerLives;
        }
        
        SceneManager.LoadScene("Lvl 1");
    }

    public void Exit()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

    public void Setting()
    {
        SceneManager.LoadScene("Settings");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("Instructions");
    }
}
