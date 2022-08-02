using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuUI;
    private bool _isToggled;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }
    private void Pause()
    {
        _isToggled = !_isToggled;
        pauseMenuUI.SetActive(_isToggled);

        if (_isToggled)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void PauseClose()
    {
        Time.timeScale = 1;

        _isToggled = false;
        pauseMenuUI.SetActive(_isToggled);
    }

    public void MainMunu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
