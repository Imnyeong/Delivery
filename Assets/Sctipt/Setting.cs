using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Set;
    public GameObject Exit;
    public AudioSource audioSource;
    public AudioClip bgm;
    public Image sound;
    public Image vibe;
    public Sprite on;
    public Sprite off;
    public GameObject Rank;
    public bool seton;
    public bool rankon;

    void Start()
    {
        Set.SetActive(false);
        Exit.SetActive(false);
        Rank.SetActive(false);

        if (PlayerPrefs.GetInt("sound.ToString()") != 1 && PlayerPrefs.GetInt("sound.ToString()") != 0)
        {
            PlayerPrefs.SetInt("sound.ToString()", 1);
            sound.sprite = on;
        }
        if (PlayerPrefs.GetInt("vibe.ToString()") != 1 && PlayerPrefs.GetInt("vibe.ToString()") != 0)
        {
            PlayerPrefs.SetInt("vibe.ToString()", 1);
            vibe.sprite = on;
        }
    }
    public void OnSetting()
    {
        Set.SetActive(true);
        seton = true;
    }
    public void UnSetting()
    {
        Set.SetActive(false);
        seton = false;
    }
    public void OnRanking()
    {
        Rank.SetActive(true);
        rankon = true;
    }
    public void UnRanking()
    {
        Rank.SetActive(false);
        rankon = false;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void Sound()
    {
        if (PlayerPrefs.GetInt("sound.ToString()") == 1)
        {
            GameObject Audio = GameObject.Find("Audio");
            audioSource = Audio.GetComponent<AudioSource>();
            bgm = Audio.GetComponent<AudioClip>();
            audioSource.mute = true;
            PlayerPrefs.SetInt("sound.ToString()", 0);
            sound.sprite = off;
        }
        else if (PlayerPrefs.GetInt("sound.ToString()") == 0)
        {
            GameObject Audio = GameObject.Find("Audio");
            audioSource = Audio.GetComponent<AudioSource>();
            bgm = Audio.GetComponent<AudioClip>();
            audioSource.mute = false;
            PlayerPrefs.SetInt("sound.ToString()", 1);
            sound.sprite = on;
        }
    }
    public void Vibe()
    {
        if (PlayerPrefs.GetInt("vibe.ToString()") == 1)
        {
            PlayerPrefs.SetInt("vibe.ToString()", 0);
            vibe.sprite = off;
        }
        else if (PlayerPrefs.GetInt("vibe.ToString()") == 0)
        {
            PlayerPrefs.SetInt("vibe.ToString()", 1);
            vibe.sprite = on;
        }
    }
    public static void vibeon()
    {
        if (PlayerPrefs.GetInt("vibe.ToString()") == 1)
        {
            Handheld.Vibrate();
        }
        else if (PlayerPrefs.GetInt("vibe.ToString()") == 0)
        {

        }
    }
    public void OnExit()
    {
        Exit.SetActive(true);
    }
    public void UnExit()
    {
        Exit.SetActive(false);
    }

}
