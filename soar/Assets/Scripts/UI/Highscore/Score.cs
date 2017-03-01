using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	[SerializeField] private Text scoreText;
	private float score;
	private float multiplier = 1;
	private float multiplierTime = 0;
	private bool started = false;
    private float _scoreCounter;

	void Update()
	{
		if (started)
		{
            AddScore();
			if (Time.time > multiplierTime && multiplier != 1)
			{
				multiplier = 1;
			}
			scoreText.text = "Score : " + (int)PlayerInformation._Score;
            if(PlayerInformation._Score > PlayerInformation._HighScore)
            {
                PlayerInformation._HighScore = PlayerInformation._Score;
            }
		}
    }

    void AddScore()
    {
        _scoreCounter += (Time.deltaTime * 3) * multiplier;
        if(_scoreCounter >= 1)
        {
            PlayerInformation._Score++;
            _scoreCounter = 0;
        }
    }

	public void ActivateMultiplier()
	{
		multiplierTime = Time.time + 10;
		multiplier = 2;
	}

	public bool Started
	{
		set
		{
			started = value;
		}
	}
}
