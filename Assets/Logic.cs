using UnityEngine;
using TMPro; 
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{

    /*
        Handles game logic during Game Scene (scorekeeping, gameover + buttons, audio while playing)
    */

    [SerializeField] private int playerScore;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private AudioSource ding;
    [SerializeField] private AudioSource aww;

    public void AddScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        ding.Play();
    }

    public int GetScore() => playerScore;

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        aww.Play();
    }

    public void BackToTitle()
    {
        SceneManager.LoadScene("TitleScene", LoadSceneMode.Single); // wanna restrat to current scene
    }


}
