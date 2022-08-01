using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class MuteSound : MonoBehaviour
{
    public void Mute()
    {
        AudioListener.volume = AudioListener.volume == 0 ? 1 : 0;
    }
}
