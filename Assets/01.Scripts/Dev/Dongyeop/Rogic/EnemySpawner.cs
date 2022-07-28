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

    public void StartSpawn(GameObject spawnEnemy, float spawnTime)
    {
        StartCoroutine(Spawn(spawnEnemy, spawnTime));
    }

    public void StopSpawn(GameObject spawnEnemy, float spawnTime)
    {
        StopCoroutine(Spawn(spawnEnemy, spawnTime));
    }


    IEnumerator Spawn(GameObject spawnEnemy, float spawnTime)
    {
        while (true)
        {
            pooler.SpawnObject(transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
