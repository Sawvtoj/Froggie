using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public InputField playerNameInput;
    public Text nameText;
    public static string username;

    public void FindName()
    {
        username = playerNameInput.text;
    }

    void Start()
    {
        nameText.text = username;
    }
}
