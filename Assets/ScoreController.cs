using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public static ScoreController instance;
    private int score;

    private void Awake()
    {
        // Singleton pattern
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        // Don't destroy this object when a new scene is loaded
        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int amount)
    {
        score += amount;
    }

    public int GetScore()
    {
        return score;
    }
}
