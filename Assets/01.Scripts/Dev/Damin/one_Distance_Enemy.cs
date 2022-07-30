using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class one_Distance_Enemy : MonoBehaviour
{
  [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float movespeed;
    [SerializeField]
    float JumpPower;
    private float distoplayer;
    private bool isGround;
    Rigidbody2D rb;

void Start()
{
  rb = GetComponent<Rigidbody2D>();
}

    // Update is called once per frame
    void Update()
    {
         Jump(); 

         distoplayer = Vector2.Distance(transform.position,player.position);

         if(distoplayer<agroRange)
        {
          ChasePlayer(); 
        }
    }

    void ChasePlayer()
    {    
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
  
    private void Jump()
    {
        if(isGround == true)
        {
          rb.AddForce(Vector3.up * JumpPower,ForceMode2D.Impulse);
        //  rb.velocity = new Vector2(0, 1 * JumpPower);
            isGround = false;
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
}
