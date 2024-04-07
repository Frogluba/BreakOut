using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Brick : MonoBehaviour
{
    public int hp = 1;
    public int score = 100;

     void Start()
    {
        transform.DOScale(Vector3.one, 1f)
           .ChangeStartValue(Vector3.zero)
           .SetDelay(Random.Range(0f, 1f))
           .SetEase(Ease.OutElastic);

    }

    public void Damage()
    {
        hp--;

        if(hp<= 0)
        {
            Destroy(gameObject);
            GameManager.score += score;
        }
    }
}
