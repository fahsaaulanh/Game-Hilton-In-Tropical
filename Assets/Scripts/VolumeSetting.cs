using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    public Slider _slider;

    void Start()
    {
        _slider.value = SoundManager.instance.GetUpdateVolume();
    }

    // Update is called once per frame
    void Update()
    {
        SoundManager.instance.VolumeSet(_slider.value);
    }
}
