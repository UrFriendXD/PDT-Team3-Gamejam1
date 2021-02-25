using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTimePanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI positionText;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI timeText;

    public void SetPlayersTime(int position, string playersName, float time)
    {
        // Adds one to offset 0
        position++;
        
        positionText.text = position switch
        {
            1 => "1st",
            2 => "2nd",
            3 => "3rd",
            _ => position + "th"
        };

        nameText.text = playersName;
        
        // Formats time and prints it
        var ts = TimeSpan.FromSeconds(time);
        timeText.text = $"{ts.Minutes:00}:{ts.Seconds:00}:{ts.Milliseconds:00}";
    }
}
