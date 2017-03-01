using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(transform.position.x+0.1f, transform.position.y, 0);

        if (transform.position.x > 13)
        {
            Destroy(gameObject);
        }
    }
}
