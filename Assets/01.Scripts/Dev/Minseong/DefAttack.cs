using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefAttack : MonoBehaviour
{
    [SerializeField] float damage;
    void Start()
    {
        
    }

    void Update()
    {
        Destroy(gameObject,1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //collision.GetComponent<Enemy>().HP -= damage;
        }
    }
}
