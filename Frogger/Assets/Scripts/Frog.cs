using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;

    int min_x = -3;
    int max_x = 3;
    int min_y = -4;
    int max_y = 4;
    
    void Update()
    {
        Vector2 clampPosition = transform.position;

        clampPosition.x = Mathf.Clamp(clampPosition.x, min_x, max_x);
        clampPosition.y = Mathf.Clamp(clampPosition.y, min_y, max_y);

        transform.position = clampPosition;
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }
        
        if (LifeCounter.lifeScore <= 0)
        {
            SceneManager.LoadScene("Credits");
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            Debug.Log("WE LOST");
            Score.CurrentScore -= 50;
            LifeCounter.lifeScore = LifeCounter.lifeScore - 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}