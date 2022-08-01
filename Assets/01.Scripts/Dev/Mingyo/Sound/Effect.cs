using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Effect : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSlider;
    
    public void AudioControl()
    {
        float sound = audioSlider.value;

        if(sound == -40f)
        {
            masterMixer.SetFloat("Effect", -80);
        }
        else
        {
            masterMixer.SetFloat("Effect", sound);
        }
    }

    public void ToggleAudioVolume()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
}
