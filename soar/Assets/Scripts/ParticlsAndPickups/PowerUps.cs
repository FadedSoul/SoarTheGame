using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour {

	private enum PowerUpType
	{
		ExtraLife,
		Speed,
		MegaSpeed,
		Magnet,
		Multiplier
	}

	[SerializeField] private PowerUpType powerUpType;
	[SerializeField] private GameObject activateParticles;
	[SerializeField] private PickupManager pickupManager;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			OnActivate();
		}
	}

	private void OnActivate()
	{
		switch(powerUpType)
		{
		case PowerUpType.ExtraLife :
			{
				pickupManager.AddLife();
				break;
			}
		case PowerUpType.Magnet :
			{
				pickupManager.ActivateMagnet();
				break;
			}
		case PowerUpType.Multiplier :
			{
				pickupManager.ActivateMultiplier();
				break;
			}
		}
		if (activateParticles != null)
			GameObject.Instantiate(activateParticles, this.transform.position, Quaternion.identity);
		Destroy(this.gameObject);
	}

	public PickupManager SetPickupManager
	{
		set
		{
			pickupManager = value;
		}
	}
}
