using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TMP_Text scoreText;
    private int curScore;
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        curScore = Player.GetComponent<Score>().CurrentScore;
        scoreText.SetText(curScore.ToString());
    }
}
