using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour {

	[SerializeField] private PlayerLifes playerLifes; // Done
	[SerializeField] private CoinSpawner coinSpawner; // Done
	[SerializeField] private Score scoreMultiplier; // Done

	public void AddLife()
	{
		playerLifes.AddLife();
	}

	public void ActivateMagnet()
	{
		coinSpawner.MagnetEnabled = true;
	}

	public void ActivateMultiplier()
	{
		scoreMultiplier.ActivateMultiplier();
	}
}
