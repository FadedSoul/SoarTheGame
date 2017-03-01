using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	[SerializeField] private GameObject onTouchParticles;
	private CoinSpawner coinSpawner;
	private GameObject player;

	void Start()
	{
		player = GameObject.FindWithTag("Player");
	}

	void Update()
	{
		if (coinSpawner.MagnetEnabled)
		{
			if (Vector2.Distance(transform.position, player.transform.position) < 6)
			{
				transform.position = Vector2.MoveTowards(transform.position, player.transform.position, Time.deltaTime * 2);
			}
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (onTouchParticles != null)
				GameObject.Instantiate(onTouchParticles, this.transform.position, Quaternion.identity);

			Destroy(this.gameObject);
		}
	}

	public CoinSpawner SetCoinSpawner
	{
		set
		{
			coinSpawner = value;
		}
	}
}
