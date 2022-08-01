using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    ObjectPooler pooler;

    private int _spawnScore = 0;
    private int _spawnScoreMax;

    private void Awake()
    {
        pooler = GetComponent<ObjectPooler>();
    }

    public void StartSpawn(int spawnTime)
    {
        StartCoroutine(Spawn(spawnTime));
    }

    public void ReturnYOU(GameObject GO)
    {
        pooler.ReturnObject(GO);
    }


    IEnumerator Spawn(int spawnTime)
    {
        _spawnScore = 0;

        if (spawnTime == 3)
            _spawnScoreMax = 20;
        else if (spawnTime == 2)
            _spawnScoreMax = 30;
        else if (spawnTime == 1)
            _spawnScoreMax = 60;
        else
            _spawnScoreMax = 1;

        while (true)
        {
            _spawnScore++;

            pooler.SpawnObject(transform.position, Quaternion.identity);

            if (_spawnScore == _spawnScoreMax)
                break;

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
