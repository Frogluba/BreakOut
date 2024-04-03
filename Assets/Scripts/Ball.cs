using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public int score = 0;
    public TMP_Text scoreTxt;
    public GameObject spot;
    public AudioClip click;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(Random.Range(-1f, 1f),1);
    }

    private void Update()
    {
       
        rb.velocity = rb.velocity.normalized * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        var brick = collision.gameObject.GetComponent<Brick>();

        if (collision.gameObject.CompareTag("Wall"))
        {
            var source = GetComponent<AudioSource>();
            source.clip = click;
            source.Play();

        }
           
        if (brick)
        {
            brick.Damage();
        }

        if(collision.gameObject.CompareTag("End"))
        {
            transform.position = spot.transform.position;
            GameManager.lives--;
            
        }

    }
}
