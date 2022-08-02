using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefAttack : MonoBehaviour
{
    [SerializeField] float damage;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //collision.GetComponent<Enemy>().HP -= damage;
        }
    }
}
