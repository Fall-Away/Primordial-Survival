using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSkill : MonoBehaviour
{
    [SerializeField] float speed = 8;
    Player player;
    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        Destroy(gameObject, 3f);
    }
}
