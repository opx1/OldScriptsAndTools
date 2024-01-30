using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class ImageBehavior2020 : MonoBehaviour
{
    private Image img;
    public void Start()
    {
        img = GetComponent<Image>();
    }

    public void DisplayValue(FloatData data)
    {
        img.fillAmount = data.value;
    }
}
