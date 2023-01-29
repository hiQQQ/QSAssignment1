using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public Slider mySlider;
    public Text sliderValue;

    void Update()
    {
	sliderValue.text = mySlider.value.ToString("0");     
    }
}
