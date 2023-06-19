using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton for the ScoreManager

    public int score; // The current score

    void Awake()
    {
        // Singleton setup
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        // Keep the ScoreManager across scenes
        DontDestroyOnLoad(gameObject);
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
    }
}
