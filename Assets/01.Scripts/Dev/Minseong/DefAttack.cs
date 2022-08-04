using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefAttack : MonoBehaviour
{
    [SerializeField] int damage;
    void Start()
    {
        float rt = C(GameObject.Find("Player").GetComponent<Transform>().localScale.x);
        transform.localScale = new Vector2(transform.localScale.x * rt, transform.localScale.y);
    }
    float C(float v)
    {
        if(v > 0) { return 1; }  
        if(v < 0) { return -1; }
        else { return 0; }
    }
    void Update()
    {
        Destroy(gameObject,0.3f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Slime"))
            other.GetComponent<PMonster>().TakeDamage(damage);
        if (other.gameObject.CompareTag("Bat"))
            other.GetComponent<Bat>().TakeDamage(damage);
        if (other.gameObject.CompareTag("Boss"))
            other.GetComponent<one_Distance_Enemy>().TakeDamage(damage);

    }
}
