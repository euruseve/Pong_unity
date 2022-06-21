using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public Text playerScoreText;
    public Text computerScoreText;


    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Ball ball;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();

        ResetRound();
    }

    public void ComputerScores()
    {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();

        ResetRound();
    }

    private void ResetRound()
    {
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();

        ball.ResetPosition();
        ball.AddStartingForce();
    }

}
