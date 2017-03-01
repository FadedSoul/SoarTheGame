using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBird : MonoBehaviour {

    [SerializeField]
    private SpriteAnimation runAnim;
    [SerializeField]
    private SpriteJumpAnimation jumpAnim;
    [SerializeField]
    private SpriteAnimation deathAnim;

    [SerializeField]
    private SpriteRenderer sprite;

    [SerializeField]
    private PlayerLifes playerLifes;

    [SerializeField]
    protected bool grounded;
    [SerializeField]
    protected float jumpForce;
    [SerializeField]
    protected float runForce;
    [SerializeField]
    protected Rigidbody2D myRigidbody;

    private bool _right;
    private bool _left;
    private bool _up;

    private int _timesJumped;


    void Update() {
        if (_right)
        {
            if (grounded)
            {
                jumpAnim.enabled = false;
                runAnim.enabled = true;
            }
            transform.position = new Vector3(transform.position.x + runForce, transform.position.y, 0);
        }
        else if (_left)
        {
            if (grounded)
            {
                jumpAnim.enabled = false;
                runAnim.enabled = true;
            }
            transform.position = new Vector3(transform.position.x - runForce, transform.position.y, 0);
        }
        else if (!grounded)
        {
            runAnim.enabled = false;
            jumpAnim.enabled = true;
        }
        else
        {
            if (_right == false && _left == false)
            {
                runAnim.enabled = false;
                jumpAnim.enabled = false;
            }
        }
    }


    public void RunRight(){ _right = true;  sprite.flipX = false; }
    public void RunRightFalse(){ _right = false; }
    public void RunLeft(){ _left = true; sprite.flipX = true; }
    public void RunLeftFalse(){ _left = false; }
    public void Jump()
    {
        if (grounded)
        {
            myRigidbody.AddForce(new Vector2(0, jumpForce));
            grounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerKiller")
        {
            playerLifes.RemoveLife();
        }
    }
}
