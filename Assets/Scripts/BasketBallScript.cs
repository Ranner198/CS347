using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BasketBallScript : MonoBehaviour {

    private BoxCollider2D bc;

    private SpriteRenderer spriteRender;

    public Sprite sprite1, sprite2;

    public float timerSet;
    private float timer;

    private Text Score;
    public int score = 000;
    public GameObject targetPoint;

	void Start () {
        bc = GetComponent<BoxCollider2D>();
        spriteRender = GetComponent<SpriteRenderer>();
        timer = 0;
        Score = FindObjectOfType<Text>();
    }
	
	void Update () {

        if (Score == null)
            print("error");

        Score.text = "Score: 0" + score.ToString();
        Vector3 moveTo = new Vector3(targetPoint.transform.position.x, targetPoint.transform.position.y, targetPoint.transform.position.z - 1);
        Score.transform.position = moveTo;        

        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            spriteRender.sprite = sprite2;
        }

        if (timer < 0)
            spriteRender.sprite = sprite1;
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            timer = timerSet;
            score++;
        }
    }
}
