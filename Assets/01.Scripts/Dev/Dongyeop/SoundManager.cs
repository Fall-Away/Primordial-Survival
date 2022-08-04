using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioClip audio1;
    [SerializeField] AudioClip audio2;
    [SerializeField] AudioClip audio3;
    [SerializeField] AudioClip bossAudio;

    private AudioSource _audioSource;

    private float _realTime;

    private bool _firstAudio = false;
    private bool _secondAudio = false;
    private bool _thirdAudio = false;
    private bool _bossAudio = false;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        _realTime += Time.deltaTime;
        GameAudio();
    }

    private void GameAudio()
    {
        if (_realTime >= 0 && !_firstAudio)
        {
            _firstAudio = true;
            _audioSource.PlayOneShot(audio1);
        }
        else if (_realTime >= 11 && !_secondAudio)
        {
            _secondAudio = true;
            _audioSource.clip = audio2;
        }
        else if (_realTime >= 417 && !_thirdAudio)
        {
            _thirdAudio = true;
            _audioSource.clip = audio3;
        }
        else if (_realTime >= 600 && !_bossAudio)
        {
            _bossAudio = true;
            _audioSource.clip = bossAudio;
        }
    }
}
