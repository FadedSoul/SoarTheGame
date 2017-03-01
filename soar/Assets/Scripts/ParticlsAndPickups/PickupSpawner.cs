using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour {

	[SerializeField] private float spawnDelayMin, spawnDelayMax = 0;
	[SerializeField] private Vector3[] spawnPositions;
	[SerializeField] private List<GameObject> pickups = new List<GameObject>();
	[SerializeField] private PickupManager pickupManager;

	void Start()
	{
		Invoke("SpawnPickup", Random.Range(spawnDelayMin, spawnDelayMax));
	}

	private void SpawnPickup()
	{
		GameObject newGo = GameObject.Instantiate(pickups[Random.Range(0, pickups.Count)], spawnPositions[Random.Range(0,spawnPositions.Length)], Quaternion.identity);
		newGo.GetComponent<PowerUps>().SetPickupManager = pickupManager;
		Invoke("SpawnPickup", Random.Range(spawnDelayMin, spawnDelayMax));
	}
}
