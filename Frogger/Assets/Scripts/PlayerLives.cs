using UnityEngine;
using UnityEngine.UI;

public class PlayerLives : MonoBehaviour
{
    public Dropdown cDropdown;

    public static int playerLives;
    public static bool lifeCheck = false;

    public Text lifeText;

    public void LifeChoice()
    {
        switch(cDropdown.value)
        {
            default:
                playerLives = 0;
                lifeCheck = true;
                break;

            case 1:
                playerLives = 1;
                lifeCheck = true;
                break;

            case 2:
                playerLives = 2;
                lifeCheck = true;
                break;

            case 3:
                playerLives = 3;
                lifeCheck = true;
                break;

            case 4:
                playerLives = 4;
                lifeCheck = true;
                break;

            case 5:
                playerLives = 5;
                lifeCheck = true;
                break;
        }
    }
}
