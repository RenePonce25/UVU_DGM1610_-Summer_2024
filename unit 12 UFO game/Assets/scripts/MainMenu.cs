using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;
    private AudioSource onStartSound;
    public AudioClip startSound;

    private void Start()
    {
        onStartSound = GetComponent<AudioSource>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);//scene to load
        Debug.Log("New Scene Loaded.");
      onStartSound.PlayOneShot(startSound, 1.0f);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game.");
    }
}
