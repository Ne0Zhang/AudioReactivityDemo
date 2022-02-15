using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPause : MonoBehaviour
{
    public Text message;
    public AudioSource music;

    private bool control = false, playing = true;
    // Start is called before the first frame update
    void Start()
    {
        message.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (control) {
            if(Input.GetKeyDown(KeyCode.Space) && playing) {
                playing = !playing;
                music.Pause();
            }
            else if (Input.GetKeyDown(KeyCode.Space) && !playing){
                playing = !playing;
                music.Play();
            }
        }
    }

   
    void OnTriggerStay(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
            control = true;
			message.enabled = true;
		}
	}

    void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			control = false;
            message.enabled = false;
		}
	}
}
