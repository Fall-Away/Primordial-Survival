using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondSkillCoolTIme : MonoBehaviour
{
    bool isCool;  //쿨타임
    public float timer;  //쿨타임
    public Text text;  //쿨타임
    void Start()
    {
        isCool = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<PauseMenu>()._isToggled) return;

        SkillCoolTime();
    }

    private void SkillCoolTime()  //쿨타임
    {
        if(isCool == false && Input.GetKeyDown(KeyCode.E))
        {
            isCool = true;
            timer = 8;
        }

        if(isCool)
        {
            timer -= Time.deltaTime;
            text.text = Mathf.Ceil(timer).ToString();
            
            if(text.text == "0")
            {
                text.text = "Ready";
                isCool = false;
            }
        }
    }
}
