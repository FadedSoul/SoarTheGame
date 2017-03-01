using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

	[SerializeField] private GameObject coinPrefab;
	[SerializeField] private float spawnDelayMin, spawnDelayMax = 0;
	[SerializeField] private Vector3[] spawnPositions;
	[SerializeField] private float magnetTime;
	[SerializeField] private bool magnetEnabled = false;

	void Start()
	{
		magnetEnabled = false;
		Invoke("SpawnCoin", Random.Range(spawnDelayMin, spawnDelayMax));
	}

	void Update()
	{
		if ((magnetEnabled) && Time.time > magnetTime)
			magnetEnabled = false;
	}

	void SpawnCoin()
	{
		GameObject newGo = GameObject.Instantiate(coinPrefab, spawnPositions[Random.Range(0,3)], Quaternion.identity);
		newGo.GetComponent<Coin>().SetCoinSpawner = this;
		Invoke("SpawnCoin", Random.Range(spawnDelayMin, spawnDelayMax));
	}

	public bool MagnetEnabled
	{
		get
		{
			return magnetEnabled;
		}
		set
		{
			magnetEnabled = value;
			if (magnetEnabled)
			{
				magnetTime = Time.time + 10f;
			}
		}
	}
}
