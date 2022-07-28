using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
     private float currenttime;
     private float RandomTime;
    void Start()
    {
        RandomTime=Random.Range(0,7);
    }

    // Update is called once per frame
    void Update()
    {
        currenttime+=Time.deltaTime;
        if(currenttime>RandomTime)
        {
            
        }
       
    }
    IEnumerator right()
    {
        transform.eulerAngles= new Vector3(0,0,0);
        yield return null;
    }
    IEnumerator RandomMove()
    {
           transform.eulerAngles= new Vector3(0,0,0);
           
    }
}
