using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int CurrentScore;

    // Start is called before the first frame update
    void Start()
    {
        CurrentScore = 0;
    }

    void Update()
    {
        if (CurrentScore == -5)
        {
            SceneManager.LoadScene(2);
        }
    }

}
