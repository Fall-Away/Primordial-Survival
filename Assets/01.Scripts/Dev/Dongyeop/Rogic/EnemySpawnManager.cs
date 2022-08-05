using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour //����ģ �ڵ�
{
    [Header("SpawnTime")]
    [SerializeField] float slowslow = 3.5f;
    [SerializeField] float slow = 3.1f;
    [SerializeField] float fast = 2.5f;


    public float _time = 0;

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
    #endregion

    #region Enemys
    private EnemySpawner left_Enemy;
    private EnemySpawner right_Enemy;

    private EnemySpawner left_fly_Enemy;
    private EnemySpawner right_fly_Enemy;

    private EnemySpawner left_Boss;
    #endregion


    private void Awake()
    {
        #region Enemys
        left_Enemy = GameObject.Find("Left_Enemy").GetComponent<EnemySpawner>();
        right_Enemy = GameObject.Find("Right_Enemy").GetComponent<EnemySpawner>();
        
        left_fly_Enemy = GameObject.Find("Left_Fly_Enemy").GetComponent<EnemySpawner>();
        right_fly_Enemy = GameObject.Find("Right_Fly_Enemy").GetComponent<EnemySpawner>();

        left_Boss = GameObject.Find("Left_Boss").GetComponent<EnemySpawner>();
        #endregion
    }

    private void Update()
    {
         _time += Time.deltaTime;

        #region 시작함수
        if (_time < 30 && one == false)
            Spawn1();
        if (30 < _time && _time < 60 && two == false)
            Spawn2();
        if (60 < _time && _time < 90 && three == false)
            Spawn3();
        if (90 < _time && _time < 120 && four == false)
            Spawn4();
        if (120 < _time && _time < 150 && five == false)
            Spawn5();
        if (150 < _time && _time < 180 && six == false)
            Spawn6();
        if (180 < _time && _time < 210 && seven == false)
            Spawn7();
        if (210 < _time && _time < 240 && eight == false)
            Spawn8();
        if (240 < _time && _time < 270 && nine == false)
            Spawn9();
        if (270 < _time && _time < 300 && ten == false)
            Spawn10();
        #endregion
    }

    #region 역겨운 함수들
    private void Spawn1()
    {
        left_Enemy.StartSpawn(3.5f);
        one = true;
    }

    private void Spawn2()
    {
        left_Enemy.StartSpawn(3.5f);
        right_Enemy.StartSpawn(3.5f);
        two = true;
    }
    
    private void Spawn3()
    {
        left_Enemy.StartSpawn(3.1f);
        right_Enemy.StartSpawn(3.1f);

        three = true;
    }
    
    private void Spawn4()
    {
        left_Enemy.StartSpawn(3.5f);
        right_Enemy.StartSpawn(3.5f);

        left_fly_Enemy.StartSpawn(3.5f);
        right_fly_Enemy.StartSpawn(3.5f);

        four = true;
    }
    
    private void Spawn5()
    {
        left_Enemy.StartSpawn(3.1f);
        right_Enemy.StartSpawn(3.1f);

        left_fly_Enemy.StartSpawn(3.1f);
        right_fly_Enemy.StartSpawn(3.1f);

        five = true;
    }
    
    private void Spawn6()
    {
        left_Enemy.StartSpawn(2.5f);
        right_Enemy.StartSpawn(2.5f);

        left_fly_Enemy.StartSpawn(3.1f);
        right_fly_Enemy.StartSpawn(3.1f);

        six = true;
    }
    
    private void Spawn7()
    {
        left_Enemy.StartSpawn(2.5f);
        right_Enemy.StartSpawn(2.5f);

        left_fly_Enemy.StartSpawn(3.1f);
        right_fly_Enemy.StartSpawn(3.1f);

        seven = true;
    }
    
    private void Spawn8()
    {
        left_Enemy.StartSpawn(2.5f);
        right_Enemy.StartSpawn(2.5f);

        left_fly_Enemy.StartSpawn(3.1f);
        right_fly_Enemy.StartSpawn(3.1f);

        eight = true;
    }
    
    private void Spawn9()
    {
        left_Enemy.StartSpawn(2.5f);
        right_Enemy.StartSpawn(2.5f);

        left_fly_Enemy.StartSpawn(2.5f);
        right_fly_Enemy.StartSpawn(2.5f);

        nine = true;
    }
    
    private void Spawn10()
    {
        left_Enemy.StartSpawn(2.5f);
        right_Enemy.StartSpawn(2.5f);

        left_fly_Enemy.StartSpawn(2.5f);
        right_fly_Enemy.StartSpawn(2.5f);

        left_Boss.StartSpawn(2147483647);

        ten = true;
    }
    #endregion
}
