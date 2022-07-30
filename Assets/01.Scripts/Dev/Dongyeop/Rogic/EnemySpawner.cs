using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    ObjectPooler pooler;

    private void Awake()
    {
        pooler = GetComponent<ObjectPooler>();
    }

    public void StartSpawn(int spawnTime)
    {
        StartCoroutine(Spawn(spawnTime));
    }

    public void StopSpawn(int spawnTime)
    {
        StopCoroutine(Spawn(spawnTime));
    }

    public void ReturnYOU(GameObject GO)
    {
        pooler.ReturnObject(GO);
    }


    IEnumerator Spawn(int spawnTime)
    {
        while (true)
        {
            pooler.SpawnObject(transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
