using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _test : MonoBehaviour
{
    public float damage = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Slime"))
        {
            other.GetComponent<PMonster>().TakeDamage(damage);
        }
    }
}
