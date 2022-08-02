using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
    Animator animator;
  public float speed;
 private int rad;
  private float  wiatrad;
private  bool isfollow= false;
private float damage = 2;
public float HP=2;
 Vector3 vec;
 private bool isDie = false;

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
    
    IEnumerator die()
    {
        isDie = true;
       animator.SetTrigger("DIE");
       yield return new WaitForSeconds(0.06f);
       Destroy(gameObject);
    }
}
