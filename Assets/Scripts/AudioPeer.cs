using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// create this required component....
[RequireComponent (typeof (AudioSource))]

public class AudioPeer : MonoBehaviour {

	AudioSource _audioSource;
	public static float[] _samples = new float[512];

	void Start () {
		
		_audioSource = GetComponent<AudioSource> ();	

	}
	
	// Update is called once per frame
	void Update () {

		GetSpectrumAudioSource ();

	}


	void GetSpectrumAudioSource()
	{
        // this method computes the fft of the audio data, and then populates spectrumData with the spectrum data.
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
	}
}


