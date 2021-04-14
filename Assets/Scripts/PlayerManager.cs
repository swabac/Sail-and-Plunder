using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public GameObject StartingText;
    public GameObject StartingPanel;

    public static bool StartTheGame;

    public static int NumberOfCoins;
    public Text CoinText;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        StartTheGame = false;
        Time.timeScale = 0.01f;
        NumberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0.02f;
           

            gameOverPanel.SetActive(true);
            Destroy(gameObject);
        }

        CoinText.text = "Score:" + NumberOfCoins;

        if (SwipeManager.tap)
        {

            StartTheGame = true;
            Time.timeScale = 1;
            Destroy(StartingText);
            Destroy(StartingPanel);

        }
    }
}
