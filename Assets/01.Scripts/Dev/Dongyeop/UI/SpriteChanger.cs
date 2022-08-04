using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour
{
    [SerializeField] Sprite speakerOn;
    [SerializeField] Sprite speakerOff;

    private Image _image;

    private bool _isSpeaker = true;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        _image.sprite = speakerOn;
    }

    public void SpeakerButtonChange()
    {
        if (_isSpeaker == true)
        {
            _image.sprite = speakerOff;
            _isSpeaker = false;
        }
        else if (_isSpeaker == false)
        {
            _image.sprite = speakerOn;
            _isSpeaker = true;
        }
    }
}
