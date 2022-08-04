using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDestroy : MonoBehaviour
{
    [SerializeField] float destroyTime;

    private float _realTime;

    private void Update()
    {
        _realTime += Time.deltaTime;

        if (destroyTime > _realTime)
            Destroy(gameObject);
    }
}
