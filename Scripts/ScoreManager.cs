using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;


    int currentScore = 0;

    void Start()
    {
        scoreText.text = scoreText.ToString() + " points";

    }
    public void ChangeScore()
    {
        currentScore += 5;
        scoreText.text = scoreText.ToString() + "points";
    }
}
