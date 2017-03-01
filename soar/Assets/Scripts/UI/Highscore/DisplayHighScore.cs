using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighScore : MonoBehaviour {

    private Text _HighScoreText;

    void Start() {
        _HighScoreText = GetComponent<Text>();
        ShowHighScore();
    }

    void ShowHighScore()
    {
        Debug.Log(PlayerInformation._Score);
        _HighScoreText.text =   "Score \n" + PlayerInformation._Score + "\n" +
                                "HighScore \n" + PlayerInformation._HighScore;
    }
}
