using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    // 1. 게임이 종료되면 GameoverJUI를 보여줘야함.
    // 2. 재시작 안내를 해준다.
    PlayerHealth player;
    public TimerText TimertextUI;
    public GameOverUI gameOverUI;

    private bool _isOver;
    // Start is called before the first frame update
    void Start()
    {
        _isOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void End()
    {
        TimertextUI.IsOn = false;

        //데이터 저장
        int saveBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = System.Math.Max((int)TimertextUI.SurvivalTime, saveBestTime);
        PlayerPrefs.SetInt("BestTime", bestTime);

        // GmameOverUI에다가 갱신
        gameOverUI.Activate(bestTime);

        //_isOver = true;
        _isOver = true;
    }
}
