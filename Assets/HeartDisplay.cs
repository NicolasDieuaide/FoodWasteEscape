using UnityEngine;
using TMPro;

public class HeartDisplay : MonoBehaviour
{
    private TextMeshProUGUI healthText;

    private void Start()
    {
        healthText = GetComponent<TextMeshProUGUI>();

        if (healthText == null)
        {
            Debug.LogError("HeartDisplay could not find a TextMeshProUGUI component");
        }
    }

    public void UpdateHealth(int health)
    {
        if (healthText == null)
        {
            Debug.LogError("healthText is null");
        }
        else
        {
            healthText.text = "Health: " + health;
        }
    }
}
