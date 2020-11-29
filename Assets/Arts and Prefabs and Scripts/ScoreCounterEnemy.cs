using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MoreMountains.Feedbacks;

public class ScoreCounterEnemy : MonoBehaviour
{

    //This script handles enemy kill score addition

    public TextMeshProUGUI ScoreText;
    public MMFeedbacks ScoreFlare; //Feedback to show you earned score

    public void AddScore()
    {
        var Score = 0;
        Score += 100;
    }
}
