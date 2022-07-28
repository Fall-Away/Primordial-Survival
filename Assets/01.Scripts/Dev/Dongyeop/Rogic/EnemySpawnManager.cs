using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject flyEnemy;
    [SerializeField] GameObject boss;

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
    #endregion

    #region Left Enemys
    private EnemySpawner leftEnemy1;
    private EnemySpawner leftEnemy2;
    private EnemySpawner leftEnemy3;
    private EnemySpawner leftEnemy4;
    private EnemySpawner leftEnemy5;
    private EnemySpawner leftEnemy6;
    private EnemySpawner leftEnemy7;
    private EnemySpawner leftEnemy8;
    private EnemySpawner leftEnemy9;
    private EnemySpawner leftEnemy10;
    #endregion
    #region Right Enemys
    private EnemySpawner rightEnemy2;
    private EnemySpawner rightEnemy3;
    private EnemySpawner rightEnemy4;
    private EnemySpawner rightEnemy5;
    private EnemySpawner rightEnemy6;
    private EnemySpawner rightEnemy7;
    private EnemySpawner rightEnemy8;
    private EnemySpawner rightEnemy9;
    private EnemySpawner rightEnemy10;
    #endregion

    private EnemySpawner leftBoss10;


    private void Awake()
    {
        #region Left Enemys
        leftEnemy1 = GameObject.Find("1_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy2 = GameObject.Find("2_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy3 = GameObject.Find("3_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy4 = GameObject.Find("4_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy5 = GameObject.Find("5_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy6 = GameObject.Find("6_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy7 = GameObject.Find("7_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy8 = GameObject.Find("8_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy9 = GameObject.Find("9_Left_Enemy").GetComponent<EnemySpawner>();
        leftEnemy10 = GameObject.Find("10_Left_Enemy").GetComponent<EnemySpawner>();
        #endregion
        #region Right Enemys
        leftEnemy2 = GameObject.Find("2_Right_Enemy").GetComponent<EnemySpawner>();
        leftEnemy3 = GameObject.Find("3_Right_Enemy").GetComponent<EnemySpawner>();
        leftEnemy4 = GameObject.Find("4_Right_Enemy").GetComponent<EnemySpawner>();
        leftEnemy5 = GameObject.Find("5_Right_Enemy").GetComponent<EnemySpawner>();
        leftEnemy6 = GameObject.Find("6_Right_Enemy").GetComponent<EnemySpawner>();
        leftEnemy7 = GameObject.Find("7_Right_Enemy").GetComponent<EnemySpawner>();
        leftEnemy8 = GameObject.Find("8_Right_Enemy").GetComponent<EnemySpawner>();
        leftEnemy9 = GameObject.Find("9_Right_Enemy").GetComponent<EnemySpawner>();
        leftEnemy10 = GameObject.Find("10_Right_Enemy").GetComponent<EnemySpawner>();
        #endregion

        leftBoss10 = GameObject.Find("10_Left_Boss").GetComponent<EnemySpawner>();
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
        #endregion
    }

    #region 역겨운 함수들
    private void Spawn1()
    {
        leftEnemy1.StartSpawn(enemy, 1);
        one = true;
    }

    private void Spawn2()
    {
        leftEnemy2.StartSpawn(enemy, 1);
        rightEnemy2.StartSpawn(enemy, 1);
        two = true;
    }
    
    private void Spawn3()
    {
        leftEnemy3.StartSpawn(enemy, 1);
        rightEnemy3.StartSpawn(enemy, 1);

        three = true;
    }
    
    private void Spawn4()
    {
        leftEnemy4.StartSpawn(enemy, 1);
        rightEnemy4.StartSpawn(enemy, 1);

        four = true;
    }
    
    private void Spawn5()
    {
        leftEnemy5.StartSpawn(enemy, 1);
        rightEnemy5.StartSpawn(enemy, 1);

        five = true;
    }
    
    private void Spawn6()
    {
        leftEnemy6.StartSpawn(enemy, 1);
        rightEnemy6.StartSpawn(enemy, 1);

        six = true;
    }
    
    private void Spawn7()
    {
        leftEnemy7.StartSpawn(enemy, 1);
        rightEnemy7.StartSpawn(enemy, 1);

        seven = true;
    }
    
    private void Spawn8()
    {
        leftEnemy8.StartSpawn(enemy, 1);
        rightEnemy8.StartSpawn(enemy, 1);

        eight = true;
    }
    
    private void Spawn9()
    {
        leftEnemy9.StartSpawn(enemy, 1);
        rightEnemy9.StartSpawn(enemy, 1);

        nine = true;
    }
    
    private void Spawn10()
    {
        leftEnemy10.StartSpawn(enemy, 1);
        rightEnemy10.StartSpawn(enemy, 1);

        leftBoss10.StartSpawn(boss, 1);

        ten = true;
    }
    #endregion
}
