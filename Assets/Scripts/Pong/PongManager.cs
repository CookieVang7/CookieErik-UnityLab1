using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongManager : MonoBehaviour
{
    [SerializeField] private PongBall ball;
    [SerializeField] private PongGoal leftGoal;
    [SerializeField] private PongGoal rightGoal;
    [SerializeField] private TMP_Text leftScoreText;
    [SerializeField] private TMP_Text rightScoreText;
    [SerializeField] private TMP_Text winnerText;
    [SerializeField] private int winningScore;
    private int leftScore = 0;
    private int rightScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        leftGoal.onScore += HandleRightScore;
        rightGoal.onScore += HandleLeftScore;
        ball.restart();
    }

    void HandleRightScore() //
    {
        rightScore++;
        if (rightScore == winningScore)
        {
            StartCoroutine(youWin(true));
        }
        rightScoreText.SetText(rightScore.ToString());
        ball.restart();
    }

    void HandleLeftScore()
    {
        leftScore++;
        if (leftScore == winningScore)
        {
            StartCoroutine(youWin(false));
        }
        leftScoreText.SetText(leftScore.ToString());
        ball.restart();
    }

    IEnumerator youWin(bool redWon)
    {
        if (redWon)
        {
            winnerText.SetText("Coca-Cola Player Wins!");
            winnerText.color = Color.red;
        }
        else 
        {
            winnerText.SetText("Pepsi Player Wins!");
            winnerText.color = Color.blue;
        }

        Time.timeScale = 0;
        float reloadTime = Time.realtimeSinceStartup + 3;
        while (Time.realtimeSinceStartup < reloadTime)
        {
            yield return 0;
        }
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadingScreen.LoadScene("MainMenu");
        }
    }
}
