using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    int creditsTime = 10000;
    public static string endName = Name.username;
    public static int endScore = Score.CurrentScore;
    public static int endLives = LifeCounter.lifeScore;

    public Text end;

    void Start()
    {
        end.text = (endName + "\n" +"Score: " + Score.CurrentScore + "\n" + "Lives: " + LifeCounter.lifeScore);
    }

    void Update()
    {
        if (creditsTime <= 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            creditsTime -= (int) Time.time;
            Debug.Log(creditsTime);
        }
    }
}
