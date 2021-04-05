using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bgm;
    public static AudioManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        bgm = GetComponent<AudioClip>();
        if (instance == null)
        {
            instance = this;       
        }
        else if (instance!=this)
        {
            Destroy(gameObject);
        }
        audioSource.Play();
        DontDestroyOnLoad(gameObject);

    }

    // Update is called once per frame
    void Update()
    {

    }

 }

