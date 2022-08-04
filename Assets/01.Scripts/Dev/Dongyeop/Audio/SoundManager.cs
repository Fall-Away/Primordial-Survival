using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] GameObject audio1;
    [SerializeField] GameObject audio2;
    [SerializeField] GameObject audio3;
    [SerializeField] GameObject bossAudio;

    private float _realTime;

    private bool _firstAudio = false;
    private bool _secondAudio = false;
    private bool _thirdAudio = false;
    private bool _bossAudio = false;

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
            Instantiate(audio1);
        }
        else if (_realTime >= 100 && !_secondAudio)
        {
            _secondAudio = true;
            Instantiate(audio2);
        }
        else if (_realTime >= 200 && !_thirdAudio)
        {
            _thirdAudio = true;
            Instantiate(audio3);
        }
        else if (_realTime >= 300 && !_bossAudio)
        {
            _bossAudio = true;
            Instantiate(bossAudio);
        }
    }
}
