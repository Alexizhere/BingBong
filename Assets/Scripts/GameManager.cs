using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int _playerScore;
    private int _cpuScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.ball.ResetPosition();
    }
    public void CPUScores()
    {
        _cpuScore++;
        this.ball.ResetPosition();
    }
}
