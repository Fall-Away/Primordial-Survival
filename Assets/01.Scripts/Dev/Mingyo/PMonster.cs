using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PMonster : MonoBehaviour
{
    GameObject target;
    Animator animator;
    public float speed = 5;
    public float hp = 5;
    void Start()
    {
        
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }
}
