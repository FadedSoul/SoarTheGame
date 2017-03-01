using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSelfDestroyer : MonoBehaviour {

	void Start()
	{
		ParticleSystem myParticleStystem = GetComponent<ParticleSystem>();
		Destroy(this.gameObject, myParticleStystem.main.duration + myParticleStystem.main.startLifetime.constant);
	}
}
