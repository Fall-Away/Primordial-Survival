using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    Animator animator;
  public float speed;
 private int rad;
  private float  wiatrad;
private int damage = 2;
public int HP=2;
 Vector3 vec;


 void Update()
 {
  vec= new Vector3(rad,0,0);
   transform.position+= vec * speed * Time.deltaTime;

 }

 void Start()
  {
    animator = GetComponent<Animator>();
    StartCoroutine("enemyai");
  }


 

    IEnumerator enemyai(){
        rad = Random.Range(-1,2);
       wiatrad =Random.Range(1,2.6f);
          if(rad == -1)
        {
            //transform.Rotate(0,180,0);
            transform.eulerAngles= new Vector3(0,180,0);
        }
            else if(rad == 1)
            {
                  //transform.Rotate(0,0,0);
                  transform.eulerAngles= new Vector3(0,0,0);
            }
        yield return new WaitForSeconds(wiatrad);
      StartCoroutine("enemyai");
    }

 private void OnTriggerEnter2D(Collider2D other)
    {
      Debug.Log("1111");
      if(other.CompareTag("Player"))
      {
        other.GetComponent<Player>().HP -= damage;
      }
        //여기 있는것들은 병합하고나서 플래이어 공격이랑 연동해서
        //if(isDie == false)
                // if()
                // {
                //     StartCoroutine(die());
                // }
         //}
         if(other.CompareTag("Ground"))
         {
          if(rad == -1)
            {
             rad= 1;
                  transform.eulerAngles= new Vector3(0,0,0);
            }
              else
              {
                rad= -1;
                   transform.eulerAngles= new Vector3(0,180,0);
              }
         }
    }
    public void TakeDamage(int damage)
    {
      HP-=damage;
        if(HP<=0)
   {
    StartCoroutine(die());
   }
    }
    IEnumerator die()
    {
       animator.SetTrigger("DIE");
        gameObject.GetComponent<CircleCollider2D>().enabled = false;
       yield return new WaitForSeconds(0.67f);
       Destroy(gameObject);
    }

}
