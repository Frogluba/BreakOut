using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int horBricks;
    public int verBricks;

    public GameObject brick;
    public Vector2 brickSize;

     void Start()
    {
        for (int y = 0; y < verBricks; y++)
        {
            for (int x = 0; x < horBricks; x++)
            {
                var pos = new Vector3(x * brickSize.x, y *brickSize.y, 0);
                Instantiate(brick,transform.position + pos, Quaternion.identity);
                
            }
        }
    }
}
