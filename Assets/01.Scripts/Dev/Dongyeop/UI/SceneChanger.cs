using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [Header ("SceneNum")]
    [SerializeField] int sceneNum1;
    [SerializeField] int sceneNum2;
    [SerializeField] int sceneNum3;

    public void SceneChange1()
    {
        SceneManager.LoadScene(sceneNum1);
    }

    public void SceneChange2()
    {
        SceneManager.LoadScene(sceneNum2);
    }

    public void SceneChagne3()
    {
        SceneManager.LoadScene(sceneNum3);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
