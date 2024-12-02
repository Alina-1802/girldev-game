using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endText;

    public void InitializeUI()
    {
        scoreText.text = "Score: 0";
        endText.gameObject.SetActive(false);

        Debug.Log("ui initialized");
    }

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void ShowEndText()
    {
        endText.gameObject.SetActive(true);
    }
}
