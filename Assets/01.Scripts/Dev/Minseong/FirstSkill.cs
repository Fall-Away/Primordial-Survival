using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstSkill : MonoBehaviour
{
    [SerializeField] int damage;

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
        if (other.gameObject.CompareTag("Bat"))
            other.GetComponent<Bat>().TakeDamage(damage);
        if (other.gameObject.CompareTag("Boss"))
            other.GetComponent<one_Distance_Enemy>().TakeDamage(damage);
    }
}
