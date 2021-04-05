using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSetting : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip bgm;
    public GameObject ao;
    bool soundset;
    public void Start()
    {
        ao = GameObject.FindWithTag("Audio");
        audioSource = ao.GetComponent<AudioSource>();
        bgm = ao.GetComponent<AudioClip>();
    }

}
