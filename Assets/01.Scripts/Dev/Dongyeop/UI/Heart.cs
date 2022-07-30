using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private Animator _animator;

    private float _realTime;

    private bool _isGray = true;
    private bool _isRun = true;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _realTime += Time.deltaTime;

        if (_realTime >= 38f && _isRun == true)
            Run();
    }

    private void Run()
    {
        _animator.SetBool("isRun", true);
        _isRun = false;
    }
}
