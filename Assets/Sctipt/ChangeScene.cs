using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Setting Setting;

    public void Play()
    {
        SceneManager.LoadScene("Play");
        GameManager.RestartStage();
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Pause()
    {
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        ScoreManager.clearScore(0);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void Home()
    {
        ScoreManager.clearScore(0);
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void GORestart()
    {
        ScoreManager.clearScore(0);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        GameManager.RestartStage();
        Time.timeScale = 1f;
        
    }
    public void GOHome()
    {
        SceneManager.LoadScene("Menu");
        ScoreManager.clearScore(0);
        Time.timeScale = 1f;
    }
    void Update()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                if (Setting.seton == false && Setting.rankon == false)
                    Setting.OnExit();

                if (Setting.seton == true && Setting.rankon == false)
                    Setting.UnSetting();

                if (Setting.seton == false && Setting.rankon == true)
                    Setting.UnRanking();
            }
        }
    }
}
