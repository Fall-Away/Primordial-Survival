using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one_Distance_Enemy : MonoBehaviour
{
  public int HP =25;
  public int damage = 7;
   private Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float movespeed;
    [SerializeField]
    float JumpPower;
    private float distoplayer;
    private bool isGround;
    Rigidbody2D rb;
    private float curTime=0;
    [SerializeField]private float coolTime;
    Animator animator;
    [SerializeField]
     private Transform boxPos;
    [SerializeField]
    private Vector2 boxsize;
     private bool attacknow=false;
   private  GameObject Playerobj;
   SpriteRenderer spriteRenderer;
 

void Start()
{
  spriteRenderer = GetComponent<SpriteRenderer>();
  Playerobj = GameObject.FindGameObjectWithTag("Player");
  player = Playerobj.transform;
  animator=GetComponent<Animator>();
  rb = GetComponent<Rigidbody2D>();
}

    // Update is called once per frame
    void Update()
    {
 

         distoplayer = Vector2.Distance(transform.position,player.position);


   if(distoplayer<agroRange)
        {
          if(curTime<=0)
          { 
            StartCoroutine(attackwait());
          }   
          else
          {
              curTime-=Time.deltaTime;
          }
        }
        else
        {
          if(attacknow == false)
          {
            ChasePlayer();
          }
           curTime-=Time.deltaTime;
        }
     
        
    }

    void ChasePlayer()
    {    
      animator.SetBool("walk",true);
      if(transform.position.x<player.position.x)
        {
         transform.position+= Vector3.right * movespeed *Time.deltaTime;
         transform.eulerAngles = new Vector3(0,180,0);  
        }
          else
          {  
            transform.position+= Vector3.left * movespeed *Time.deltaTime;
            transform.eulerAngles = new Vector3(0,0,0);    
          }
    }
  
  
      private void OnCollisionEnter2D(Collision2D collision)
      {
        if(collision.gameObject.CompareTag("Ground"))
        {
          isGround = true;
        }
          else
          {
            isGround = false;
          }
      }
      private void OnDrawGizmos()
      {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(boxPos.position,boxsize);

      }
    IEnumerator attackwait()
    {
      animator.SetBool("walk",false);
          curTime=coolTime;
      attacknow = true;
             animator.SetTrigger("attack");
              yield return new WaitForSeconds(0.765f);
                Collider2D[] collider2Ds =Physics2D.OverlapBoxAll(boxPos.position,boxsize,0);
                foreach(Collider2D collider in collider2Ds)
                  {
                      if(collider.tag == "Player")
                      {
                            
                        Debug.Log("22222");
                         collider.GetComponent<Player>().HP -= damage;
                      }
                  }
                    yield return new WaitForSeconds(0.19f);
                  attacknow=false;
             
    }
    public void TakeDamage(int damage)
    {
        HP-=damage;
        StartCoroutine(HitColorAnimation());
        if(HP<=0)
          {
            StartCoroutine(die());
          }
    }
    IEnumerator die()
    {
      attacknow=true;
      curTime=100;
      animator.SetBool("walk",false);
      gameObject.GetComponent<Rigidbody2D>().gravityScale=0;
       gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
       animator.SetTrigger("die");
       yield return new WaitForSeconds(1.9f);
       Destroy(gameObject);
    }
    IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.5f);

        spriteRenderer.color = Color.white;
    }
}
