using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;

    static bool isEnded = false;

    public PlayerMovement pm;
    public GameObject Pause;
    public Text Score;
    public GameObject GameOver;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        Pause.SetActive(false);
        GameOver.SetActive(false);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Time.timeScale = 1f;

    }

    // Update is called once per frame

    void OnGUI()
    {
    }

    public static void EndGame()
    {
        Time.timeScale = 0f;
        isEnded = true;
    }
    public static void RestartStage()
    {
        isEnded = false;
    }
    void Update()
    {
        if (!isEnded&& Time.timeScale == 1f)
        {
            ScoreManager.setScore(1);
            Pause.SetActive(false);
            GameOver.SetActive(false);
        }
        if (isEnded&&Time.timeScale == 0f)
        {
            if (ScoreManager.getScore() < 500)
            {
                if (PlayerMovement.getRnd() < 33)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "머리를 다쳐 경상을 입으셨습니다. \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if(PlayerMovement.getRnd() >= 33 && PlayerMovement.getRnd() < 66)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "팔을 다쳐 경상을 입으셨습니다. \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if (PlayerMovement.getRnd() >= 66 && PlayerMovement.getRnd() < 99)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "다리를 다쳐 경상을 입으셨습니다. \n점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if (PlayerMovement.getRnd() > 99)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "운 좋게 살아남으셨군요! \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
            }
            else if (ScoreManager.getScore() >= 500 && ScoreManager.getScore() < 1500)
            {
                if (PlayerMovement.getRnd() < 33)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "머리를 다쳐 중상을 입으셨습니다. \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if (PlayerMovement.getRnd() >= 33 && PlayerMovement.getRnd() < 66)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "팔을 다쳐 중상을 입으셨습니다. \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if (PlayerMovement.getRnd() >= 66 && PlayerMovement.getRnd() < 99)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "다리를 다쳐 중상을 입으셨습니다. \n점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if (PlayerMovement.getRnd() > 99)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "운 좋게 살아남으셨군요! \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
            }
            else if (ScoreManager.getScore() >= 1500)
            {
                if (PlayerMovement.getRnd() < 33)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "머리를 다쳐 사망하셨습니다. \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if (PlayerMovement.getRnd() >= 33 && PlayerMovement.getRnd() < 66)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "팔을 다쳐 사망하셨습니다. \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if (PlayerMovement.getRnd() >= 66 && PlayerMovement.getRnd() < 99)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "다리를 다쳐 사망하셨습니다. \n점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
                else if (PlayerMovement.getRnd() > 99)
                {
                    Pause.SetActive(false);
                    GameOver.SetActive(true);
                    Score.text = "운 좋게 살아남으셨군요! \n 점수는 " + ScoreManager.getScore() + " 점 입니다.";
                }
            }
        }
        if (!isEnded&&Time.timeScale == 0f)
        {
            Pause.SetActive(true);
            GameOver.SetActive(false);
        }
    }
}

