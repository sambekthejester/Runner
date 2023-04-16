using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    Canvas canvas;
    PlayerMovement player;
    Transform panel;
    Transform gamePanel;
    TextMeshProUGUI scoreText;
    TextMeshProUGUI gameOverText;
    TextMeshProUGUI welcomeText;
    CameraMovement camera;
    float scoreTimer;
    private void Awake()
    {
        SingletonThisObject();
        Time.timeScale = 0f;

        canvas = FindObjectOfType<Canvas>();
        player = FindObjectOfType<PlayerMovement>();
        panel = canvas.transform.GetChild(0).GetComponent<Transform>();
        gamePanel = canvas.transform.GetChild(1).GetComponent<Transform>();
        scoreText = gamePanel.GetComponentInChildren<TextMeshProUGUI>();
        gameOverText = panel.GetChild(3).GetComponent<TextMeshProUGUI>();
        welcomeText = panel.GetChild(0).GetComponent<TextMeshProUGUI>();
        camera = FindObjectOfType<CameraMovement>();




    }



    private void SingletonThisObject()
    {
        if (Instance == null)
        {
            Instance = this;
            //  DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void StartGame()
    {
        Debug.Log("sa");
        player.enabled = true;

        gamePanel.gameObject.SetActive(true);

        panel.gameObject.SetActive(false);

        Time.timeScale = 1f;
        panel.GetChild(4).gameObject.SetActive(true);
        panel.GetChild(1).gameObject.SetActive(false);
        scoreTimer = 0f;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        StartGame();
    }


    public void GameOver()
    {

        Time.timeScale = 0f;
        welcomeText.gameObject.SetActive(false);
        panel.gameObject.SetActive(true);

        gameOverText.gameObject.SetActive(true);

    }

    public float ScoreTimerFunc()
    {
        scoreTimer += Time.deltaTime;
        //Debug.Log(scoreTimer);
        return scoreTimer;
    }

    public void IncreaseScore()
    {
        float score = ScoreTimerFunc();



        scoreText.text = score.ToString("0");

    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void nextLevel()
    {
        player.gameObject.transform.position = new Vector3(0, 0.5f, -20);
        player.nextSpeed();
        camera.nextLevel();
    }

}
