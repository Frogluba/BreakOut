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
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            score += 10;
            scoreTxt.text = score.ToString();
        }
    }
}
