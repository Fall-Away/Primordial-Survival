using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour //개미친 코드
{
    [Header ("Enemy Prefabs")]
    [SerializeField] GameObject e;
    [SerializeField] GameObject flyEnemy;
    [SerializeField] GameObject boss;

    [Header("SpawnTime")]
    [SerializeField] int slowslow = 3;
    [SerializeField] int slow = 2;
    [SerializeField] int fast = 1;


    private float _time = 0;

    #region 한번 실행을 위한거
    private bool one = false;
    private bool two = false;
    private bool three = false;
    private bool four = false;
    private bool five = false;
    private bool six = false;
    private bool seven = false;
    private bool eight = false;
    private bool nine = false;
    private bool ten = false;
    private bool eleven = false;
    #endregion

    #region Left Enemys
    private EnemySpawner left_Enemy;
    private EnemySpawner right_Enemy;
    #endregion

    private EnemySpawner leftBoss;


    private void Awake()
    {
        #region Enemys
        left_Enemy = GameObject.Find("Left_Enemy").GetComponent<EnemySpawner>();
        right_Enemy = GameObject.Find("Right_Enemy").GetComponent<EnemySpawner>();
        #endregion

        leftBoss = GameObject.Find("Left_Boss").GetComponent<EnemySpawner>();
    }

    private void Update()
    {
        _time = Time.time;

        #region 함수 시작용 스크립트
        if (_time < 60 && one == false)
            Spawn1();
        if (_time < 120 && two == false)
            Spawn2();
        if (_time < 180 && three == false)
            Spawn3();
        if (_time < 240 && four == false)
            Spawn4();
        if (_time < 300 && five == false)
            Spawn5();
        if (_time < 360 && six == false)
            Spawn6();
        if (_time < 420 && seven == false)
            Spawn7();
        if (_time < 480 && eight == false)
            Spawn8();
        if (_time < 540 && nine == false)
            Spawn9();
        if (_time < 600 && ten == false)
            Spawn10();
        if (_time < 660 && eleven == false)
            END();
        #endregion
    }

    #region 역겨운 함수들
    private void Spawn1()
    {
        left_Enemy.StartSpawn(slowslow);
        one = true;
    }

    private void Spawn2()
    {
        left_Enemy.StopSpawn(slowslow);

        left_Enemy.StartSpawn(slowslow);
        right_Enemy.StartSpawn(slowslow);
        two = true;
    }
    
    private void Spawn3()
    {
        left_Enemy.StopSpawn(slowslow);
        right_Enemy.StopSpawn(slowslow);

        left_Enemy.StartSpawn(slow);
        right_Enemy.StartSpawn(slow);

        three = true;
    }
    
    private void Spawn4()
    {
        left_Enemy.StopSpawn(slow);
        right_Enemy.StopSpawn(slow);

        left_Enemy.StartSpawn(slowslow);
        right_Enemy.StartSpawn(slowslow);

        four = true;
    }
    
    private void Spawn5()
    {
        left_Enemy.StopSpawn(slowslow);
        right_Enemy.StopSpawn(slowslow);

        left_Enemy.StartSpawn(slow);
        right_Enemy.StartSpawn(slow);

        five = true;
    }
    
    private void Spawn6()
    {
        left_Enemy.StopSpawn(slow);
        right_Enemy.StopSpawn(slow);

        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        six = true;
    }
    
    private void Spawn7()
    {
        left_Enemy.StopSpawn(fast);
        right_Enemy.StopSpawn(fast);

        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        seven = true;
    }
    
    private void Spawn8()
    {
        left_Enemy.StopSpawn(fast);
        right_Enemy.StopSpawn(fast);

        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        eight = true;
    }
    
    private void Spawn9()
    {
        left_Enemy.StopSpawn(fast);
        right_Enemy.StopSpawn(fast);

        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        nine = true;
    }
    
    private void Spawn10()
    {
        left_Enemy.StopSpawn(fast);
        right_Enemy.StopSpawn(fast);

        left_Enemy.StartSpawn(fast);
        right_Enemy.StartSpawn(fast);

        leftBoss.StartSpawn(2147483647);
        leftBoss.StopSpawn(2147483647);

        ten = true;
    }

    private void END()
    {
        left_Enemy.StopSpawn(fast);
        right_Enemy.StopSpawn(fast);

        eleven = true;
    }
    #endregion
}
