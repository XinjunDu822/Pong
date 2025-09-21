using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class logicScript : MonoBehaviour
{
    public int playerOneScore = 0;
    public int playerTwoScore = 0;
    public TextMeshProUGUI playerOneScoreText;
    public TextMeshProUGUI playerTwoScoreText;
    public bool feedPong = false;
    public AudioSource addScoreSound;
    public int firstServe = -1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int player)
    {
        addScoreSound.Play();
        if (player == 1)
        {
            playerOneScore++;
            playerOneScoreText.text = playerOneScore.ToString();
            firstServe = -1;
        }
        else
        {
            playerTwoScore++;
            playerTwoScoreText.text = playerTwoScore.ToString();
            firstServe = 1;
        }
        feedPong = true;
    }

    public int feedToWho()
    {
        return firstServe;
    }
}
