using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    public Text valueText;
    public void OnSliderChanged(float value)
    {
        decimal valueConverted = (decimal)value;
        valueConverted = decimal.Round(valueConverted, 0);
        valueText.text = valueConverted.ToString() + "%";
    }
}
