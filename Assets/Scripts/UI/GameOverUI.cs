using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI _bestTimeUI;
    public TimerText timerText;


    // Update is called once per frame
    public void Activate(int bestTime)
    {
        gameObject.SetActive(true);
        _bestTimeUI.text = $"최고기록 ; {bestTime}";
    }
}
