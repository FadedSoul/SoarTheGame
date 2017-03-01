using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemey : MonoBehaviour {

    [SerializeField]
    private SpriteRenderer sprite;

    [SerializeField]
    private float runspeed;

    [SerializeField]
    private Vector2 endpoint;

    [SerializeField]
    private Vector2 startPoint;

    private bool there = false;

    // Use this for initialization
    void Start()
    {
        startPoint = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x > startPoint.x) { there = true; }
        if (transform.position.x < endpoint.x) { there = false; }

        if (there)
        {
            sprite.flipX = true;
            transform.position = new Vector2(this.transform.position.x - runspeed * Time.deltaTime, this.transform.position.y);
            Debug.Log("boi walk");
        } else if(!there){
            sprite.flipX = false;
            transform.position = new Vector2(this.transform.position.x + runspeed * Time.deltaTime, this.transform.position.y);
        }
    }
}
