﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidervolume : MonoBehaviour
{
    public Slider slider;
    public Text Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = slider.value.ToString ();
        AudioListener.volume = slider.value;
    }
}
