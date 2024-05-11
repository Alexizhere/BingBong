using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _cpuScore;
    public Text playerText;
    public Text cpuText;
    public Paddle playerPaddle;
    public Paddle cpuPaddle;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerText.text = _playerScore.ToString();
        ResetRound();
    }
    public void CPUScores()
    {
        _cpuScore++;
        this.cpuText.text = _cpuScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.cpuPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingforce();
    }
}
