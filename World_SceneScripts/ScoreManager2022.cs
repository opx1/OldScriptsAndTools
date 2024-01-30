using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager2022 : MonoBehaviour
{
   public int score;

   public TextMeshProUGUI scoreText;

   public void IncreaseScore(int amount)
   {
      score += amount;
      UpdateScoreText();
   }

   public void DecreaseScore(int amount)
   {
      score -= amount;
      UpdateScoreText();
   }

   public void UpdateScoreText()
   {
      scoreText.text = "Score: " + score;
   }
}
