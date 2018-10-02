using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollition : MonoBehaviour {

    private GameObject player;
    private bool isHeld;
    private CircleCollider2D bc;
    private Rigidbody2D rb;
    private float timer = 2;

    public float throwForceX, throwForceY;

	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        bc = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        gameObject.layer = 8;
	}

	void Update () {

        Vector2 throwBall = new Vector2(throwForceX, throwForceY);

        if (isHeld)
        {
            gameObject.layer = 9;
            Vector3 loc = player.transform.position;
            loc.y -= 0.2f;
            transform.position = Vector3.Slerp(transform.position, loc, Time.deltaTime * 25);

            if (!PlayerMovement.facingRight)
                throwBall.x = -throwForceX;
            else
                throwBall.x = throwForceX;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(throwBall * 60);
                isHeld = false;
                timer = 2;
            }
            transform.rotation = Quaternion.Euler(0,0,0);
        }

        if (timer >= 0)
            timer -= Time.deltaTime;


        if (timer <= 0 && !isHeld)
            gameObject.layer = 8;
	}

    void Throw() {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            isHeld = true;
        }
    }
}
