/*
 * Player 2D Rigidbody Controller Script 
 *  
 * By: Ran Crump
 *
 * Date Published: 8/21/18
 * Date Modified: 10/1/18
 * 
 * Licenses: (Attribution 4.0 International CC)
 * 
 * You are free to:
 *    Share — copy and redistribute the material in any medium or format
 *    Adapt — remix, transform, and build upon the material
 *    for any purpose, even commercially.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    //Alive Variable
    public static bool alive = true, facingRight = true;

    private Rigidbody2D rb;
    private bool grounded = true;
    private Animator anim;
    private CircleCollider2D cc;
    private BoxCollider2D bc;
    private float deathTimer = 2;
    private int jumpNum = 0;

    public float speed = 8, jumpForce = 250;

    public bool doubleJump;
    public int jumpLimit = 1;
    public LayerMask lm;
    public float rayCastLength = 3;

    //For Death Anim
    private SpriteRenderer sprite_Order_Layer;

	void Start () {
        FaceRight();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        cc = GetComponent<CircleCollider2D>();
        bc = GetComponent<BoxCollider2D>();
        jumpNum = jumpLimit;
        sprite_Order_Layer = GetComponent<SpriteRenderer>();
        //lm = ~lm;
	}
	
	// Update is called once per frame
	void Update () {
        if (!GameManager.WonState)
        {
            if (alive)
            {

                Debug.DrawRay(transform.position, Vector2.down * rayCastLength, Color.red);

                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, lm);
                float distance = Mathf.Abs(hit.point.y - transform.position.y);

                if (hit.collider.tag == "Ground" && distance < rayCastLength)
                {
                    grounded = true;
                    jumpNum = jumpLimit;
                }
                else
                {
                    grounded = false;
                    anim.Play("JumpAnim");
                }

                Vector2 input = new Vector2(Input.GetAxis("Horizontal"), 0);

                rb.AddForce(new Vector2(input.x * speed * Time.deltaTime * 60, 0));

                if (input.magnitude < .1f && input.magnitude > -.1f && grounded)
                    anim.Play("IdleAnim");

                if (input.x > 0 && grounded || input.x < 0 && grounded)
                {
                    anim.Play("RunAnim");
                }

                if (input.x > 0 && !facingRight)
                {
                    flip();
                }
                else if (input.x < 0 && facingRight)
                {
                    flip();
                }

                if (!doubleJump)
                {
                    //For Single Jump
                    if (grounded && jumpNum > 0)
                    {
                        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                        {
                            jumpNum--;
                            rb.AddForce(new Vector2(0, jumpForce * 60));
                        }
                    }
                }
                if (doubleJump)
                {
                    //For Double Jump        
                    if (jumpNum > 0)
                    {
                        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
                        {
                            jumpNum--;
                            rb.AddForce(new Vector2(0, jumpForce * 60));
                        }
                    }
                }
            }
        }
        else
        {
            anim.Play("WonAnim");
            //maybe add a fade circle effect?
        }

        if (!alive && deathTimer < 0 || deathTimer < 0 && GameManager.WonState)
        {
            SceneManager.LoadScene("SampleScene");
            alive = true;
        }
        if (!alive && deathTimer >= 0 || deathTimer >= 0 && GameManager.WonState)
            deathTimer -= Time.deltaTime;
    }

    //Flip the player sprite
    void flip() {
        facingRight = !facingRight;
        Vector3 size = gameObject.transform.localScale;
        size.x *= -1;
        gameObject.transform.localScale = size;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Spikes" && alive)
        {
            sprite_Order_Layer.sortingOrder = 2;
            anim.Play("DeathAnim");
            bc.enabled = false;
            alive = false;
            rb.AddForce(new Vector2(0, 300));
            deathTimer = 2;
        }
    }

    void FaceRight() {
        Vector3 size = gameObject.transform.localScale;
        if (size.x < 0)
            size.x *= 1;
        facingRight = true;
        gameObject.transform.localScale = size;
    }
}
