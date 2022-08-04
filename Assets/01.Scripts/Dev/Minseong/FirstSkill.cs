using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSkill : MonoBehaviour
{
    [SerializeField] int damage;
    void Start()
    {
        
    }

    void Update()
    {
        Destroy(gameObject, 0.35f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Slime"))
        {
            other.GetComponent<PMonster>().TakeDamage(damage);
        }
    }
}
