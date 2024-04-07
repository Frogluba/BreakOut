using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.DOScale(new Vector3(2, 2, 2), 1f).SetEase(Ease.InBounce).SetDelay(1f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        transform.DOScale(Vector3.one * 1.5f, 0.1f)
            .SetEase(Ease.Linear)
            .SetLoops(2, LoopType.Yoyo)
            .ChangeStartValue(Vector3.one);
    }
}
