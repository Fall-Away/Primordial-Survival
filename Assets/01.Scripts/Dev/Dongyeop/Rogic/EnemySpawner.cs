using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    
    private int _spawnScore = 0;
    private int _spawnScoreMax;


    public void StartSpawn(int spawnTime)
    {
        StartCoroutine(Spawn(spawnTime));
    }


    IEnumerator Spawn(int spawnTime)
    {
        _spawnScore = 0;

        switch (spawnTime)
        {
            case 1:
                _spawnScoreMax = 60;
                break;
            case 2:
                _spawnScoreMax = 30;
                break;
            case 3:
                _spawnScoreMax = 20;
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
