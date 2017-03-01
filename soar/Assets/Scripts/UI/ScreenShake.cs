using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour {

    [SerializeField]
    private Vector3 originalCameraPosition;

    float shakeAmt = 0;

    private bool shake = false;

    [SerializeField]
    private Camera mainCamera;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "PlayerKiller")
        {
            shake = true;
        }

    }

    void Update()
    {
        if (shake)
        {
            mainCamera.transform.position = new Vector3(Random.Range(0,0.1f), Random.Range(0, 0.1f), -10);
        }
    }
}
