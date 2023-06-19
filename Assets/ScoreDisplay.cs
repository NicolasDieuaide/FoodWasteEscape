using UnityEngine;
using TMPro; // Add this

public class ScoreDisplay : MonoBehaviour
{
    private TextMeshProUGUI scoreText;  // Replace Text with TextMeshProUGUI

    private void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>(); // Replace Text with TextMeshProUGUI

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
