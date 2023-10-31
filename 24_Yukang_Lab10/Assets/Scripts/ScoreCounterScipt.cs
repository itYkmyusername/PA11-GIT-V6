using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounterScipt : MonoBehaviour
{
    public Text ObstacleCountText;
    private int ObstacleScore = 0;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            ObstacleScore += 1;
            ObstacleCountText.text = "SCORE : " + ObstacleScore;
            Destroy(other.gameObject);
        } 
    }
}
