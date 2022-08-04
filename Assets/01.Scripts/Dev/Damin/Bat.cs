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
[SerializeField]AudioSource attacksound;

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
      if(other.CompareTag("Player"))
      {
      AudioSource audio= Instantiate(attacksound);
      audio.transform.position=transform.position;
        other.GetComponent<Player>().HP -= damage;
      }
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
