using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Include UI library

public class PlaySound : MonoBehaviour
{
    //References to variables
    public AudioSource soundPlayer;
    public Slider volSlider;
    public Slider pitchSlider;
    public Toggle muteToggle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        soundPlayer.volume = volSlider.value;
        soundPlayer.pitch = pitchSlider.value;
        soundPlayer.mute = muteToggle.isOn;

    }


    public void playThisSoundEffect ()
    {
        soundPlayer.Play();
    }



        

}
