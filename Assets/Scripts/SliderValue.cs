using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public Slider timeSlider;
    public Text timeValue;
    public static float TimeSet;

    // Update is called once per frame
    void Update()
    {
        TimeSet = timeSlider.value;
        timeValue.text = TimeSet.ToString("f0");
    }
}
