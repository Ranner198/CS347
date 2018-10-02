using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBuilding : MonoBehaviour {

    public GameObject Player;

    private Rigidbody2D rb;

    private Vector2 loc;

	void Start () {
        rb = Player.GetComponent<Rigidbody2D>();
	}

	void Update () {
        if (PlayerMovement.alive)
        {
            loc += rb.velocity / 900;
            Vector3 fix = new Vector3(loc.x, loc.y, 0);
            transform.position = fix;
        }
	}
}
