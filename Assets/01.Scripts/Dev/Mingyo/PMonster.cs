using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PMonster : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    Vector2 attackVel;
    public GameObject effectSound;
    public float speed = 5;
    public int damage = 1;
    private bool isGround;
    public float maxHp;
    public float currentHp;
    private bool isdie;

    private Transform player;
    private GameObject Playerobj;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentHp = maxHp;

        Playerobj = GameObject.FindGameObjectWithTag("Player");
        player = Playerobj.transform;
    }

    void Update()
    {
        if(isdie == true)
        {
            return;
        }
        animator.SetBool("isMove", true); // 이동 애니메이션
        Jump();
        ChasePlayer(); //플레이어 추적
    }

    private void Jump()
    {
        if(isGround == true)
        {
            rb.velocity = new Vector2(0, 1 * speed);
            isGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            isGround = true;
        }
        if (collision.gameObject.tag == "Skill")
        {
            Instantiate(effectSound);
        }

        if (collision.collider.gameObject.CompareTag("Player"))
        {
            collision.collider.GetComponent<Player>().TakeDamage(damage);
        }
    }


    public void TakeDamage(float damage)
    {
        currentHp -= damage;

        if(gameObject.transform.rotation.y == 0)
        {
            attackVel = new Vector2(9f, 0);
            gameObject.GetComponent<BoxCollider2D>().enabled = false; //피격 시 콜라이더 끄기
            rb.AddForce(attackVel, ForceMode2D.Impulse);  //피격 시 넉백
            Invoke("Collider", 0.1f);
        }
        else
        {
            attackVel = new Vector2(-2f, gameObject.transform.position.y);
        }

        StopCoroutine("Hitani");
        StartCoroutine("Hitani");
        
        if(currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Hitani() //피격 효과
    {
        animator.SetBool("Hit", true);
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("Hit", false);
    }

    public void Collider() //피격 시 껐던 콜라이더 키기
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
