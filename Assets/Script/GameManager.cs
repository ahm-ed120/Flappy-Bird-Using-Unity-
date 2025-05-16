using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject getReady;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        getReady.SetActive(true);
        gameOver.SetActive(false);
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        gameOver.SetActive(false);
        playButton.SetActive(false);
        getReady.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i< pipes.Length ; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }

    private void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }
   
}
