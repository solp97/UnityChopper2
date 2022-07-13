using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    public float SurvivalTime { get; private set; }
    public bool IsOn { get; set; }
    TMPro.TextMeshProUGUI _uiText;
    private float _Time;

    // Start is called before the first frame update
    void Start()
    {
        _uiText = GetComponent<TMPro.TextMeshProUGUI>();
        IsOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(IsOn)
        {
            _Time += Time.deltaTime;

            if (_Time >= 1f)
            {
                SurvivalTime += _Time;
                _uiText.text = $"Ω√∞£ :{(int)SurvivalTime}√ ";
                _Time = 0f;
            }
        }

    }
}
