using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    
    [SerializeField] private int _spawnScore = 0;
    [SerializeField] private int _spawnScoreMax;


    public void StartSpawn(float spawnTime)
    {
        StartCoroutine(Spawn(spawnTime));
        print(spawnTime);
    }


    IEnumerator Spawn(float spawnTime)
    {
        _spawnScore = 0;

        switch (spawnTime)
        {
            case 2.5f:
                _spawnScoreMax = 12;
                break;
            case 3.1f:
                _spawnScoreMax = 9;
                break;
            case 3.5f:
                _spawnScoreMax = 8;
                break;
            default:
                _spawnScoreMax = 1;
                break;
        }

        while (true)
        {
            _spawnScore++;

            Instantiate(prefab, transform.position, Quaternion.identity);

            if (_spawnScore == _spawnScoreMax)
                break;

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
