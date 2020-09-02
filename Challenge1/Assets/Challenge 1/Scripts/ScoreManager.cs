using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Sam Ferstein
 * Assignment 1
 * This manages the score and game over screen.
 */

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool gameWon = false;
    public static int score = 0;

    public Text textbox;

    void Start()
    {
        gameOver = false;
        gameWon = false;
        score = 0;
    }

    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        if (score >= 5)
        {
            gameWon = true;
            gameOver = true;
        }
        if (gameOver)
        {
            if (gameWon)
            {
                textbox.text = "You Win!\nPress R to Try Again";
            }
            else
            {
                textbox.text = "Out of Bounds!\nPress R to Try Again";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}