using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Sprite sprite1, sprite2;
    private SpriteRenderer spriteRender;

    public static bool WonState = false;

	void Start () {
        spriteRender = GetComponent<SpriteRenderer>();
        WonState = false;
        spriteRender.sprite = sprite1;
    }


    void Update() {
        if (WonState)
            spriteRender.sprite = sprite2;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            WonState = true;
        }
    }
}
