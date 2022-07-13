using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    // 1. ������ ����Ǹ� GameoverJUI�� ���������.
    // 2. ����� �ȳ��� ���ش�.
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

        //������ ����
        int saveBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = System.Math.Max((int)TimertextUI.SurvivalTime, saveBestTime);
        PlayerPrefs.SetInt("BestTime", bestTime);

        // GmameOverUI���ٰ� ����
        gameOverUI.Activate(bestTime);

        //_isOver = true;
        _isOver = true;
    }
}
