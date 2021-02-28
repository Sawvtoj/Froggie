using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;    

public class Back : MonoBehaviour
{
    public void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
