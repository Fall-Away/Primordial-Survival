using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Player HP 스크립트입니다. 
 * 메인하시는 분이 저기 47번째줄에 HP가 0일때 실행될 함수 넣어주셔야하고,
 * 로직분이 TalkDamage 가져다가 플레이어랑 닳았을떄 실행되게 하고 매개변수로 데미지 넣어주시면 됩니다. 
 * 
 * 사실 에너미 HP로도 써도 괜찮아요
 */

public class PlayerHP : MonoBehaviour 
{
    [SerializeField] float maxHP = 10;
    float currentHP;

    public float MaxHP
    {
        get
        {
            return maxHP;
        }
    }

    public float CurrentHP
    {
        get
        {
            return currentHP;
        }
    }


    void Start()
    {
        currentHP = maxHP;
    }


    public void TakeDamge(float damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            //HP0일때 실행
        }
    }
}
