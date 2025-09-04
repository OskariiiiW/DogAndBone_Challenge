using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    // Start is called before the first frame update

    void Start()
    {
        timerText.text = PlayerPrefs.GetFloat("HighScore").ToString("F2") + "s";
    }
}
