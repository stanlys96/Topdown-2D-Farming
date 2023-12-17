using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public AudioSource gameMusic;

    private void Awake()
    {
        gameMusic = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        gameMusic.Play();
    }
}
