using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider : MonoBehaviour
{

    public platformRotation platformRotation;

    public void SliderChange(float value)
    {
        platformRotation.sensitivity = value;
    }

}
