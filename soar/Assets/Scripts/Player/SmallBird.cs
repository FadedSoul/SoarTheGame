using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBird : MonoBehaviour {

    [SerializeField]
    private SpriteAnimation runAnim;
    [SerializeField]
    private SpriteJumpAnimation jumpAnim;
    [SerializeField]
    private SpriteAnimation deathAnim;

    [SerializeField]
    private PlayerLifes playerLifes;

    [SerializeField]
    protected float flyForce;
    [SerializeField]
    protected Rigidbody2D myRigidbody;

    private bool _isFlying;
    private Rect _flyUpRect;

    private bool _jumpOnce;

    void Start()
    {
        _flyUpRect = new Rect(0, 0, Screen.width, Screen.height);
    }

    void Update()
    {
        Vector2 touchPos = Input.mousePosition;
        if (_flyUpRect.Contains(touchPos))
        {
            if (_jumpOnce == false)
            {
                FlyUp();
                _jumpOnce = true;
            }
        }
        else { 
            runAnim.enabled = true;
            jumpAnim.enabled = false;
            _jumpOnce = false;
        }
    }

    void OnEnable()
    {
        runAnim.enabled = true;
    }

    public void FlyUp()
    {
        runAnim.enabled = false;
        jumpAnim.enabled = true;
        myRigidbody.MovePosition(myRigidbody.position + new Vector2(0,flyForce) * Time.deltaTime );
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "PlayerKiller")
        {
            playerLifes.RemoveLife();
        }
    }
}
