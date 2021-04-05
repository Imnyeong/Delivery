using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rank : MonoBehaviour
{

    public Text Ranking;
    public GameObject RankingMenu;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            Ranking.text =
                "\n\n" +
                "1등 " + PlayerPrefs.GetInt("0") + "\n\n" +
                "2등 " + PlayerPrefs.GetInt("1") + "\n\n" +
                "3등 " + PlayerPrefs.GetInt("2") + "\n\n" +
                "4등 " + PlayerPrefs.GetInt("3") + "\n\n" +
                "5등 " + PlayerPrefs.GetInt("4") + "\n\n" +
                "6등 " + PlayerPrefs.GetInt("5") + "\n\n" +
                "7등 " + PlayerPrefs.GetInt("6") + "\n\n" +
                "8등 " + PlayerPrefs.GetInt("7") + "\n\n" +
                "9등 " + PlayerPrefs.GetInt("8") + "\n\n" +
                "10등 " + PlayerPrefs.GetInt("9") + "\n\n" +
                "언제나 안전주행 하세요!";
        }
    }

}
