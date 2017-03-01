using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLifes : MonoBehaviour {

	[SerializeField] private int lifes;
	[SerializeField] private Text lifesText;
	[SerializeField] private Rigidbody2D playerRigidBody;
	[SerializeField] private GameObject startPlatform;

    [SerializeField] private int deathScene;

	void Start()
	{
		lifesText.text = "Lifes : " + lifes.ToString();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			AddLife();
		}
		if (Input.GetKeyDown(KeyCode.O))
		{
			RemoveLife();
		}
	}

	public void RemoveLife()
	{
		if (lifes >= 1)
		{
			lifes--;
            ResetRun();
		}
		if (lifes <= 0)
		{
            Debug.Log("dead");
            GameOver();

        }
		lifesText.text = "Lifes : " + lifes.ToString();
	}

	public void AddLife()
	{
		if (lifes < 3)
		{
			lifes++;
			lifesText.text = "Lifes : " + lifes.ToString();
		}
	}

	private void ResetRun()
	{
		Vector3 newPos = new Vector3(0,5,0);
		playerRigidBody.velocity = new Vector2(0,0);
		playerRigidBody.transform.position = newPos;
		Start();
	}

	private void GameOver()
	{
		SceneManager.LoadScene(deathScene);
	}
}
