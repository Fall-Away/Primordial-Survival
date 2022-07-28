using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Vector3 vec;
    [SerializeField]float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,7);
                if(one_Distance_Enemy.isright)
        {
            vec = Vector3.right;
        }
        else
        {
            vec = Vector3.left;
        }
    }

    // Update is called once per frame
    void Update()
    {

        transform.position+= vec * speed * Time.deltaTime;
    }
}
