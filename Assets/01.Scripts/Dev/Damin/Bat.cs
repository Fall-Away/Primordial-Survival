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
 }

 void Start()
  {
    animator = GetComponent<Animator>();
    StartCoroutine("enemyai");
  }


    void FixedUpdate()
    {
        
    transform.position+= vec * speed * Time.deltaTime;

        if(rad == -1)
        {
            transform.eulerAngles= new Vector3(0,180,0);
        }
            else if(rad == 1)
            {
                    transform.eulerAngles= new Vector3(0,0,0);
            }

    }

    IEnumerator enemyai(){
        rad = Random.Range(-1,2);
         wiatrad =Random.Range(1,3);
        yield return new WaitForSeconds(wiatrad);
      StartCoroutine("enemyai");
    }

    void OntriggerEnter2D(CircleCollider2D other)
    {
        //여기 있는것들은 병합하고나서 플래이어 공격이랑 연동해서
        //if(isDie == false)
                // if()
                // {
                //     StartCoroutine(die());
                // }
         //}
    }
    
    IEnumerator die()
    {
        isDie = true;
       animator.SetTrigger("DIE");
       yield return new WaitForSeconds(0.06f);
       Destroy(gameObject);
    }
}
