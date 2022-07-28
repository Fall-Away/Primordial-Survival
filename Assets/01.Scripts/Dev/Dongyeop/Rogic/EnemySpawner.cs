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

    public void StartSpawn(GameObject spawnEnemy, int spawnTime)
    {
        StartCoroutine(Spawn(spawnEnemy, spawnTime));
    }

    public void StopSpawn(GameObject spawnEnemy, int spawnTime)
    {
        StopCoroutine(Spawn(spawnEnemy, spawnTime));
    }


    IEnumerator Spawn(GameObject spawnEnemy, int spawnTime)
    {
        while (true)
        {
            pooler.SpawnObject(transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
