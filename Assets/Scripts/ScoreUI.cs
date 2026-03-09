using TMPro;
using UnityEngine;
public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Update()
{
    if (ScoreManager.instance == null)
    {
        Debug.LogWarning("ScoreManager.instance is null!");
        return;
    }
    
    scoreText.text = "Score: " + ScoreManager.instance.score;
}
}