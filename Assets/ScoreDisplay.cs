using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        if (scoreText == null)
        {
            Debug.LogError("ScoreDisplay could not find a TextMeshProUGUI component");
        }
    }

    private void Update()
    {
        if (scoreText == null)
        {
            Debug.LogError("scoreText is null");
        }
        else if (ScoreManager.instance == null)
        {
            Debug.LogError("ScoreManager.instance is null");
        }
        else
        {
            scoreText.text = "Score: " + ScoreManager.instance.score;
        }
    }
}
