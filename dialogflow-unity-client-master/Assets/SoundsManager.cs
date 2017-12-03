using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsManager : MonoBehaviour {

    public AudioSource audiosour;
    public AudioClip win;
    public AudioClip lose;
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Win()
    {
        audiosour.clip = win;
        audiosour.Play();
    }
    public void Lose()
    {
        audiosour.clip = lose;
        audiosour.Play();
    }
}
