using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static int score;

    public TMP_Text livesText;
    public TMP_Text scoreText;

    public GameObject winScreen;
    public GameObject loseScreen;

    private async void Update()
    {
        livesText.text = "Lives : " + lives;
        scoreText.text = "Score : " + score;

        var count = FindObjectsOfType<Brick>().Length;
        if (count <= 0)
        {
            winScreen.SetActive(true);
            enabled = false;
            Invoke("SampleScene", 1f);
        }
            
        if(lives <= 0)
        {
            loseScreen.SetActive(true);
            enabled = false;
            Invoke("SampleScene", 1f);
            
        }
    }

}
