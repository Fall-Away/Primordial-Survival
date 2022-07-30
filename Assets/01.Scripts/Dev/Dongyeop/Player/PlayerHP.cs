using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Player HP ��ũ��Ʈ�Դϴ�. 
 * �����Ͻô� ���� ���� 47��°�ٿ� HP�� 0�϶� ����� �Լ� �־��ּž��ϰ�,
 * �������� TalkDamage �����ٰ� �÷��̾�� ������� ����ǰ� �ϰ� �Ű������� ������ �־��ֽø� �˴ϴ�. 
 * 
 * ��� ���ʹ� HP�ε� �ᵵ �����ƿ�
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
            //HP0�϶� ����
        }
    }
}
