using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondSkill : MonoBehaviour
{
    [SerializeField] int damage;
    [SerializeField] float speed = 8;
    Player player;
    Vector3 dir;
    void Start()
    {
        dir = new Vector3(GameObject.Find("Player").GetComponent<Transform>().localScale.x, 0, 0);

        float rt = C(GameObject.Find("Player").GetComponent<Transform>().localScale.x);
        transform.localScale = new Vector2(transform.localScale.x * rt, transform.localScale.y);
    }
    float C(float v)
    {
        if (v > 0) { return 1; }
        if (v < 0) { return -1; }
        else { return 0; }
    }


    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        Destroy(gameObject, 3f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Slime"))
        {
            other.GetComponent<PMonster>().TakeDamage(damage);
        }
    }
}
