using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTime : MonoBehaviour
{
    public Text remaining;
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = SliderValue.TimeSet;
        remaining.text = timeRemaining.ToString("f0") + " seconds left";
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if(timeRemaining >= 0)
        {
            remaining.text = timeRemaining.ToString("f0") + " seconds left";
        }
        else
        {
            remaining.text = "Game Over";
        }
    }
}
