using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator animator;
    SpriteRenderer spriteRenderer;
    Vector3 startScale;

    [SerializeField] float moveSpeed;
    [SerializeField] float jumpPower;

    [SerializeField] float defSkillTime = 5f;
    [SerializeField] float firstSkillTime = 5;
    [SerializeField] float secondSkillTime = 8;
    float curDefSkillTime;
    float curFirstSkillTime;
    float curSecondSkillTime;

    public int HP = 10;

    [SerializeField] GameObject _defAttack;
    [SerializeField] GameObject DefAttackPos;
    [SerializeField] GameObject _defAttackSound;
    //
    [SerializeField] GameObject _firstSkill;
    [SerializeField] GameObject _firstSkillSound;
    //
    [SerializeField] GameObject _secondSkill;
    [SerializeField] GameObject SecondSkillPos;
    [SerializeField] GameObject _secondSkillSound;

    [SerializeField] GameObject _getDamageSound;

    bool isJump;
    bool facingRight;
    private bool _playerDie = false;


    void Start()
    {
        startScale=transform.localScale;
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (_playerDie == true) return;

        curDefSkillTime += Time.deltaTime;
        curFirstSkillTime += Time.deltaTime;
        curSecondSkillTime += Time.deltaTime;
        Move();
        Fire();
        Die();
    }
    float x;
    void Move()
    {
        x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x, 0, 0) * moveSpeed * Time.deltaTime;
/*        Vector2 playerVelocity = new Vector2(x * 2, rigid.velocity.y);
        rigid.velocity = playerVelocity;*/

        bool playerHasHorizontalSpeed = Mathf.Abs(x) > Mathf.Epsilon;
        animator.SetBool("isRunning", playerHasHorizontalSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && !isJump)
        {
            rigid.AddForce(Vector2.up * jumpPower);
            isJump = true;
        }

        if(x > 0 && facingRight) { Flip(); }
        if(x < 0 && !facingRight) { Flip(); }
    }
    void Flip()
    {
        Vector3 curScale = transform.localScale;
        curScale.x *= -1;
        transform.localScale = curScale;

        facingRight = !facingRight;
    }

    void Fire()
    {
        if (Input.GetKeyDown(KeyCode.Q) && curDefSkillTime >= defSkillTime)
        {
            Instantiate(_defAttack, DefAttackPos.transform.position, Quaternion.identity);
            curDefSkillTime = 0;
            animator.SetTrigger("isAttack");
            Instantiate(_defAttackSound);
        }
        if (Input.GetKeyDown(KeyCode.W) && curFirstSkillTime >= firstSkillTime)
        {
            Instantiate(_firstSkill, transform.position, Quaternion.identity);
            curFirstSkillTime = 0;
            animator.SetTrigger("FirstSkill");
            Instantiate(_firstSkillSound);
        }
        if (Input.GetKeyDown(KeyCode.E) && curSecondSkillTime >= secondSkillTime)
        {
            Instantiate(_secondSkill, SecondSkillPos.transform.position, Quaternion.identity);
            curSecondSkillTime = 0;
            Instantiate(_secondSkillSound);
        }

        //q rlqhs
        //w skill
        //e skill
    }

    public void TakeDamage(int damage)
    {
        HP -= damage;
        Instantiate(_getDamageSound);
    }

    void Die()
    {
        if (HP <= 0)
        {
            animator.SetBool("isDie", true);
            _playerDie = true;
            StartCoroutine(PlayerDie());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJump = false;
        }
    }

    IEnumerator PlayerDie()
    {
        yield return new WaitForSeconds(1.3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(3);
    }
}
