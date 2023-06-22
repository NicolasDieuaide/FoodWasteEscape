using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 

    public int score; 
    public int health; 

    private void Awake()
    {
        health = 100;

        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
    }

    public void DecreaseHealth(int amount)
    {
        health -= 1;

        if (health <= 0)
        {
            // Add game over logic here
        }
    }
}
