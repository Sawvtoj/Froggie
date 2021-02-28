using UnityEngine;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{
    public static int lifeScore;

    public Text lifeText;

    void Update()
    {
        lifeText.text = "Lives: " + lifeScore.ToString();
    }

}
