using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] Audios;
    public AudioSource Reproductor;

    public int ActualSong;

    public string[] NameSong;
    public TextMeshProUGUI NameText;

    // Start is called before the first frame update
    void Start()
    {
        Reproductor = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextSong()
    {
     
        ActualSong ++;

        if (ActualSong>13)
        {
            ActualSong = 0;

        }
        PlaySong();

    }
    public void BeforeSong()
    {

        ActualSong--;

        if (ActualSong < 0)
        {
            ActualSong = 13;

        }
        PlaySong();

    }
    public void PauseSong()
    {
        if(Reproductor.isPlaying)
        {
            Reproductor.Pause();
        }
        else
        {
            Reproductor.UnPause();
        }
        
        
    }
    public void PlaySong()
    {
        Reproductor.clip= Audios[ActualSong];
        Reproductor.Play();

        NameText.text = NameSong[ActualSong];

    }
    public void RandomSong()
    {
        ActualSong = Random.Range(0, 13);
        PlaySong();

    }

}
