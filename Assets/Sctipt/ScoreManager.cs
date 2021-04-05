using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScoreManager : MonoBehaviour
{
    static int score = 0;


    public static void setScore(int value)
    {
        score += value;
    }

    public static void clearScore(int value)
    {
        score = value;
    }

    public static int getScore()
    {
        return score;
    }

    public static void InsertRank(int Score)
    {   
        for (int i = 0; i < 10; i++)
        {
            if (Score > PlayerPrefs.GetInt(i.ToString()))
            {
                for (int j = 9; j > i; j--)
                {   
                    PlayerPrefs.SetInt(j.ToString(), PlayerPrefs.GetInt((j - 1).ToString()));
                }
                PlayerPrefs.SetInt(i.ToString(), Score);
                break;
            }
        }
    }
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.Space(50);
        GUILayout.BeginVertical();
        GUILayout.Space(30);
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 50;
        myStyle.normal.textColor = Color.white;
        GUILayout.Label("현재 점수: " + score.ToString(), myStyle);
    }
}


