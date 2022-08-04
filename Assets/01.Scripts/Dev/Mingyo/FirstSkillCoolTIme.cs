using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstSkillCoolTIme : MonoBehaviour
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
        if(isCool == false && Input.GetKeyDown(KeyCode.W))
        {
            isCool = true;
            timer = 5;
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
