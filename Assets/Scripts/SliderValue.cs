using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    public Slider[] sliderVal;
    public float[] sliderValInt;

    void Update()
    {
        sliderValInt[0] = sliderVal[0].value;
        sliderValInt[1] = sliderVal[1].value;
        sliderValInt[2] = sliderVal[2].value;
    }
}
