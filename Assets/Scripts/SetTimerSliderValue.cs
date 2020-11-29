using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimerSliderValue : MonoBehaviour
{
    Slider sliderRef;
    private void Start()
    {
        sliderRef = GetComponent<Slider>();
    }
    void Update()
    {
        sliderRef.maxValue = GameManager.TIME;
        sliderRef.value = GameManager.CurrentTimer;
    }
}
