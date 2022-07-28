using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpPower;

    [SerializeField] GameObject defAttack;
    [SerializeField] GameObject defAttackPos;
    //
    [SerializeField] GameObject secondSkill;

    bool isJump;
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        Fire();
    }
    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * moveSpeed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            rigid.AddForce(Vector2.up * jumpPower);
            isJump = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) { gameObject.transform.localScale = new Vector3(-1, 1, 1); }
        if (Input.GetKey(KeyCode.RightArrow)) { gameObject.transform.localScale = new Vector3(1, 1, 1); }
    }
    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(defAttack, defAttackPos.transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(secondSkill, transform.position, Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {

        }

        //q rlqhs
        //w skill
        //e skill
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJump = false;
        }
    }
}
