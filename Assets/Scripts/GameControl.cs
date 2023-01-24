using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public Text YouGotaPoint;
    public GameObject GameOverT;

    private int score = 0;
    public bool gameOver = false;    
    public float Speed = -1.5f;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
    }

    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BirdScored()
    {
        if (gameOver)
            return;
        score++;
        YouGotaPoint.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        GameOverT.SetActive(true);
        gameOver = true;
    }
}
